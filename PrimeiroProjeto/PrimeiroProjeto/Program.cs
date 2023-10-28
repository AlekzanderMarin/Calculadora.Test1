using System;
using System.Globalization;
using System.Runtime.InteropServices.Marshalling;

class SpiderMan
{
    public string RealName { get; set; }
    public string RomanticInterest { get; set; }
    public string Profession { get; set; }
    public int Age { get; set; }
    public string[] Powers { get; set; }
    public SpiderMan(string realName, string romanticInterest, string profession, int age, string[] powers)
    {
        RealName = realName;
        RomanticInterest = romanticInterest;
        Profession = profession;
        Age = age;
        Powers = powers;
    }

    public void DisplayInfo()
    {
        Console.WriteLine("Ficha Tecnica do Homem-Aranha:");
        Console.WriteLine($"Nome Real: {RealName}");
        Console.WriteLine($"Namorada: {RomanticInterest}");
        Console.WriteLine($"Profissão: {Profession} ");
        Console.WriteLine($"Idade: {Age}");
        Console.WriteLine("Poderes:");
            foreach (var power in Powers)
            {
                Console.WriteLine($"{power}");
            }


    }

}
class Program
{
    static void Main()
    {
        string[] spiderManPowers = {"   Agilidade sobre-humana","   Sentido aranha","   Habilidades acrobaticas","   Lança-teia","   Escalar paredes","   Força sobre-humana"};

        SpiderMan spiderMan = new SpiderMan("Peter Parker", "Felícia Hardy", "Fotógrafo", 25, spiderManPowers);

        spiderMan.DisplayInfo();
            

    }
}