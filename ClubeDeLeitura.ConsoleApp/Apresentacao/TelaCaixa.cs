using System.Diagnostics.Contracts;
using System.Net.Http.Headers;
using ClubeDeLeitura.ConsoleApp.Dominio;
using ClubeDeLeitura.ConsoleApp.Infraestrutura;

namespace ClubeDeLeitura.ConsoleApp.Apresentacao;

public class TelaCaixa
{
    private RepositorioCaixa repositorioCaixa;

    public TelaCaixa (RepositorioCaixa rC)
    {
        repositorioCaixa = rC;
    }
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
    string? opcaoMenu = Console.ReadLine()?.ToUpper();

    return opcaoMenu;
    }

    public void Cadastrar()
    {
        ExibirCabecalho("Cadastro de caixa");

        Caixa novaCaixa = ObterDadosCadastrais();

        repositorioCaixa.Cadastrar(novaCaixa);

        Mensagem($"O registro \"{novaCaixa.Id}\" foi cadastrado com sucesso!");
    }

    public void Editar()
    {
        ExibirCabecalho("Edição de caixa");

        // Seleção da caixa que quero editar
        VizualizarTodos(deveExibirCabecalho: false);

        Console.WriteLine("---------------------------------");

        string? idSelecionado;

        do
        {
            Console.Write("Informe o ID do registro que deseja editar: ");
            idSelecionado = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(idSelecionado) && idSelecionado.Length == 7)
                break;
        } while (true);

        Console.WriteLine("---------------------------------");

        // Passagem de informações 
        Caixa novaCaixa = ObterDadosCadastrais();

        bool ConseguiuEditar = repositorioCaixa.Editar(idSelecionado, novaCaixa);

        if (!ConseguiuEditar)
        {
            Console.WriteLine("---------------------------------");
            Console.WriteLine("Não foi possível encontrar o registro requisitado.");
            Console.WriteLine("---------------------------------");
            Console.WriteLine("Digite ENTER para continuar...");
            Console.ReadLine();
        }

        Mensagem($"O registro \"{idSelecionado}\" foi editado com sucesso!");

    }

    public void Excluir()
    {
        ExibirCabecalho("Exclusão de caixa");

        VizualizarTodos(deveExibirCabecalho: false);

        Console.WriteLine("---------------------------------");

        string? idSelecionado;

        do
        {
            Console.Write("Informe o ID do registro que deseja editar: ");
            idSelecionado = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(idSelecionado) && idSelecionado.Length == 7)
                break;
        } while (true);

        Console.WriteLine("---------------------------------");

        bool ConseguiuEditar = repositorioCaixa.Excluir(idSelecionado);

        if (!ConseguiuEditar)
        {
            Console.WriteLine("---------------------------------");
            Console.WriteLine("Não foi possível encontrar o registro requisitado.");
            Console.WriteLine("---------------------------------");
            Console.WriteLine("Digite ENTER para continuar...");
            Console.ReadLine();
        }

        Mensagem($"O registro \"{idSelecionado}\" foi excluído com sucesso!");
    }

    public void VizualizarTodos(bool deveExibirCabecalho)
    {
        if(deveExibirCabecalho)
            ExibirCabecalho("Vizualizar caixas");

        Console.WriteLine(
            "{0, -7} | {1, -20} | {2, -10} | {3, -20}",
            "Id", "Etiqueta", "Cor", "Tempo de Empréstimo"
        );

        Caixa?[] caixas = repositorioCaixa.SelecionarTodas();

        for (int i = 0; i <  caixas.Length; i++)
        {
            Caixa? c = caixas[i];

            if (c == null)
                continue;

            Console.WriteLine(
                "{0, -7} | {1, -20} | {2, -10} | {3, -20}",
                c.Id, c.Etiqueta, c.Cor, c.DiasDeEmprestimo
            );
        }

        Console.WriteLine("---------------------------------");

        if(deveExibirCabecalho)
        {
            Console.WriteLine("---------------------------------");
            Console.WriteLine("Digite ENTER para continuar...");
            Console.ReadLine();
        }
    }
    
    public void ExibirCabecalho(string titulo)
    {
        Console.Clear();
        Console.WriteLine("---------------------------------");
        Console.WriteLine(titulo);
        Console.WriteLine("---------------------------------");
    }

    public void Mensagem(string mensagem)
    {
        Console.WriteLine("---------------------------------");
        Console.WriteLine(mensagem);
        Console.WriteLine("---------------------------------");
        Console.WriteLine("Digite ENTER para continuar...");
        Console.ReadLine();
    }

    private Caixa ObterDadosCadastrais()
    {
        Console.Write("Informe a etiqueta da caixa: ");
        string? etiqueta = Console.ReadLine();

        Console.WriteLine("---------------------------------");
        Console.WriteLine("Selecione uma das cores válidas");
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("1 - Vermelho");
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("2 - Verde");
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("3 - Azul");
        Console.ResetColor();
        Console.WriteLine("4 - Branco (Padrão)");

        Console.Write("Informe a cor da caixa: ");
        string? codigoCor = Console.ReadLine();

        string cor;

        if(codigoCor == "1")
            cor = "Vermelho";

        else if(codigoCor == "2")
            cor = "Verde";
        
        else if(codigoCor == "3")
            cor = "Azul";

        else
            cor = "Branco";

        Console.Write("Informe o tempo de empréstimo da caixa: ");
        int diasDeEmprestimo = Convert.ToInt32(Console.ReadLine());

        // Caixa novaCaixa = new Caixa();
        // novaCaixa.Etiqueta = etiqueta;
        // novaCaixa.Cor = cor;
        // novaCaixa.DiasDeEmprestimo = DiasDeEmprestimo;

        // regra para criação de caixas
        Caixa novaCaixa = new Caixa(etiqueta, cor, diasDeEmprestimo);

        return novaCaixa;
    }
}