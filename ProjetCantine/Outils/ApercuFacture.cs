using System;
using Excel = Microsoft.Office.Interop.Excel;
using System.IO;
using ProjetCantine.Models;
using System.Collections;
using ProjetCantine.Outils;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ProjetCantine
{
    class ApercuFacture
    {

        public String facture( ArrayList lesEnfants, int facture_id, DateTime debut, DateTime fin
                            , string codeClient, string nomClient, string prenomClient
                            , string adresseClient, string villeClient, string paysClient)

        {

            try
            {
                DbConnection dbTalk = new DbConnection();

                // Détails établissement
                DetailsEtablissement etablissement = new DetailsEtablissement();

                // TVA
                String query = dbTalk.getQuery("tva");
                float tva = float.Parse(dbTalk.recupDataScalar(query));

                // ouverture d'excel en mode caché et y intégrer le brouillon facture
                Excel.Application xlApp = new Excel.Application();
                xlApp.Visible = false;
                
                object misValue = System.Reflection.Missing.Value;
                // Cette ligne ci-dessous permet d'initializer path sur le repertoire racine d'ou est exécuté l'application
                string path = System.IO.Directory.GetCurrentDirectory();
                // Avec path initialisé, j'ajoute dans mon fichier de solution dans ..\bin\Debug\ le dossier \Resources\ avec le fichier excel dedans, donc on a ..\bin\Debug\Resources\Factures.xlsx
                string pathFacture = path + @"\Resources\Facture.xlsx";
                string pathSortie = @"C:\Factures";
                // Création
                Excel.Workbook wbk = xlApp.Workbooks.Open(pathFacture);
                Excel.Worksheet ws = new Excel.Worksheet();
                ws = (Excel.Worksheet)wbk.Worksheets[1];

                //Encodage établissement
                // Test pour voir si il y a déjà des infos dans la db
                if (etablissement.get_nom().Length > 0)
                {
                    ws.Cells[7, "A"] = etablissement.get_nom();
                    ws.Cells[8, "A"] = etablissement.get_numEtRue();
                    ws.Cells[9, "A"] = etablissement.get_cpEtVille() + " (" + etablissement.get_pays() + ")";
                    ws.Cells[15, "A"] = "Mail : " + etablissement.get_courriel();
                    ws.Cells[11, "A"] = "Téléphone : " + etablissement.get_tel();
                    ws.Cells[13, "A"] = "Fax : " + etablissement.get_fax();
                    ws.Cells[48, "B"] = stringSplit(etablissement.get_banque_BE());
                    ws.Cells[49, "B"] = stringSplit(etablissement.get_bic_BE());
                    ws.Cells[48, "E"] = stringSplit(etablissement.get_banque_LU());
                    ws.Cells[49, "E"] = stringSplit(etablissement.get_bic_LU());
                }
                else
                {
                    ws.Cells[7, "A"] = "Aucun établissement est enregistré!";
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
                int reference = 0;
                int position = 22;

                foreach (DetailsEnfant enfant in lesEnfants)
                {
                    List<String[]> listePrix = enfant.get_priceList();

                    foreach (String[] details in listePrix)
                    {
                        if (details[1] != "0")
                        {
                            ws.Cells[position, "A"] = ++reference;
                            switch (details[0])
                            {
                                case "1": ws.Cells[position, "B"] = "repas chaud 1"; break;
                                case "2": ws.Cells[position, "B"] = "repas chaud 2"; break;
                                case "3": ws.Cells[position, "B"] = "repas froid"; break;
                                default: ws.Cells[position, "B"] = "aucun repas"; break;
                            }
                            ws.Cells[position, "D"] = details[1];
                            ws.Cells[position, "E"] = float.Parse(details[2]);
                            position++;
                        }
                    }
                }

                // Affichage et calcul de montant de la tva
                ws.Cells[41, "D"] = "Montant de la TVA  à " + tva.ToString() + " %";
                ws.Cells[41, "G"] = float.Parse(ws.Cells[39, 7].Value.ToString()) * (tva / 100);

                // Mode de paiement et date d'échéance
                ws.Cells[17, 3] = "virement bancaire";
                ws.Cells[18, 3] = (DateTime.Now.AddDays(30)).ToString("dd/MM/yyyy");

                // sauvegarde et fermeture du programme
                if (File.Exists(pathSortie) == false)
                {
                    DirectoryInfo di = Directory.CreateDirectory(pathSortie);
                }

                // chemin d'accès de la facture
                pathSortie = pathSortie + "\\F_" + facture_id.ToString() + ".pdf";

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
                return "Problème lors de la  phase de création du pdf :\r\n\r\n" + msg;
            }

        }


        private String typeRepas(int i)
        {
            String type = "";
            switch (i)
            {
                case 1:
                    type = "repas chaud 1";
                    break;
                case 2:
                    type = "repas chaud 2";
                    break;
                case 3:
                    type = "repas froid";
                    break;
                case 4:
                    type = "aucun repas";
                    break;
                default:
                    type = "default";
                    break;
            }
            return type;
        }

        private String stringSplit(String thisString)
        {
            String split = "";

            for(int i = 0; i< thisString.Length; i++)
            {
                if (i % 4 == 0 && i != 0)
                {
                    split += " ";
                }
                split += thisString[i];
            }

            return split;
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
            try
            {
                System.Diagnostics.ProcessStartInfo psi = new System.Diagnostics.ProcessStartInfo(add, "");
                System.Diagnostics.Process.Start(psi);
            }
            catch (SystemException exception)
            {
                MessageBox.Show("Facture introuvable ou innexistante : " + exception.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
