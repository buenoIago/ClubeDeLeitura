using ClubeDeLeitura.ConsoleApp.Dominio;

namespace ClubeDeLeitura.ConsoleApp.Infraestrutura;

public class RepositorioCaixa
{
    private Caixa?[] caixas = new Caixa[101];

    public void Cadastrar(Caixa novaCaixa)
    {
        for (int i = 0; i < caixas.Length; i++)
        {
            if (caixas[i] == null)
            {
                caixas[i] = novaCaixa;
                break;
            }
        }
    }
}
