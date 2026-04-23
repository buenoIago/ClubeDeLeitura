using System;
using ClubeDeLeitura.ConsoleApp.Apresentacao.Base;
using ClubeDeLeitura.ConsoleApp.Infraestrutura;

namespace ClubeDeLeitura.ConsoleApp.Apresentacao;

public class TelaPrincipal
{
    private RepositorioCaixa repositorioCaixa;
    private RepositorioRevista repositorioRevista;  
    private RepositorioAmigo repositorioAmigo;
    private RepositorioEmprestimo repositorioEmprestimo;

    public TelaPrincipal(
        RepositorioCaixa repositorioCaixa, 
        RepositorioRevista repositorioRevista, 
        RepositorioAmigo repositorioAmigo, 
        RepositorioEmprestimo repositorioEmprestimo
    )

    {
        this.repositorioCaixa = repositorioCaixa;
        this.repositorioRevista = repositorioRevista;
        this.repositorioAmigo = repositorioAmigo;
        this.repositorioEmprestimo = repositorioEmprestimo;

        //criação de dados teste
        // caixa caixa = new Caixa("Lançamentos", "Vermelho", 3);
        // repositorioCaixa.Cadastrar(caixa);

        // Revista revista = new Revista("Action Comics", 155, 1990, caixa);
        // repositorioRevista.Cadastrar(revista);

        // Amigo amigo = new Amigo("Marco", "Pedro Souza", "48 99991-8888");
        // repositorioAmigo.Cadastrar(amigo);

        // Emprestimo emprestimo = new Emprestimo(revista, amigo);
        // emprestimo.Abrir();
        // repositorioEmprestimo.Cadastrar(emprestimo);
    }

    public TelaBase? ApresentarMenuDeOpcoesPrincipal()
    {
        Console.Clear();
        Console.WriteLine("---------------------------------");
        Console.WriteLine("Clube da Leitura");
        Console.WriteLine("---------------------------------");
        Console.WriteLine("1 - Gerenciar caixas de revistas");
        Console.WriteLine("2 - Gerenciar revistas");
        Console.WriteLine("3 - Gerenciar amigos");
        Console.WriteLine("4 - Gerenciar empréstimos");
        Console.WriteLine("S - Sair");
        Console.WriteLine("---------------------------------");
        Console.Write("> ");
        string? opcaoMenuPrincipal = Console.ReadLine()?.ToUpper();

        if (opcaoMenuPrincipal == "1")
            return new TelaCaixa(repositorioCaixa);

        if (opcaoMenuPrincipal == "2")
            return new TelaRevista(repositorioRevista, repositorioCaixa);

        if (opcaoMenuPrincipal == "3")
            return new TelaAmigo(repositorioAmigo);

        return null;
    }
}
