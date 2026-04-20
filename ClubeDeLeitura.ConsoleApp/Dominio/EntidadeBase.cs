using System;
using System.Security.Cryptography;

namespace ClubeDeLeitura.ConsoleApp.Dominio;

// classe abstrata = não pode ser instânciada
// só vai **DEFINIR** comportamentos e propriedades dentro do sistema
public abstract class EntidadeBase
{
    public string Id {get; set;} = string.Empty;
    public EntidadeBase()
    {
                Id = Convert
                .ToHexString(RandomNumberGenerator.GetBytes(20))
                .ToLower()
                .Substring(0, 7);
    }
}
