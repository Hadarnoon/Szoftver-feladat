using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Szoftver
{
    internal class Szoftver1
    {
        public int Azonosito { get; set; }
        public string Nev { get; set; }
        public string Fizetos { get; set; }
        public string KompatibilisOP { get; set; }
        public string Kategoria { get; set; }
        public double Ertekeles { get; set; }
        public double NettoAr { get; set; }
        public double Adokulcs { get; set; }
        public double BruttoAr { get; set; }

        public Szoftver1(string sor)
        {
            var v = sor.Split('|');
            this.Azonosito = int.Parse(v[0]);
            this.Nev = v[1];
            this.Fizetos = v[2];
            this.KompatibilisOP = v[3];
            //var kompAtmeneti = v[3].Split(",");
            //foreach (var item in kompAtmeneti)
            //{
            //    this.KompatibilisOP.Add(item);
            //}
            this.Kategoria = v[4];
            this.Ertekeles = double.Parse(v[5]);
            this.NettoAr = double.Parse(v[6]);
            this.Adokulcs = double.Parse(v[7]);
            this.BruttoAr = this.NettoAr * (this.Adokulcs / 100);
        }

        public override string ToString()
        {
            return $"{Azonosito} | {Nev} | {Fizetos} | {KompatibilisOP} | {Kategoria} | {Ertekeles - 0.1} | {NettoAr} | {Adokulcs}";
        }
    }
}
