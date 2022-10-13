// See https://aka.ms/new-console-template for more information


using System.IO;

Menu();

static void Menu()
{
    Console.Clear();
    Console.WriteLine("O que você deseja fazer ?");
    Console.WriteLine("1 = Abrir arquivos");
    Console.WriteLine("2 = Editar arquivos");
    Console.WriteLine("0 = Sair");
    Console.WriteLine("");

    int opiton = int.Parse(Console.ReadLine()); 

    switch(opiton)
    {
        case 0: System.Environment.Exit(0); break;
        case 1: Abrir();break;
        case 2: Editar();break; 
        default:Menu();break;
    }

}



static void Abrir()
{
    Console.Clear();
    Console.WriteLine("Qual o caminho do arquivo!");
    string caminho = Console.ReadLine();

    using (var arquivo = new StreamReader(caminho))
    {
        string text = arquivo.ReadToEnd();
        Console.WriteLine(text);
    }
    Console.WriteLine("");
    Console.ReadLine();
    Menu();
}



static void Editar()
{
    Console.Clear();
    Console.WriteLine("Digite seu texto:  (Digite ESC para Sair)");
    Console.WriteLine("-----------------   ---------------------");
    string text = "";

    do
    {
        text += Console.ReadLine();
        text += Environment.NewLine;
    }
        while (Console.ReadKey().Key != ConsoleKey.Escape);
    
    Salvar(text);
}



static void Salvar(String Text)
{
    Console.Clear();
    Console.WriteLine("Qual o caminho para Salvar o arquivo de texto?");
    var caminho = Console.ReadLine();

    using (var arquivo = new StreamWriter(caminho))
    {
        arquivo.Write(Text);
    }
    Console.WriteLine($"O arquivo {caminho} foi salvo com sucesso!");
    Console.ReadLine();
    Menu();
}