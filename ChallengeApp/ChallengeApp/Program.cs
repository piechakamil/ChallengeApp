// data
string name = "Ewa";
char gender = 'w';  // w - woman, m - man
int age = 12;

// temp var
string genderTranslated = "";

// decode gender
if (gender == 'w')
{
    genderTranslated = "Kobieta";
} 
else if (gender == 'm')
{
    genderTranslated = "Mężczyzna";
}

// core
if (gender == 'w' && age < 30)
{
    Console.WriteLine($"{genderTranslated} poniżej 30 lat");
}
else if (age < 18 && gender == 'm')
{
    Console.WriteLine($"Niepełnoletni {genderTranslated}");
}
else if (name == "Ewa" && age >= 30 && gender == 'w')
{
    Console.WriteLine($"{name}, lat {age}");
}
else
{
    Console.WriteLine("Takiej osoby nie przewidziano");
}

Console.ReadKey();