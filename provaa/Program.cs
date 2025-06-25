

//Stack<int> pilha = new Stack<int>();
//pilha.Push(3);
//pilha.Push(5);
//Console.WriteLine(pilha.Peek());





//int[] v = { 1, 3, 5, 7, 9 };
//int ini = 0, fim = v.Length - 1;
//int meio;
//int alvo = 5;
//bool achou = false;

//while (ini <= fim)
//{
//    meio = (ini + fim) / 2;
//    if (v[meio] == alvo)
//    {
//        achou = true;
//        break;
//    }
//    else if (alvo < v[meio])
//    {
//        fim = meio - 1;
//    }
//    else
//    {
//        ini = meio + 1;
//    }
//}
//Console.WriteLine(achou ? "Encontrado" : "não encontrado");



//int[] numeros = new int[10];
//int pares = 0;

//for (int i = 0; i <10; i++)
//{
//    Console.WriteLine("Digite: ");
//    numeros[i] = int.Parse(Console.ReadLine());
//    if ()
//        pares++;
//}


//List<string> nomes = new List<string>();
//string nome;

//do
//{
//    Console.WriteLine("Digite um nome: ");
//    nome = Console.ReadLine();
//    if (nome = )
//        nomes.Add(nome);
//} while (nome != "fim");


//int[] v = { 2, 4, 6 };

//Console.WriteLine(v);


int[,] matriz = new int[2, 2];

for (int i = 0; i < 2; i++)
{
    for (int j = 0; j < 2; j++)
    {
        Console.Write($"Digite o número [{i},{j}]: ");
        matriz[i, j] = int.Parse(Console.ReadLine());
    }
}

Console.WriteLine("Matriz transposta:");
for (int i = 0; i < 2; i++)
{
    for (int j = 0; j < 2; j++)
    {
        Console.Write(matriz[j, i] + " ");
    }
    Console.WriteLine();
}
