using System.Numerics;
using System.Globalization;


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

int [] number2 = new int[] { 100, 200, 300};

int [] number3 = new int[] { 1000, 2000, 3000, 4000};


//percorrendo um vetor e adicionando valores dinamicamente

Console.WriteLine("Iniciando com vetores");

Console.WriteLine("Informe o valor do vetor:");

int size = Convert.ToInt32(Console.ReadLine());

int[] myArray = new int[size];
int total = 0; //Acumulador
int counter = 0;

for(int i = 0; i < myArray.Length; i++) {
     Console.WriteLine( "Digite para [ " + i + "]: ");

     myArray[i] = Convert.ToInt32(Console.ReadLine());

     total += myArray[i];
     counter++;
}

Console.WriteLine("Totalizador = " + total);
Console.WriteLine("Contagem = " + counter);


// Aula 04

string[] months = new string[12];

for(int i = 1; i <= 12; i++){
    DateTime firstDay = new DateTime(DateTime.Now.Year, i, 1);

     DateTime lastDay = firstDay.AddMonths(1).AddDays(-1);

    string monthName = firstDay.ToString("MMM", System.Globalization.CultureInfo.InvariantCulture);

    months[i - 1] = monthName;
}

foreach (string monthName in months){
     Console.WriteLine($"---> {monthName}");
}