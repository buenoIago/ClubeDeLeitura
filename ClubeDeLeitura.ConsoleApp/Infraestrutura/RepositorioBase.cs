using System;
using ClubeDeLeitura.ConsoleApp.Dominio;

namespace ClubeDeLeitura.ConsoleApp.Infraestrutura;

public class RepositorioBase
{
    public bool Editar(string idSelecionado, EntidadeBase novoEntidade)
    {
        EntidadeBase? revistaSelecionada = SelecionarPorId(idSelecionado);

        if (revistaSelecionada == null)
            return false;

        revistaSelecionada.AtualizarRegistro(novoEntidade);

        return true;
    }
    public EntidadeBase? SelecionarPorId(string idSelecionado)
    {
        return null;
    }
}
