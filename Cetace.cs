using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_POO_Héritage
{
    class Cetace : Mammifere
    {
        private int DuréeApnée;
        private int ProfondeurPlongée;

        public Cetace(string nom, string LieuHabitation, int monCrie, bool jeSuisDomestique, int DuréeApnée, int ProfondeurPlongée):base(nom, LieuHabitation, monCrie, jeSuisDomestique)
        {
            this.DuréeApnée = DuréeApnée;
            this.ProfondeurPlongée = ProfondeurPlongée;
        }

        public void Afficher()
        {
            Console.WriteLine("Je suis un mammifere qui est capable de tenir en apnée pendant {0} et qui peut plonger jusqu'a {1}", this.DuréeApnée, this.ProfondeurPlongée);
        }
    }
}
