
// ile jakich cyfr występuje w podanej liczbie
//

int numberToCheck = 4566;
string numberInString = numberToCheck.ToString();
char[] letters = numberInString.ToArray();

// declare 0 to 9 

for(int i=0; i<10; i++)
{

    Console.WriteLine($"{i} => {i}");
}

char a = '1';
int b = 1;
