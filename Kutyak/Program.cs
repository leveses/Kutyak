using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;

namespace Kutyak
{
    class MainClass
    {
        static List<KutyaNev> kutyaNevek = new List<KutyaNev>();
        static List<Kutyafajta> kutyaFajtak = new List<Kutyafajta>();
        static List<Kutya> kutyaLista = new List<Kutya>();
        static void BeolvasasKutya()
        {
            StreamReader be3 = new StreamReader("Kutyak.csv");

            be3.ReadLine();

            while (!be3.EndOfStream)
            {
                string[] adat3 = be3.ReadLine().Split(';');

                kutyaLista.Add(new Kutya(Convert.ToInt32(adat3[0]), Convert.ToInt32(adat3[1]), Convert.ToInt32(adat3[2]), Convert.ToInt32(adat3[3]),adat3[4]));
            }
            be3.Close();
        }
        static void BeolvasasFajtak()
        {
            StreamReader be2 = new StreamReader("KutyaFajtak.csv");

            be2.ReadLine();

            while (!be2.EndOfStream)
            {
                string[] adat2 = be2.ReadLine().Split(';');

                kutyaFajtak.Add(new Kutyafajta(Convert.ToInt32(adat2[0]),adat2[1],adat2[2]));
            }
            be2.Close();
        }
        static void BeolvasasNevek()
        {
            StreamReader be = new StreamReader("KutyaNevek.csv");

            be.ReadLine();

            while (!be.EndOfStream)
            {
                string[] adat = be.ReadLine().Split(';');

                kutyaNevek.Add(new KutyaNev(
                  Convert.ToInt32(adat[0]),
                  adat[1]
                ));
            }

            be.Close();
        }
        static void Szama()
        {
            Console.WriteLine("Kutya nevek száma: {0}",kutyaNevek.Count());
        }

        public static void Main(string[] args)
        {

            BeolvasasNevek();
            Szama();
            BeolvasasFajtak();
            BeolvasasKutya();


            Console.ReadKey();
        }
    }
}
