string firstName = "carlos";
string lastName = "oliveira";

string note = lastName.ToUpper() + " " + firstName;

string initials = lastName[0] + " " + firstName[0];

// FORMATACAO DE STRING 
string texto = string.Format ("{0} {1} nascido em {2}", firstName, lastName, "2008");


Console.WriteLine(texto);

// C# é uma linguagem filha do C++
//Totalmente orientada a objetos
// pontanto, tudo dentro do C é descendente 
// do tipo Object

int age = 24;
object ageBoxing = age;
int ageUnboxing = (int) ageBoxing;