using System;
using ClubeDeLeitura.ConsoleApp.Dominio;
using ClubeDeLeitura.ConsoleApp.Infraestrutura;

namespace ClubeDeLeitura.ConsoleApp.Apresentacao;

/*
● O sistema deve permitir a inserção de novos amigos
● O sistema deve permitir a edição de amigos já cadastrados
● O sistema deve permitir excluir amigos já cadastrados
● O sistema deve permitir visualizar amigos cadastrados
*/
public class TelaAmigos
{
    private RepositorioAmigo repositorioAmigo;
    public TelaAmigos(RepositorioAmigo rA)
    {
        repositorioAmigo = rA;
    }
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
        ExibirCabecalho("Cadastro de amigos");

        Amigo novoAmigo = ObterDadosCadastrais();

        string[] erros = novoAmigo.Validar();

        if (erros.Length > 0)
        {
            Console.WriteLine("---------------------------------");

            Console.ForegroundColor = ConsoleColor.Red;

            for (int i = 0; i < erros.Length; i++)
            {
                string erro = erros[i];

                Console.WriteLine(erro);
            }

            Console.ResetColor();
            Console.WriteLine("---------------------------------");
            Console.Write("Digite ENTER para continuar...");
            Console.ReadLine();

            Cadastrar();
            return;
        }

        repositorioAmigo.Cadastrar(novoAmigo);

        ExibirMensagem($"O registro \"{novoAmigo.Id}\" foi cadastrado com sucesso!");
    }

    public void Editar()
    {
        
    }

    public void Excluir()
    {
        
    }

    public bool VisualizarTodos(bool deveExibirCabecalho)
    {
        return true;
    }

    private void ExibirCabecalho(string titulo)
    {
        Console.Clear();
        Console.WriteLine("---------------------------------");
        Console.WriteLine("Gestão de Caixas");
        Console.WriteLine("---------------------------------");
        Console.WriteLine(titulo);
        Console.WriteLine("---------------------------------");       
    }

    private void ExibirMensagem(string mensagem)
    {
        Console.WriteLine("---------------------------------");
        Console.WriteLine(mensagem);
        Console.WriteLine("---------------------------------");
        Console.Write("Digite ENTER para continuar...");
        Console.ReadLine();
    }

    private Amigo ObterDadosCadastrais()
    {
        Console.Write("Digite o nome do amigo: ");
        string? nome = Console.ReadLine();

        Console.Write("Digite o nome do responsável: ");
        string? nomeReponsavel = Console.ReadLine();

        Console.Write("Digite o telefone do amigo: ");
        string? telefone = Console.ReadLine();

        string idSelecionado = SelecionarCaixa();

        Amigo? amigoSelecionado = repositorioAmigo.SelecionarPorId(idSelecionado);
    
        return new Amigo(nome, nomeReponsavel, telefone, amigoSelecionado);
    }

    private string SelecionarCaixa()
    {
        throw new NotImplementedException();
    }
}
