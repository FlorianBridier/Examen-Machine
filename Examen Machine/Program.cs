int a; int b;

//Saisi de l'entier de départ par l'utilisateur
Console.WriteLine("Saisir l'entier de départ de la suite de Syracuse :");
a= Convert.ToInt32(Console.ReadLine());

//Saisi de la taille de la suite 
Console.WriteLine("Saisir le nombre d'éléments de la suite :");
b= Convert.ToInt32(Console.ReadLine());


// Création du tableau 
int[] suite = new int[b];

// Calcul des éléments de la suite de Syracuse
suite[0] = a;

//Calcul de la suite de Syracuse
for (int i = 1; i < b; i++)
{ 
    if (suite[i-1] % 2 == 0)
    {
        suite[i] = suite[i-1] / 2;
    }
    else
    {
        suite[i] = suite[i-1] * 3 + 1;
    }
}

//Affichage du tableau résultat 
Console.WriteLine("Le tableau résultat contient :");
for (int i = 0; i < b; i++)
{
    Console.Write(suite[i] + " ");
}

