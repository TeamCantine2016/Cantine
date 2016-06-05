using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProjetCantine;
using ProjetCantine.Vues;
using System.Data;
using System.Text;
using System.Linq;
using ProjetCantine.Models;


namespace UnitTestProjetCantine
{
    [TestClass]
    public class UnitTest1  
    {
        personne per = new personne();
     //   utilisateur uti = new utilisateur();
     //   Form_EncodageFactures fac = new Form_EncodageFactures(labelchaud1, labelchaud2, labelfroid,labelaucun);
        db_cantineDataSet db = new db_cantineDataSet();

        [TestMethod]
        public void TestMethod1()
        {
            string prenom = db.tbl_personne.Rows[1].ToString();

           // db.tbl_personne.FindByid(1);
           // Assert.AreEqual("Marco", prenom);

            per.get_nom();
           per.set_nom("Aladdin");
          
            Assert.AreEqual("Aladdin", per.get_nom());
        }
       
    }
}
