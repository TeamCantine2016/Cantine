//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProjetCantine.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class tbl_personne
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbl_personne()
        {
            this.tbl_relation_activite = new HashSet<tbl_relation_activite>();
            this.tbl_relation_repas = new HashSet<tbl_relation_repas>();
            this.tbl_utilisateur = new HashSet<tbl_utilisateur>();
            this.tbl_historique_facture = new HashSet<tbl_historique_facture>();
            this.tbl_facture = new HashSet<tbl_facture>();
            this.tbl_personne1 = new HashSet<tbl_personne>();
            this.tbl_personne2 = new HashSet<tbl_personne>();
        }
    
        public int id { get; set; }
        public string prenom { get; set; }
        public string nom { get; set; }
        public System.DateTime date_naissance { get; set; }
        public string courriel { get; set; }
        public Nullable<long> telephone { get; set; }
        public byte type_personne { get; set; }
        public int adresse { get; set; }
    
        public virtual tbl_adresse tbl_adresse { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_relation_activite> tbl_relation_activite { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_relation_repas> tbl_relation_repas { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_utilisateur> tbl_utilisateur { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_historique_facture> tbl_historique_facture { get; set; }
        public virtual tbl_type_personne tbl_type_personne { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_facture> tbl_facture { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_personne> tbl_personne1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_personne> tbl_personne2 { get; set; }
    }
}
