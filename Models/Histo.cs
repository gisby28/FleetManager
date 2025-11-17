using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace FleetManager.Models
{
    internal class Histo
    {
        public int HistoId { get; set; }
        public decimal Carburant { get; set; }
        public int Distance { get; set; }
        public string Immatriculation { get; set; }
    }
}
