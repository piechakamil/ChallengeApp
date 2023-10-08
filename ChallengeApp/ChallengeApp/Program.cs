
// ile jakich cyfr występuje w podanej liczbie
//

int numberToCheck = 4566;
string numberInString = numberToCheck.ToString();
char[] letters = numberInString.ToArray();
int[] letterCounters = new int[10];
char[] numbers = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };

Console.WriteLine("Sprawdzana liczba: " + numberToCheck);

// declare 0 to 9 

foreach (char letter in letters)
{
    for (int i = 0; i < letterCounters.Length; i++)
    {
        if (letter == numbers[i])
        {
            letterCounters[i]++;
        }
    }
}

for(int i=0; i< letterCounters.Length; i++)
{

    Console.WriteLine(numbers[i] + " => " + letterCounters[i]);
}

