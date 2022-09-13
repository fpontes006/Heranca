using Herenca;

string nome;
string especie;


Console.Write("Informe o Nome do Mamifero: ");
nome = Console.ReadLine();

Console.Write("Informe a especie do Mamifero: ");
especie = Console.ReadLine();

Mamifero mamifero = new Mamifero(nome, especie);

mamifero.Mamar();

Console.Write("Informe o Nome do réptil: ");
nome = Console.ReadLine();

Console.Write("Informe a especie do réptil: ");
especie = Console.ReadLine();

Console.Write("Informe se o réptil posui veneno: (Sim / Não): ");
string respostaVeneno = Console.ReadLine();

Reptil reptil = new Reptil(nome, especie);

if (respostaVeneno == "Sim")
{
    reptil.PossuiVeneno = true;
}
else
{
    reptil.PossuiVeneno = false;
}

reptil.BotarOvo();

