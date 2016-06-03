using System;
using System.Collections.Generic;
using ProjetCantine.Models;

namespace ProjetCantine.Outils
{
    class DetailsEnfant
    {
        // Attributs enfant
        private int identifiant;
        private String periode_start;
        private String periode_stop;
        private List<String[]> details_periode = new List<String[]>();
        private DbConnection dbTalk = new DbConnection();
        private List<String[]> lesPrix = new List<String[]>();

        // constructeur de l'objet enfant
        public DetailsEnfant(int id, String date_start, String date_stop)
        {
            set_arguments(id, date_start, date_stop); // affecter aux attributs de base de l'objet
            set_periodeDetails(details_periode, id, periode_start, periode_stop); // récupérer toutes les infos pour la periode donnée
            set_priceList(details_periode); // comptabiliser par type de repas le total
        }

        private void set_periodeDetails(List<String[]> liste, int enfant, String d_start, String d_stop)
        {   // récupérer toutes les infos de la consomation de l'enfant en cours
            dbTalk.get_listeRepasUnEnfant(ref liste, enfant, d_start , d_stop);
            // insérer le prix du plat selon la date de consomation et le prix actuel à cette date précise
            dbTalk.add_unitPriceToEachLunch(ref liste);
        }

        private void set_priceList(List<String[]> liste)
        { // voir commentaire appel de fonction
            float price = 0;
            int count = 0;
            String[] bilan;
            bool flag_start = true;

            for (int i = 1; i <= 4; i++)
            {
                foreach (String[] element in liste)
                {
                    if (element[0] == i.ToString())
                    {
                        if (flag_start)
                        {
                            price = float.Parse(element[2]);
                            flag_start = false;
                        }

                        if (i == int.Parse(element[0]) && float.Parse(element[2]) == price)
                        {
                            count++;
                        }
                        else
                        {
                            bilan = new String[] { i.ToString(), count.ToString(), price.ToString() };
                            lesPrix.Add(bilan);
                            price = float.Parse(element[2]);
                            count = 1;
                        }
                    }
                }

                bilan = new String[] { i.ToString(), count.ToString(), price.ToString() };
                lesPrix.Add(bilan);
                count = 0;
                flag_start = true;
                
            }
        }

        private void set_arguments(int id, String start, String stop)
        { // voir commentaire appel de fonction
            identifiant = id;
            periode_start = DateTime.Parse(start).ToString("yyyyMMdd");
            periode_stop = DateTime.Parse(stop).ToString("yyyyMMdd");
        }

        private bool IsNumeric(String test)
        { // fonction de test si la chaîn de caractères est numérique
            int t;
            return int.TryParse(test, out t);
        }

        public int get_nbRepas(int type)
        { // appel externe pour obtenir le nombre de repas d'un type donné
            int count = 0;
            foreach (String[] element in details_periode)
            {
                if (IsNumeric(element[0]))
                {
                    if (int.Parse(element[0]) == type)
                    {
                        count++;
                    }
                }
            }
            return count;
        }

        public float get_totalPriceLunchType(int type)
        { // appel externe pour obtenir le total de la consomation de l'enfant par type de repas
            float total = 0;
            foreach (String[] element in details_periode)
            {
                if (IsNumeric(element[0]))
                {
                    if (int.Parse(element[0]) == type)
                    {
                        total += float.Parse(element[2]);
                    }
                }
            }
            return total;
        }

        public float get_totalPriceLunch()
        { // appel externe pour obtenir le total de la consomation de l'enfant tout type confondu
            float total = 0;
            foreach (String[] element in details_periode)
            {
                if (IsNumeric(element[0]))
                {
                    total += float.Parse(element[2]);
                }
            }
            return total;
        }

        public List<String[]> get_details()
        {  // appel externe pour obtenir un liste détaillé de la consomation de l'enfant
            return details_periode;
        }

        public List<String[]> get_priceList()
        {   // appel externe pour obtenir un liste des prix cummulés par type de repas
            return lesPrix;
        }
    }
}
