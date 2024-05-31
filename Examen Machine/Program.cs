static void Main()
{
    int a;  int b;

//Saisi de l'entier de départ par l'utilisateur
Console.WriteLine("Saisir l'entier de départ de la suite de Syracuse :");
a = Convert.ToInt32(Console.ReadLine());

//Saisi de la taille de la suite 
Console.WriteLine("Saisir le nombre d'éléments de la suite :");
b = Convert.ToInt32(Console.ReadLine());

//Appel du sous-programme qui va calculer les valeurs de la suite
int[] suite = CalculSuite(a, b);


    //Affichage du tableau résultat 
    Console.WriteLine("Le tableau résultat contient :");
for (int i = 0; i < b; i++)
{
    Console.Write(suite[i] + " ");
}
}


//Calcul de la suite de Syracuse
static int[] CalculSuite(int a, int b)
{
    int[] suite = new int[b];
    suite[0] = a;

    for (int i = 1; i < b; i++)
    {
        if (suite[i - 1] % 2 == 0)
        {
            suite[i] = suite[i - 1] / 2;
        }
        else
        {
            suite[i] = 3 * suite[i - 1] + 1;
        }
    }

    return suite;
}










