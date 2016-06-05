using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjetCantine;

namespace ProjetCantine
{
    class personne
    {
        private string prenom;
        private string nom;
        private DateTime date_naissance;
        private string courriel;
        private Int64 telephone;

        public personne() { }

        ~personne() { }


        public void set_prenom(string prenom) {
            this.prenom = prenom;
        }

        public void set_nom(string nom)
        {
            this.nom = nom;
        }
        public void set_datenaissance(DateTime date)
        {
            this.date_naissance = date;
        }
        public void set_courriel(string courriel)
        {
            this.courriel = courriel;
        }
        public void set_telephone(Int64 tel)
        {
            this.telephone = tel;
        }

        public string get_prenom()
        {
            return this.prenom;
        }

        public string get_nom()
        {
            return this.nom;
        }
        public DateTime get_datenaissance()
        {
            return this.date_naissance;
        }
        public string get_courriel()
        {
            return this.courriel;
        }
        public Int64 get_telephone()
        {
            return this.telephone;
        }
    }
}
