using System;
using P_BlackJack_Uno.Clases;
namespace P_BlackJack_Uno.Interfaces;

public interface IBaraja
{
    List<CartaBase> Cartas { get; }
    void Barajar();
    CartaBase TomarCarta();
}
