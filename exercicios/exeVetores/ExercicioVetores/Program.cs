//Crie um programa que seja capaz de ler 10 numeros inteiros e separa los em dois vetores, um para os ímpares e outro para os pares
//
//Ao final imprima na tela os pares e depois os ímpares

Console.WriteLine("Atividade Vetores");


int[] numeros = new int[10];
int[] impares = new int[10];
int[] pares = new int[10];

int qtdPares = 0;
int qtdImpares = 0;

for(int i = 0; i < 10; i++) {
     Console.WriteLine( "Digite um numero para [ " + i + "/10]: ");

     numeros[i] = Convert.ToInt32(Console.ReadLine());

    //par
     if (numeros[i] % 2 == 0) {
     pares[i] = numeros[i];
     qtdPares++;
    }
    //impar
    else{
        impares[i] = numeros[i];
        qtdImpares++;
    }
    
    }

// par
Console.WriteLine("Números Pares ");
for (int i = 0; i < qtdPares; i++) 
{
    Console.WriteLine(pares[i]);
}

// impares
Console.WriteLine("Números Ímpares");
for (int i = 0; i < qtdImpares; i++) 
{
    Console.WriteLine(impares[i]);
}


