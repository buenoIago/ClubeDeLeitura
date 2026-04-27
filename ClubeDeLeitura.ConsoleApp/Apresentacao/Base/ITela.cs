using System;

namespace ClubeDeLeitura.ConsoleApp.Apresentacao.Base;

public interface ITela // conceito totalmente abstrato
{
    string? ObterOpcaoMenu(); //toda classe que implementa essa interface precisa desse método
}
