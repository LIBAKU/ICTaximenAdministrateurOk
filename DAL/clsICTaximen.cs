using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class clsPersonne
    {
        public int Id { get; set; }
        public string Nom{ get; set; }
        public string Postnom{ get; set; }
        public string Prenom{ get; set; }
        public string Sexe{ get; set; }
        public string Datenaissance{ get; set; }
        public string LieuNassance{ get; set; }       
        public string Numeronational{ get; set; }
        public string Telephone{ get; set; }
        public string Email{ get; set; }
        public string Username{ get; set; }
        public string Password{ get; set; }
    }

    public class clsAgent
    {
        public int Id { get; set; }
        public string Nom { get; set; }
        public string Postnom { get; set; }
        public string Prenom { get; set; }
        public string Sexe { get; set; }
        public string Datenaissance { get; set; }
        public string LieuNassance { get; set; }
        public string Numeronational { get; set; }
        public string Telephone { get; set; }
        public string Email { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
    }

    public class clsImage
    {
        public int Id { get; set; }
        public string Img { get; set; }
    }

    public class clsEngin
    {
        public int Id { get; set; }
        public string Marque { get; set; }
        public string Couleur { get; set; }
        public string Numerochaisi { get; set; }
        public string Numeromoteur { get; set; }
        public string Auteur { get; set; }

    }

    public class clsTypePersonne
    {
        public int Id { get; set; }
        public string Designation { get; set; }
    }
}
