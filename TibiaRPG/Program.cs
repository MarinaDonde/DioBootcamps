using static System.Console;
using TibiaRPG.src.Entities;

class Program
{
    static void Main(string[] args)
    {
        Knight kina = new Knight("NinaTheLegend", 42, 469, 749, "Knight");
        Paladin pally = new Paladin("Chuck", 42, 292, 574, "Pally");
        Druid wizard = new Druid("Yueev", 42, 325, 601, "Druid");
        Sorcerer magician = new Sorcerer("SirSparoo", 42, 106, 385, "Sorc");


        WriteLine(kina.ToString());
        WriteLine("");
        WriteLine(pally.ToString());
        WriteLine("");
        WriteLine(wizard.ToString());
        WriteLine("");
        WriteLine(magician.ToString());
        WriteLine("");
        WriteLine(kina.Attack(5));
        WriteLine(pally.Defense(9));
        WriteLine(pally.Attack(7));
        WriteLine(kina.Defense(5));
        WriteLine(wizard.Attack());
        WriteLine(magician.Defense());
        WriteLine(magician.Attack());
        WriteLine(wizard.Defense());

    }
}