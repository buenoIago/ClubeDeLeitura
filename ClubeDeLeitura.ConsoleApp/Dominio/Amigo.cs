using System;
using System.Security.Cryptography;

namespace ClubeDeLeitura.ConsoleApp.Dominio;



public class Amigo
{
    public string Id {get; set;}
    public string Nome {get; set;}
    public string NomeReponsavel {get; set;}
    public string Telefone {get; set;}
    public Amigo Amigos {get; set;}
    public Amigo(string nome, string nomeReponsavel, string telefone, Amigo amigo)
    {
         Id = Convert
                .ToHexString(RandomNumberGenerator.GetBytes(20))
                .ToLower()
                .Substring(0, 7);
                
        Nome = nome;
        NomeReponsavel = nomeReponsavel;
        Telefone = telefone;
        Amigos = amigo;
    }

/* 
    Campos obrigatórios:
    ○ Nome (mínimo 3 caracteres, máximo 100)
    ○ Nome do responsável (mínimo 3 caracteres, máximo 100)
    ○ Telefone (formato validado: 10-11 dígitos)
     Não pode haver amigos com o mesmo nome e telefone
*/

    public string[] Validar()
    {
        string erros = string.Empty;

        if (string.IsNullOrWhiteSpace(Nome))
            erros += "O campo \"Nome\" é obrigatório;";

        else if (Nome.Length < 3 || Nome.Length > 100)
            erros += "O campo \"Título\" deve conter entre 3 e 100 caracteres;";

        if (string.IsNullOrWhiteSpace(NomeReponsavel))
            erros += "O campo \"Nome do Responsável\" é obrigatório;";

        else if (NomeReponsavel.Length < 3 || NomeReponsavel.Length > 100)
            erros += "O campo \"Título\" deve conter entre 3 e 100 caracteres;";

        if (Telefone.Length < 10 || NomeReponsavel.Length > 11)
        erros += "O campo \"Telefone\" deve conter entre 10 e 11 números;";

        return erros.Split(';', StringSplitOptions.RemoveEmptyEntries);
    }
}
