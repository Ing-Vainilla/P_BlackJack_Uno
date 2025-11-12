using System;
using System.Collections.Generic;
using P_BlackJack_Uno.Clases;
namespace P_BlackJack_Uno.Interfaces;

public interface IJugador
{
    string Nombre { get; }
    List<CartaBase> Mano { get; }

    void RecibirCarta(CartaBase carta);
    void DescartarCarta(CartaBase carta);
}
