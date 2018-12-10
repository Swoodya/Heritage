using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_POO_Héritage
{
    class Felin : Mammifere
    {
        private int nombrePattes;

        public Felin(string nom, string LieuHabitation, int monCrie, bool jeSuisDomestique, int nombrePattes):base(nom, LieuHabitation, monCrie, jeSuisDomestique) 
        {
            this.nombrePattes = nombrePattes;
        }

        public void Afficher()
        {
            Console.WriteLine("je suis donc un mammifere avec {0} pattes", this.nombrePattes);
        }
    }
}
