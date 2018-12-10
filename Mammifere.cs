using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_POO_Héritage
{
    class Mammifere
    {
        private string nom;
        private string LieuHabitation;
        private int monCrie;
        private bool jeSuisDomestique;

        public Mammifere(string nom, string LieuHabitation, int monCrie, bool jeSuisDomestique)
        {
            this.nom = nom;
            this.LieuHabitation = LieuHabitation;
            this.monCrie = monCrie;
            this.jeSuisDomestique = jeSuisDomestique;
        }

        public void Afficher()
        {
            Console.WriteLine("Mon nom est {0}, j'habite dans {1}, mon crie est le {2} et je suis un animal {3}", this.nom, this.LieuHabitation, this.monCrie, this.jeSuisDomestique);
        }

        public void JeSuisDangereux()
        {

        }
    }
}
