using System;
using System.Security.Cryptography;

namespace ClubeDeLeitura.ConsoleApp.Dominio.Base;

public abstract class EntidadeBase
{
    public string Id { get; set; } = string.Empty;

    public EntidadeBase()
    {
        Id = Convert
                .ToHexString(RandomNumberGenerator.GetBytes(20))
                .ToLower()
                .Substring(0, 7);
    }

    // definição abstrata
    public abstract string[] Validar();
    public abstract void AtualizarRegistro(EntidadeBase entidadeAtualizada);
}
