using ClubeDeLeitura.ConsoleApp.Dominio;

namespace ClubeDeLeitura.ConsoleApp.Apresentacao;

public class TelaCaixa
{
    public string? ObterOpcaoMenu()
    {
    Console.Clear();
    Console.WriteLine("---------------------------------");
    Console.WriteLine("Gestão de caixas");
    Console.WriteLine("---------------------------------");
    Console.WriteLine("1 - Cadastrar caixas");
    Console.WriteLine("2 - Editar caixa");
    Console.WriteLine("3 - Excluir caixa");
    Console.WriteLine("4 - Vizualizar caixas");
    Console.WriteLine("S - Voltar para menu principal");
    Console.WriteLine("---------------------------------");
    Console.Write("> ");
    string? opcaoMenu = Console.ReadLine().ToUpper();

    return opcaoMenu;
    }

    public void Cadastrar()
    {
        ExibirCabecalho("Cadastro de caixa");
    }

    public void Editar()
    {
        ExibirCabecalho("Edição de caixa");
    }

    public void Excluir()
    {
        ExibirCabecalho("Exclusão de caixa");
    }

    public void VizualizarTodos()
    {
        ExibirCabecalho("Vizualizar caixas");
    }
    
    public void ExibirCabecalho(string titulo)
    {
        Console.Clear();
        Console.WriteLine("---------------------------------");
        Console.WriteLine(titulo);
        Console.WriteLine("---------------------------------");
    }
}
