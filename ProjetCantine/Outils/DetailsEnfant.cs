using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjetCantine.Models;

namespace ProjetCantine.Outils
{
    class DetailsEnfant
    {
        private int identifiant;
        private String periode_start;
        private String periode_stop;
        private List<String[]> details_periode = new List<String[]>();
        private DbConnection dbTalk = new DbConnection();
        private List<String[]> lesPrix = new List<String[]>();

        public DetailsEnfant(int id, String date_start, String date_stop)
        {
            set_arguments(id, date_start, date_stop);
            set_periodeDetails(details_periode, id, periode_start, periode_stop);
            set_priceList(details_periode);
        }

        private void set_periodeDetails(List<String[]> liste, int enfant, String d_start, String d_stop)
        {
            dbTalk.get_listeRepasUnEnfant(ref liste, enfant, d_start , d_stop);
            dbTalk.add_unitPriceToEachLunch(ref liste);
        }

        private void set_priceList(List<String[]> liste)
        {
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
        {
            identifiant = id;
            periode_start = DateTime.Parse(start).ToString("yyyyMMdd");
            periode_stop = DateTime.Parse(stop).ToString("yyyyMMdd");
        }

        private bool IsNumeric(String test) {
            int t;
            return int.TryParse(test, out t);
        }

        public int get_nbRepas(int type)
        {
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
        {
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
        {
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
        { 
            return details_periode;
        }

        public List<String[]> get_priceList()
        {
            return lesPrix;
        }
    }
}
