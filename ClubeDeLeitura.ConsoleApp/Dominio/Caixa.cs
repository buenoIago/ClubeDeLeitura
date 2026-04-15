using System.Dynamic;

namespace ClubeDeLeitura.ConsoleApp.Dominio;



public class Caixa
{
    // public string etiqueta; // atributo
    public string Etiqueta {get; set;} = string.Empty; //propriedade
    public string Cor {get; set;} = string.Empty; //propriedade
    public int DiasDeEmprestimo {get; set;} = 7; //propriedade
}
