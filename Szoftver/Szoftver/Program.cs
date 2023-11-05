using Szoftver;

static List<Szoftver1> KozelLegjobbak(List<Szoftver1> a)
{
	var f8 = a.Where(b => b.Ertekeles == a.Max(m => m.Ertekeles) - 0.1);
	var kozelLegjobbak = new List<Szoftver1>();
	foreach (var e in f8)
	{
		kozelLegjobbak.Add(e);
	}
	return kozelLegjobbak;
}

static double AtlagAdobeBrutto(List<Szoftver1> a)
{
	var f10 = a.Where(b => b.Nev.Contains("Adobe")).Average(c => c.BruttoAr);
	return f10;
}

static List<Szoftver1> DragaRosszak(List<Szoftver1> a)
{
	var f12 = a.Where(b => b.NettoAr > 500 && b.Ertekeles < 9);
	var dragaRosszak = new List<Szoftver1>();
	foreach (var item in f12)
	{
		dragaRosszak.Add(item);
	}
	return dragaRosszak;
}

static void kiiras(List<Szoftver1> a)
{
	var f13 = a.Where(b => b.Fizetos == "fizetős").Take(10);
	using var sw = new StreamWriter(@"..\..\..\src\kiiras.txt");
	foreach (var item in f13)
	{
		sw.WriteLine(item);
	}
}

var szoftverek = new List<Szoftver1>();
using var sr = new StreamReader(@"..\..\..\src\szoftverek.txt");
_ = sr.ReadLine();
while (!sr.EndOfStream) szoftverek.Add(new Szoftver1(sr.ReadLine()));

foreach (var s in szoftverek) Console.WriteLine(s);

Console.WriteLine("\n7.feladat: ");
var joAntivirus = new List<Szoftver1>();
foreach (var s in szoftverek)
{
	if (s.Ertekeles > 8.5 && s.Kategoria == "antivírus")
	{
		joAntivirus.Add(s);
	}
}
Console.WriteLine($"Ennyi 8,5-nél nagyobbra értékelt antivírus van: {joAntivirus.Count}");

Console.WriteLine("\n8.feladat: ");

var kozelLegjobbak = KozelLegjobbak(szoftverek);
foreach (var item in kozelLegjobbak)
{
    Console.WriteLine(item);
}

Console.WriteLine("\n10.feladat:");
var f10 = AtlagAdobeBrutto(szoftverek);
Console.WriteLine($"Adobe termékek átlag bruttó ára: {f10}");

Console.WriteLine("\n12.feladat: ");
var dragaRosszak = DragaRosszak(szoftverek);
if (dragaRosszak != null)
{
	foreach (var item in dragaRosszak)
	{
		Console.WriteLine($"{item.Azonosito}, ");
	}
}
else
{
    Console.WriteLine("Nincs ilyen");
}

kiiras(szoftverek);