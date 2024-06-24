using System;

class Program
{
    public static void Main(string[] args)
    {
        //Console.Write("premier chaine: ");
        List<string> listeChaines = new List<string>(3);
        listeChaines.Add(" uno ");
        listeChaines.Add(" dos ");
        listeChaines.Add(" tres ");
        foreach (string s in listeChaines) { Console.WriteLine(s); }
        Console.WriteLine("---------------------------------");
        listeChaines.RemoveAt(0);
        foreach (string s in listeChaines) { Console.WriteLine(s); }
        Console.WriteLine("---------------------------------");
        listeChaines.Remove(" tres ");
        foreach (string s in listeChaines) { Console.WriteLine(s); }
        Console.WriteLine("---------------------------------");
        listeChaines[0] = " nuevo uno ";
        foreach (string s in listeChaines) { Console.WriteLine(s); }
        Console.WriteLine("---------------------------------");

    }
}