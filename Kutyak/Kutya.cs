using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kutyak
{
    class Kutya
    {
        private int id;
        private int fajtaid;
        private int nevid;
        private int eletkor;
        private string vizsgalat;

        public Kutya(int id, int fajtaid, int nevid, int eletkor, string vizsgalat)
        {
            this.id = id;
            this.fajtaid = fajtaid;
            this.nevid = nevid;
            this.eletkor = eletkor;
            this.vizsgalat = vizsgalat;
        }
    }
}
