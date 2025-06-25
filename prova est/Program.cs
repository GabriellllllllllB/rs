//int[] numeros = { 5, 1, 9, 4, 6 };
//Array.Sort(numeros);
//foreach (int num in numeros)
//    Console.WriteLine(num);



//int[] numeros = new int[10];
//int pares = 0;

//for(int i= 0; i <10; i++)
//{
//    Console.WriteLine("Digite: ");
//    numeros[i]= int.Parse(Console.ReadLine());
//    if (numeros[i] % 2 == 0)     
// pares++;
//}
//Console.WriteLine($"Pares: {pares}");



//List<string> nomes = new List<string>();
//string nome;

//do
//{
//    Console.WriteLine("Digite um nome: ");
//    nome = Console.ReadLine();
//    if (string.IsNullOrWhiteSpace(nome))
//        nomes.Add(nome);
//} while (nome != "fim");





    Stack<string> pilha = new Stack<string>();
Stack<string> frente = new Stack<string>();

pilha.Push("Página 1");

while (true)
{
    Console.WriteLine($"Página atual: {pilha.Peek()}");
    Console.WriteLine("Escolha uma opção:");
    Console.WriteLine("1- Avançar");
    Console.WriteLine("2- Voltar");
    int opc = int.Parse(Console.ReadLine());

    if (opc == 1)
    {    Console.Write("Digite o nome da nova página: ");
            string novaPagina = Console.ReadLine();
            pilha.Push(novaPagina);
            frente.Clear();
        
    }
    else if (opc == 2)
    {
        if (pilha.Count > 1)
        {
            frente.Push(pilha.Pop());
        }
        else
        {
            Console.WriteLine("Você está na primeira página. Não é possível voltar.");
        }
    }
}
