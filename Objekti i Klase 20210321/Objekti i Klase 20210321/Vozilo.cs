using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objekti_i_Klase_20210321
{
    class Vozilo
    {
        bool JeLiLeti, JeLiPlovi;

        public bool JeLiLeti1 { get => JeLiLeti; set => JeLiLeti = value; }
        public bool JeLiPlovi1 { get => JeLiPlovi; set => JeLiPlovi = value; }

        public void KudaVozi()
        {
            Console.WriteLine("Leti = " + JeLiLeti + "Plovi = " + JeLiPlovi);
        }

        public Vozilo(bool jeLiLeti, bool jeLiPlovi)
        {
            JeLiLeti = jeLiLeti;
            JeLiPlovi = jeLiPlovi;
        }
    }
}
