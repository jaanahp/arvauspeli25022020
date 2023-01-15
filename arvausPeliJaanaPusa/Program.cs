using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arvausPeliJaanaPusa
{
    class Program
    {
        static void Main(string[] args)
        {
            //Tee ohjelma, jossa on random-toiminnallisuus, joka hakee luvun 1-100
            //Kun ohjelman käynnistää, se arvuuttaa käyttäjältä mikä luku on kyseessä
            //Mikäli käyttäjä arvaa liian suuren arvon, ohjelma sanoo "luku on pienempi kuin arvaus"
            //Mikäli käyttäjä arvaa liian pienen arvon, ohjelma sanoo "luku on suurempi kuin arvaus"
            //Arvaukset tallennetaan listalle
            //Lopuksi, kun arvaus osuu oikeaan, käyttäjää onnitellaan ja kerrotaan montako arvausta tarvittiin sekä
            //tulostetaan listalla olevat arvaukset
            //Mitä, jos painaa vaan Enter ja ohjelma kaatuu? Miten otetaan kiinni?

            List<int> arvausLista = new List<int>(); 
            string arvaus = "";
            int rLuku = 0, arvausLuku = 0, laskuri = 0;
            Random arpa = new Random();
            rLuku = arpa.Next(1, 100);
            Boolean lopeta = false;

            Console.WriteLine("Tervetuloa arvauspeliin!");

            while (lopeta != true) //jos boolean muuttuja lopeta EI OLE totta, pyöritetään silmukkaa
            {
                Console.Write("Arvaa, minkä luvun peli arpoi: ");
                arvaus = Console.ReadLine(); //käyttäjän arvaus tallennetaan string-muuttujaan arvaus
                try
                {
                arvausLuku = int.Parse(arvaus); //string-muuttuja arvaus muunnetaan integer-muuttuja arvausLuvuksi
                arvausLista.Add(arvausLuku); //lisätään arvausLista-listalle uusi alkio, jossa on esitetty arvaus int-muuttujana
                if (arvausLuku > rLuku) //jos arvaus on suurempi kuin arvottu random-luku
                {
                    Console.WriteLine("Luku on pienempi kuin arvauksesi");
                } else if (arvausLuku < rLuku) //jos arvausluku on pienempi kuin arvottu random-luku
                {
                    Console.WriteLine("Luku on suurempi kuin arvauksesi");
                } else //muussa tapauksessa eli jos arvausluku on sama kuin random-luku
                {
                    Console.WriteLine("Onneksi olkoon, arvauksesi osui oikeaan!");
                     for (int i = 0; i < arvausLista.Count; i++) //käydään läpi arvauslistan kaikki alkiot
                      {
                        Console.WriteLine("Arvaus numero " + (i + 1) + " oli: " + arvausLista[i]); //tulostetaan kaikki alkiot rivinumeroin
                        laskuri++; //lisätään joka tulostuskierroksella laskuri-muuttujan arvoon 1 (aluksi se on 0)
                      }
                    Console.WriteLine("Onnistuminen vaati {0} yritystä.", laskuri.ToString()); //kerrotaan, montako yritystä onnistuminen vaati
                    lopeta = true; //jos arvaus = randomluku, boolean lopeta asetetaan trueksi jolloin while-silmukka päättyy
                }

                }
                catch (Exception)
                {
                    Console.WriteLine("Ohjelma ei tunnistanut tietoa. Tarkista syöttämäsi luku.");
                }
            }

            Console.ReadLine();
        }
    }
}
