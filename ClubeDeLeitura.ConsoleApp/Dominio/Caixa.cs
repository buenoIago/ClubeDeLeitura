using System.Dynamic;
using System.Security.Cryptography;
using ClubeDeLeitura.ConsoleApp.Apresentacao;

namespace ClubeDeLeitura.ConsoleApp.Dominio;



public class Caixa
{
    // public string etiqueta; // atributo
    public string Id {get; set;} = string.Empty; //propriedade
    public string Etiqueta {get; set;} = string.Empty; //propriedade
    public string Cor {get; set;} = string.Empty; //propriedade
    public int DiasDeEmprestimo {get; set;} = 7; //propriedade

    // construtor de classe
    // toda instância que for criada PRECISA dessas informações
    public Caixa(string etiqueta, string cor, int diasDeEmprestimo) 
    {
        Id = Convert
                .ToHexString(RandomNumberGenerator.GetBytes(20))
                .ToLower()
                .Substring(0, 7);

        Etiqueta = etiqueta;
        Cor = cor;
        DiasDeEmprestimo = diasDeEmprestimo;
    }
    public void AtualizarRegistro(Caixa caixaAtualizada)
    {
        Etiqueta = caixaAtualizada.Etiqueta;
        Cor = caixaAtualizada.Cor;
        DiasDeEmprestimo = caixaAtualizada.DiasDeEmprestimo;
    }
}
