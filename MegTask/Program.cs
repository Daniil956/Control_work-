Console.Clear();

string[] EnterArrey(string message)
{
    System.Console.Write(message);
    string[] numberN = Console.ReadLine().Split(" ");
    return numberN;
}

string[] massiv = EnterArrey("Enter world of space: ");
int count = 0;

for (int i = 0; i < massiv.Length; i++)
{
    if (massiv[i].Length <= 3) count++ ;
}

string[] array = new string [count];
int index =0;

for(int i = 0; i< massiv.Length; i++)
{
    if(massiv[i].Length <= 3) 
    {
        array[index] = massiv[i]; 
        index++;
    }   
}
 System.Console.WriteLine(string.Join(", " , array) + " ");