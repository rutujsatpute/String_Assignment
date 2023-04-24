Console.WriteLine("Enter the number of Words");
int i = Convert.ToInt32(Console.ReadLine());

string[] words = new string[i];
for (int j = 0; j < i; j++)
    {
    Console.WriteLine($"Enter Word (i+1):");
    words[j] = Console.ReadLine();

    }
string shortest = words[0];
foreach (string word in words)
    {
        if (word.Length < shortest.Length)
         {
        shortest = word;
         }
    }
Console.WriteLine($"The Shortest Word is {shortest}");

// To find Existing Word

/*Console.WriteLine("Enter the number of Words");
int i1 = Convert.ToInt32(Console.ReadLine());

string[] words1 = new string[i1];
for (int j = 0; j < i1; j++)
{
    Console.WriteLine($"Enter Word (i1+1):");
    words1[j] = Console.ReadLine();

}
*/
Console.WriteLine("Enter the Word to be Searched");
string W = Convert.ToString(Console.ReadLine());
bool found = false;
foreach (string word in words)
{
    if (word.Equals(W))
    {
        found = true;
        break;
    }
}
if (found)
{
    Console.WriteLine($"{W} is Present in the List");

}
else
{
    Console.WriteLine($"{W} is Not Present in the List");

}

// Arrange the Word Alphbetically
String Response;
Console.WriteLine("Arrange the List in Alphabetical order (Y/N)");
Response= Console.ReadLine();
if (Response == "Y") ;


/*Console.WriteLine("Enter the number of Words");
int i2 = Convert.ToInt32(Console.ReadLine());

string[] words2 = new string[i2];
for (int j = 0; j < i2; j++)
{
    Console.WriteLine($"Enter Word (i+1):");
    words2[j] = Console.ReadLine();

}*/
Array.Sort(words);
Console.WriteLine("List in Alphabetical Order");
foreach (string word in words)
{
    Console.WriteLine(word);

}


int count = 0;
foreach (string str6 in words)
{
    string rev = "";
    int length = str6.Length;



    for (int k = length - 1; k >= 0; k--)
    {
        rev += str6[k];

    }
    if (rev == str6)
    {
        count++;
    }
}
Console.WriteLine("The number of palindromes in the string is " + count);