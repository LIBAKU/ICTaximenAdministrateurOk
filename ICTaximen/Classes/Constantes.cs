using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICTaximen.Classes
{
    class Constantes
    {
      public static String[] PaysDBChamps = new String[]
      {
           "code",
           "designation"          
      };
        public static String[] AutreAdresseDBChamps = new String[]
      {
           "code",
           "designation",
           "reference"
      };
        public static String[] AdresseDBChamps = new String[]
     {
             "code",
             "numeromaison",
             "reference",
             "usersession"
     };
        
        public static String[] TaximenDBChamps = new String[]
     {
            "code","nom","postnom","prenom","sexe","numeronational","lieunaissance","datenaissance","telephone","email","image","qrCode","username","userpassword","usersession"
     };
        public static String[] ProprietaireDBChamps = new String[]
    {
            "code","nom","postnom","prenom","sexe","numeronational","lieunaissance","datenaissance","telephone","email","image","qrCode","username","userpassword","usersession"
    };
        public static String[] AgentDBChamps = new String[]
    {
            "code","nom","postnom","prenom","sexe","numeronational","lieunaissance","datenaissance","telephone","email","image","qrCode","username","userpassword","usersession"
    };

        public static String[] EnginDBChamps = new String[]
   {
           "code","marque","couleur","numerochasis","numeromoteur","qrcode","proprietaire","categorie","usersession"
   };
        
        public static String[] AffectationDBChamps = new String[]
   {
           "code",            
            "refengin",
            "reftaximan",
            "dateaffectation",
            "usersession"
   };

    }
}
