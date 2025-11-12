using System;
using P_BlackJack_Uno.Interfaces;

namespace P_BlackJack_Uno.Clases.Uno;

public class EstrategiaCalculadorUno : IEstrategiaUno
{
    public CartaBase? ElegirCarta(List<CartaBase> mano, CartaBase cartaSuperior, List<IJugador> jugadoresEnJuego, IJugador jugadorActual)
    {
        List<CartaBase> jugables = GetCartasJugables(mano, cartaSuperior);
        if (!jugables.Any())
        {
            return null;
        }
        
    }
}
