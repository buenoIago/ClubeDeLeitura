using System;
using System.Reflection;
using ClubeDeLeitura.ConsoleApp.Dominio;

namespace ClubeDeLeitura.ConsoleApp.Infraestrutura;

public class RepositorioAmigo
{
    private Amigo?[] amigos = new Amigo[100];

    public Amigo? SelecionarPorId(string idSelecionado)
    {
        Amigo? amigoSelecionado = null;

        for (int i = 0; i < amigos.Length; i++)
        {
            Amigo? a = amigos[i];

            if (a == null)
                continue;

            if (a.Id == idSelecionado)
            {
                amigoSelecionado = a;
                break;
            }
        }

        return amigoSelecionado;
    }

    public void Cadastrar(Amigo novoAmigo)
    {
        for (int i = 0; i < amigos.Length; i++)
        {
            if (amigos[i] == null)
            {
                amigos[i] = novoAmigo;
                break;
            }
        }
    }
}

