using System;

namespace ClubeDeLeitura.ConsoleApp.Apresentacao;

/*
● O sistema deve permitir a inserção de novos amigos
● O sistema deve permitir a edição de amigos já cadastrados
● O sistema deve permitir excluir amigos já cadastrados
● O sistema deve permitir visualizar amigos cadastrados
*/
public class TelaAmigos
{
    public string ObterOpcaoMenu()
    {
        Console.Clear();
        Console.WriteLine("---------------------------------");
        Console.WriteLine("Gestão de caixas");
        Console.WriteLine("---------------------------------");
        Console.WriteLine("1 - Cadastrar amigo");
        Console.WriteLine("2 - Editar amigo");
        Console.WriteLine("3 - Excluir amigo");
        Console.WriteLine("4 - Vizualizar amigos");
        Console.WriteLine("S - Voltar para menu principal");
        Console.WriteLine("---------------------------------");
        Console.Write("> ");
        string? opcaoMenu = Console.ReadLine()?.ToUpper();

        return opcaoMenu;
    }

    public void Cadastrar()
    {
        throw new NotImplementedException();
    }

    public void Editar()
    {
        throw new NotImplementedException();
    }

    public void Excluir()
    {
        throw new NotImplementedException();
    }

    public bool VisualizarTodos(bool deveExibirCabecalho)
    {
        throw new NotImplementedException();
    }
}
