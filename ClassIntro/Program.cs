﻿// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Kurs kurs1 = new Kurs();
kurs1.KursAdi = "C#";
kurs1.Egitmen = "Engin";
kurs1.IzlenmeOrani = 68;

Kurs kurs2 = new Kurs();
kurs2.KursAdi = "java";
kurs2.Egitmen = "Engin2";
kurs2.IzlenmeOrani = 65;

Kurs kurs3 = new Kurs();
kurs3.KursAdi = "Python";
kurs3.Egitmen = "Muzo";
kurs3.IzlenmeOrani = 80;

Kurs[] kurslar = new Kurs[] {kurs1, kurs2, kurs3 };

foreach (var kurs in kurslar)
{
    Console.WriteLine(kurs.KursAdi + ":" + kurs.Egitmen + ":" + kurs.IzlenmeOrani);
}


class Kurs
{
    public string KursAdi { get; set; }
    public string Egitmen { get; set; }
    public int IzlenmeOrani { get; set; }

}
