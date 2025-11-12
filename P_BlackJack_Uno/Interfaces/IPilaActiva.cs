using System;
using P_BlackJack_Uno.Clases;

namespace P_BlackJack_Uno.Interfaces;

public interface IPilaActiva
{
    CartaBase CartaSuperior { get; }
    List<CartaBase> PilaDescarte { get; }

    void DescartarCarta(CartaBase carta);
    void ReciclarDescarte();
}