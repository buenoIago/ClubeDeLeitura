using System;
using System.Security.Cryptography;
using ClubeDeLeitura.ConsoleApp.Dominio.Base;

namespace ClubeDeLeitura.ConsoleApp.Dominio;

public class Emprestimo 
{
    public string Id {get; set;} = string.Empty;
    public Revista Revista {get; set;}
    public Amigo Amigo {get; set;}
    public DateTime Abertura {get; set;} // 01/01/0001 00:00:00
    public DateTime ConclusaoPrevista {get; set;}
    public StatusEmprestimo Status {get; set;} = StatusEmprestimo.Indefinido;

    public Emprestimo(Revista revista, Amigo amigo)
    {
        Id = Convert
                .ToHexString(RandomNumberGenerator.GetBytes(20))
                .ToLower()
                .Substring(0, 7);   

        Revista = revista;    
        Amigo = amigo;
    }

    public string[] Validar()
    {
        string erros = string.Empty;

        if (Revista == null)
            erros += "O campo \"Revista\" é obrigatório";
        
        if (Amigo == null)
            erros += "O campo \"Amigo\" é obrigatório";

        return erros.Split(';', StringSplitOptions.RemoveEmptyEntries);
    }
}
