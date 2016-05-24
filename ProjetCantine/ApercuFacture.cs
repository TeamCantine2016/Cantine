using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excel = Microsoft.Office.Interop.Excel;
using System.IO;
using System.Data.SqlClient;
using ProjetCantine.Models;

using ProjetCantine.Vues;

namespace ProjetCantine
{
    class ApercuFacture
    {
        SqlConnection maCon = new SqlConnection(DbConnection.connectionString);

        public String facture(string repaschaud1, string repaschaud2, string repasfroid, string aucun, string cmptchaud1, string cmptchaud2, string cmptfroid, string cmptaucun, int facture_id, DateTime debut, DateTime fin
                                ,string codeClient, string nomClient , string prenomClient , string adresseClient,string villeClient ,string paysClient)
        {

            try
            {

                // ouverture du fichier
                Excel.Application xlApp = new Excel.Application();
                xlApp.Visible = false;

                object misValue = System.Reflection.Missing.Value;
                string pathFacture = @"C:\BDD\Factures\Facture.xlsx";
                string pathSortie = @"C:\BDD\Factures";
                Excel.Workbook wbk = xlApp.Workbooks.Open(pathFacture);
                Excel.Worksheet ws = new Excel.Worksheet();

                ws = (Excel.Worksheet)wbk.Worksheets[1];

                //Phase d'encodage des données

                //Encodage établissement
                String query = "SELECT * FROM tbl_etablissement Inner join tbl_adresse on tbl_adresse.id = tbl_etablissement.adresse_id";
                SqlCommand maCommand = new SqlCommand(query, maCon);
                maCon.Open();

                SqlDataReader dr = maCommand.ExecuteReader();
                dr.Read();

                // Test pour voir si il y a déjà des infos dans la db
                if (dr.HasRows == true)
                {

                    ws.Cells[7, "A"] = dr["nom_etablissement"].ToString();
                    ws.Cells[8, "A"] = dr["rue"].ToString() + " " + dr["numero"].ToString();
                    ws.Cells[9, "A"] = dr["ville"].ToString() + " " + dr["code_postal"].ToString() + " " + dr["pays"].ToString();
                    ws.Cells[15, "A"] = dr["courriel"].ToString();
                    ws.Cells[11, "A"] = dr["telephone"].ToString();
                    ws.Cells[13, "A"] = dr["fax"].ToString();
                    ws.Cells[47, "B"] = dr["banque_BE"].ToString();
                    ws.Cells[48, "B"] = dr["bic_BE"].ToString();
                    ws.Cells[47, "E"] = dr["banque_LU"].ToString();
                    ws.Cells[48, "E"] = dr["bic_LU"].ToString();
                    ws.Cells[40, "A"] = dr["tva"].ToString();

                    maCon.Close();

                }

              

                ws.Cells[7, "D"] = facture_id; //N° facture
                ws.Cells[7, "E"] = DateTime.Today; // Date Facture
                ws.Cells[7, "F"] = codeClient; //Code Client
                ws.Cells[9, "D"] = nomClient + " " + prenomClient;
                ws.Cells[11, "D"] = adresseClient;
                ws.Cells[13, "D"] = villeClient + " " + paysClient;

                //Encodage période

               ws.Cells[20, "C"] = debut; 
                ws.Cells[20, "E"] = fin; 

                //Encodage repas

                ws.Cells[22, "B"] = repaschaud1;
                ws.Cells[23, "B"] = repaschaud2;
                ws.Cells[24, "B"] = repasfroid;
                ws.Cells[25, "B"] = aucun;

                ws.Cells[22, "D"] = cmptchaud1;
                ws.Cells[23, "D"] = cmptchaud2;
                ws.Cells[24, "D"] = cmptfroid;
                ws.Cells[25, "D"] = cmptaucun;


                // sauvegarde et fermeture du programme
                if (File.Exists(pathSortie) == false)
                {
                    DirectoryInfo di = Directory.CreateDirectory(pathSortie);
                }

                pathSortie = pathSortie +"_"+ nomClient + "-" + prenomClient +  "_" +  facture_id.ToString() +  ".pdf";

                ws.ExportAsFixedFormat(Excel.XlFixedFormatType.xlTypePDF, pathSortie);
                //wbk.SaveAs(@"C:\Users\Florian\Desktop\test.xls"); //sauver dans un autre document Excel

                wbk.Close(false, misValue, misValue);
                xlApp.Quit();

                releaseObject(ws);
                releaseObject(wbk);
                releaseObject(xlApp);


                return pathSortie;

            }
            catch (Exception msg)
            {
                return "Problème lors de la  phase de création du pdf :" + msg;
            }

        }

        private void releaseObject(object obj)
        {
            try
            {
                System.Runtime.InteropServices.Marshal.ReleaseComObject(obj);
                obj = null;
            }
            catch
            {
                obj = null;
                //MessageBox.Show("Problème durant l'exportation\r\n Code erreur #EX02");
            }
            finally
            {
                GC.Collect();
            }
        }

        public void affichageFacture(String add)
        {
            System.Diagnostics.ProcessStartInfo psi = new System.Diagnostics.ProcessStartInfo(add, "");
            System.Diagnostics.Process.Start(psi);

        }
    }
}
