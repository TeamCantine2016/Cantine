using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excel = Microsoft.Office.Interop.Excel;
using System.IO;

namespace ProjetCantine
{
    class ApercuFacture
    {
        public String facture()
        {

            try
            {

                // ouverture du fichier
                Excel.Application xlApp = new Excel.Application();
                xlApp.Visible = false;

                object misValue = System.Reflection.Missing.Value;
                string pathFacture = @"D:\GitHub\Factures\Facture.xlsx";
                string pathSortie = @"D:\GitHub\";
                Excel.Workbook wbk = xlApp.Workbooks.Open(pathFacture);
                Excel.Worksheet ws = new Excel.Worksheet();

                ws = (Excel.Worksheet)wbk.Worksheets[1];

                //Phase d'encodage des données

                //Encodage établissement

                ws.Cells[7, "A"] = "Institut technique E.Lenoir";
                ws.Cells[8, "A"] = "2" + "," + " Chemin de Weyler";
                ws.Cells[9, "A"] = "Arlon" + "6700" + "Belgique";
                ws.Cells[11, "A"] = "Tél: " + "063/00.00.00";
                ws.Cells[13, "A"] = "Fax: " + "063/00.00.01";
                ws.Cells[15, "A"] = "Email: " + " itela@gmail.com";

                //Encodage Client

                ws.Cells[7, "D"] = "55256"; //N° facture
                ws.Cells[7, "E"] = "09-02-2016"; // Date Facture
                ws.Cells[7, "F"] = "69"; //Code Client
                ws.Cells[9, "D"] = "Hommer Simpson";
                ws.Cells[11, "D"] = "742" + "," + " Evergreen Terracenn";
                ws.Cells[13, "D"] = "Springfield" + "158" + "USA";

                // Encodage des repas 

                // A faire une fois que la partie facturation aura été faite

                //Ecodage Banque

                ws.Cells[40, "A"] = "21"; //TVA
                ws.Cells[47, "B"] = "BE89 0015 1589 5985 5460"; //Banque BE
                ws.Cells[48, "B"] = "BCEELLLLL"; //Bic BE
                ws.Cells[47, "E"] = "LU89 0015 1589 5985 5460"; //Banque LU
                ws.Cells[48, "E"] = "BBRELLLLL"; //Bic LU


                // sauvegarde et fermeture du programme
                if (File.Exists(pathSortie) == false)
                {
                    DirectoryInfo di = Directory.CreateDirectory(pathSortie);
                }

                pathSortie = pathSortie + "09-02-2016" + "_" + "55256" + ".pdf";

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
