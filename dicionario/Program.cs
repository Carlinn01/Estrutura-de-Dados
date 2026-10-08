using System.Collections;
using System.Runtime.Intrinsics.Arm;

Hashtable phoneBook = new Hashtable (){
    { "Edson Arantes do Nascimento", "0000"},
    { "Ronaldo Nazáreo dos Santos", "1111" },
    { "Luiz Inácio Lula da Silva", "2222"}
};

//Adicionando em tempo de execucao
phoneBook["Acelino Popó de Freitas"] = "33333";

//Tratando possível erro de duplicidade de chave

try
{
 phoneBook.Add("Edson Arantes do Nascimento", "000000");
}
catch (System.ArgumentException ae) {
    Console.WriteLine("Chave ja existente. " + ae.Message);
}
catch (System.Exception ex)
{
       Console.WriteLine ("Erro imprevisto. " + ex.Message);
}

//Percorrendo valores TableHash
Console.WriteLine ("Caderninho de telefone:");
if(phoneBook.Count == 0)
{
    Console.WriteLine ("Agenda Vazia");
} else
{
    int i = 1;
    foreach (DictionaryEntry entry in phoneBook)
    {
        Console.WriteLine ($"{i}. {entry.Key} - {entry.Value}");
        i++; 
    }
}

//Busca em chave
Console.WriteLine ("");
Console.WriteLine ("Buscar por nome:");
string name = Console.ReadLine ();

if (phoneBook.Contains(name))
{
    string number = (String)phoneBook[name];
}
else
{
    Console.WriteLine ($"{name} não encontrado");
}

