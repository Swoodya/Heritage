using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_POO_Héritage
{
    class Baleine : Cetace
    {
        protected int dureeApnee;
        protected int profondeurPlongee;

        public Cetace(string nom, string lieuHabitation, string monCrie, bool jeSuisDomestique, int dureeApnee, int profondeurPlongee)
            : base(nom, lieuHabitation, monCrie, jeSuisDomestique)
        {
            this.dureeApnee = dureeApnee;
            this.profondeurPlongee = profondeurPlongee;
        }
    }
}
