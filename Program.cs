    Console.WriteLine("Digite um nome: " );

string nome = Console.ReadLine();

Console.WriteLine(nome);

while (nome.Length >0)
{
    Console.WriteLine("Digite a letra a ser removida: " );
    string letra = Console.ReadLine();
    nome = nome.Replace(letra, "");
    Console.WriteLine(nome);
    Console.WriteLine(nome.Trim());
}