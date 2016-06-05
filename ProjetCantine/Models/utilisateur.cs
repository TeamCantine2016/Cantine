using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjetCantine;

namespace ProjetCantine
{
    public class utilisateur
    {
        private int id;
        private string pseudo;
        private string mdp;
        private string mdp_controle;
        private string droits;
        private bool etat;
        private int id_personne;

        public utilisateur() { }

        ~utilisateur() { }


        public void set_id(int t_id) {
            this.id = t_id;
        }

        public void set_pseudo(string t_pseudo)
        {
            this.pseudo = t_pseudo;
        }

        public void set_mdp(string t_mdp)
        {
            this.mdp = t_mdp;
        }

        public void set_mdpcont(string t_mdpcont)
        {
            this.mdp_controle = t_mdpcont;
        }

        public void set_droits(string t_droits)
        {
            this.droits = t_droits;
        }

        public void set_etat(bool t_etat)
        {
            this.etat = t_etat;
        }

        public void set_idpersonne(int t_idpers)
        {
            this.id_personne = t_idpers;
        }

        public int get_id()
        {
            return this.id;
        }

        public string get_pseudo()
        {
            return this.pseudo;
        }

        public string get_mdp()
        {
            return this.mdp;
        }

        public string get_mdpcont()
        {
            return this.mdp_controle;
        }

        public string get_droits()
        {
            return this.droits;
        }

        public bool get_etat()
        {
            return this.etat;
        }

        public int get_idpersonne()
        {
            return this.id_personne;
        }
    }

}
