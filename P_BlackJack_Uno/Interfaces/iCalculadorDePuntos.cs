using System;

namespace P_BlackJack_Uno.Interfaces;

public interface iCalculadorDePuntos
{
    int Calcular(List<CartaBase> mano);
}
