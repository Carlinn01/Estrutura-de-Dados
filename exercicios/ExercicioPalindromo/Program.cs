Console.WriteLine("Atividade Palindromo");

Console.Write("Digite uma palavra: ");
string entrada = (Console.ReadLine() ?? "");

int tamanho = entrada.Length;
char[] vetor = new char[tamanho];

for (int i = 0; i < tamanho; i++)
{
    vetor[i] = entrada[i];
}

int inicio = 0;
int fim = tamanho - 1;

for (int i = 0; i < tamanho; i++)
{
    if (vetor[inicio] != vetor[fim])
    {
        Console.WriteLine("A palavra não é um palíndromo.");
        return; //para o codigo para nao ficar repetindo o resultado
    }

    inicio++; 
    fim--;    
}

Console.WriteLine("A palavra é um palíndromo!");
