using System;
using System.Collections.Generic;
using P_BlackJack_Uno.Clases;
namespace P_BlackJack_Uno.Interfaces;

public interface iCalculadorDePuntos
{
    int Calcular(List<CartaBase> mano);
}
