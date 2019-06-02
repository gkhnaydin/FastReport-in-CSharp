using System;
using System.Collections.Generic;

namespace FastReport_AltaltaVeriYazma
{
    internal class Kisi
    {
        public int No { get; set; }
        public char Ad { get; set; }
        public char Soyad { get; set; }
        public int TC { get; set; }


        public List<Kisi> getKisiList()
        {
            char[] Englishalphabet = new char[26];

            for (int i = 0; i < 26; i++)
            {
                Englishalphabet[i] = Convert.ToChar(i + 65);
            }


            var list = new List<Kisi>();

            for (int i = 0; i < 100; i++)
            {
                if (i < 26)
                {
                    list.Add(new Kisi
                    {
                        No = i,
                        TC = i * 11,
                        Ad = Englishalphabet[i],
                        Soyad = Englishalphabet[i]
                    });
                }
                else
                {
                    list.Add(new Kisi
                    {
                        No = i,
                        TC = i * 11,
                        Ad = Englishalphabet[i%26],
                        Soyad = Englishalphabet[i%26]
                    });
                }
            }
            return list;
        }
    }
}
