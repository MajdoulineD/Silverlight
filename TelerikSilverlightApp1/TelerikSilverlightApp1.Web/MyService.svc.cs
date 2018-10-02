using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Activation;

namespace TelerikSilverlightApp1.Web
{
    [ServiceContract(Namespace = "")]
    [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
    public class MyService
    {
        [OperationContract]
        public Dictionary<string, int> GetFilieresStats()
        {
            EtudiantEntities e = new EtudiantEntities();
            var x = from item in e.Filieres
                    select item;

            Dictionary<string, int> d = new Dictionary<string, int>();
            
            foreach (var item in x)
            {
                
                var y = from iitem in e.Etudiants
                        where iitem.filiere == item.id
                        select iitem;

                d.Add(item.nom_filiere, y.Count());
                
            }
            // Add your operation implementation here
            return d;
        }

        

        [OperationContract]
        public Dictionary<string, string[]> GetAllStudents()
        {
            EtudiantEntities e = new EtudiantEntities();
            var x = from item in e.Etudiants
                    select item;

            Dictionary<string, string[]> d = new Dictionary<string, string[]>();

            foreach (var item in x)
            {
                string[] s = new string[] { item.nom + " " + item.prenom, item.picture };
                d.Add(item.cne.ToString(), s);
            }
            return d;
        }

        [OperationContract]
        public void DeleteStudent(string cne)
        {
            int CNE = int.Parse(cne);
            EtudiantEntities e = new EtudiantEntities();
            var x = (from item in e.Etudiants
                     where item.cne == CNE
                     select item).SingleOrDefault();

            e.Etudiants.Remove(x);
            e.SaveChanges();
        }

        [OperationContract]
        public Etudiant getStudent(int cne)
        {
            EtudiantEntities e = new EtudiantEntities();
            var x = (from item in e.Etudiants
                     where item.cne == cne
                     select item).SingleOrDefault();
            Etudiant ee = new Etudiant();
            ee.nom = x.nom;
            ee.cne = x.cne;
            ee.date_naissance = x.date_naissance;
            ee.email = x.email;
            ee.filiere = x.filiere;
            ee.note = x.note;
            ee.picture = x.picture;
            ee.prenom = x.prenom;
            
            return ee;
        }
        [OperationContract]
        public List<Etudiant> GetStudentsByFiliere(string filiere)
        {
            EtudiantEntities e = new EtudiantEntities();
            var x = from item in e.Etudiants
                    where item.filiere == filiere
                    select item;

            List<Etudiant> l = new List<Etudiant>();

            foreach (var item in x)
            {
                Etudiant ee = new Etudiant();
                ee.nom = item.nom;
                ee.cne = item.cne;
                ee.date_naissance = item.date_naissance;
                ee.email = item.email;
                ee.filiere = item.filiere;
                ee.note = item.note;
                ee.picture = item.picture;
                ee.prenom = item.prenom;

                l.Add(ee);
            }

            return l;
        }

        [OperationContract]
        public List<Filiere> GetAllFilieres()
        {
            EtudiantEntities e = new EtudiantEntities();
            var x = from item in e.Filieres
                    select item;

            List<Filiere> l = new List<Filiere>();
            foreach (var item in x)
            {
                var f = new Filiere();
                f.id = item.id;
                f.nom_filiere = item.nom_filiere;
                f.responsable = item.responsable;
                l.Add(f);
            }

            return l;
        }

        // Add more operations here and mark them with [OperationContract]
    }
}
