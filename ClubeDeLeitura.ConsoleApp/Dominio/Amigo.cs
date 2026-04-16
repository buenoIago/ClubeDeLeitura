using System;

namespace ClubeDeLeitura.ConsoleApp.Dominio;

/* 
    Campos obrigatórios:
    ○ Nome (mínimo 3 caracteres, máximo 100)
    ○ Nome do responsável (mínimo 3 caracteres, máximo 100)
    ○ Telefone (formato validado: 10-11 dígitos)
     Não pode haver amigos com o mesmo nome e telefone
*/

public class Amigo
{
    public string Nome {get; set;}
    public string NomeReponsavel {get; set;}
    public string Telefone {get; set;}
    public Amigo(string nome, string nomeReponsavel, string telefone)
    {
        Nome = nome;
        NomeReponsavel = nomeReponsavel;
        Telefone = telefone;
    }
}
