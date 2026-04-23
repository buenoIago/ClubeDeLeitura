using ClubeDeLeitura.ConsoleApp.Apresentacao;
using ClubeDeLeitura.ConsoleApp.Apresentacao.Base;
using ClubeDeLeitura.ConsoleApp.Dominio;
using ClubeDeLeitura.ConsoleApp.Infraestrutura;

RepositorioCaixa repositorioCaixa = new RepositorioCaixa();
RepositorioRevista repositorioRevista = new RepositorioRevista();
RepositorioAmigo repositorioAmigo = new RepositorioAmigo();
RepositorioEmprestimo repositorioEmprestimo = new RepositorioEmprestimo();

TelaCaixa telaCaixa = new TelaCaixa(repositorioCaixa);
TelaRevista telaRevista = new TelaRevista(repositorioRevista, repositorioCaixa);
TelaAmigo telaAmigo = new TelaAmigo(repositorioAmigo);
TelaEmprestimo telaEmprestimo = new TelaEmprestimo(repositorioEmprestimo, repositorioRevista, repositorioAmigo);

TelaPrincipal telaPrincipal = new TelaPrincipal(
    repositorioCaixa, 
    repositorioRevista, 
    repositorioAmigo, 
    repositorioEmprestimo
);

while (true)
{
    TelaBase? telaSelecionada = telaPrincipal.ApresentarMenuDeOpcoesPrincipal();

    if (telaSelecionada == null)
    {
        Console.Clear();
        break;
    }

    TelaBase telaBase = telaCaixa;

    while (true)
    {

            string? opcaoMenuInterno = telaSelecionada.ObterOpcaoMenu();

            if (opcaoMenuInterno == "S")
            {
                Console.Clear();
                break;
            }

            if (opcaoMenuInterno == "1")
                telaCaixa.Cadastrar();

            else if (opcaoMenuInterno == "2")
                telaCaixa.Editar();

            else if (opcaoMenuInterno == "3")
                telaCaixa.Excluir();

            else if (opcaoMenuInterno == "4")
                telaCaixa.VisualizarTodos(deveExibirCabecalho: true);

        // else if (opcaoMenuPrincipal == "4")
        // {
        //     opcaoMenuInterno = telaEmprestimo.ObterOpcaoMenu();

        //     if (opcaoMenuInterno == "S")
        //     {
        //         Console.Clear();
        //         break;
        //     }

        //     if (opcaoMenuInterno == "1")
        //         telaEmprestimo.Abrir();

        //     // else if (opcaoMenuInterno == "2")
        //     //     telaEmprestimo.();

        //     else if (opcaoMenuInterno == "3")
        //         telaEmprestimo.VisualizarTodos(deveExibirCabecalho: true);

        // }
    }
}