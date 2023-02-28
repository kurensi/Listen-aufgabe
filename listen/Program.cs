/*List<string> liste = new List<string>();
liste.Add("Batman");
liste.Add("Ironman");
liste.Add("Spiderman");
liste.Add("Capitain America");

liste.Sort();
foreach(var x in liste)
{
    Console.WriteLine(x);
}
Console.WriteLine($"Die Liste beinhät {liste.Count} Wörter");*/
List<string> liste = new List<string>();
int k =1;
while (true)
{


    try
    {
        Console.Write($"\nWollen sie abbrechen j/J n/N:   ");
        string str = Console.ReadLine();
        if (str == "j" || str == "J")
        {

            break;
        }
        else if (str == "N" || str == "n")
        {
            while (true)
            {
                Console.Write($"Geben sie den Namen ein: ");
                string name = Console.ReadLine();
                liste.Add($"{name}");
                Console.Clear();
                break;
            }
        }
        else
        {
            Console.WriteLine("Falsche eingabe");
        }
    }

    catch (Exception ex)
    {
        Console.WriteLine(ex.Message);
    }
}
Console.WriteLine($"\nListe der schüler");
foreach (var x in liste)
{

    Console.WriteLine($"{k++}ter name : {x}");

}
Console.Write($"\nWelchen Schüler wollen sie entfernen?? : ");
string wahl = Console.ReadLine();
for(int i =0; i< liste.Count; i++)
{
    if (liste[i].Equals(wahl))
    {
        liste.RemoveAt(i);
        Console.WriteLine($"{wahl} ist gelöscht");
        break;
    }
    else if (i == liste.Count - 1)
    {
        Console.WriteLine("Der Schüler befindet sich nich in der Liste");
        break;
    }
}

k = 1;
foreach (var x in liste)
{

    Console.WriteLine($"{k++}ter name : {x}");

}
Console.WriteLine($"\nCiao Amigo");
Console.ReadKey();