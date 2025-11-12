using System;
using System.Collections.Generic;
using System.Linq;
using P_BlackJack_Uno.Clases;
using P_BlackJack_Uno.Interfaces;
namespace P_BlackJack_Uno.Clases.Uno;

public class EstrategiaAleatoriaUno : IEstrategiaUno
{
    private readonly Random _random = new Random();

    public CartaBase? ElegirCarta(List<CartaBase> mano, CartaBase cartaSuperior)
    {
        List<CartaBase> cartasJugables = mano.Where(cartaEnMano => EsCompatible(cartaEnMano, cartaSuperior)).ToList();

        if (!cartasJugables.Any())
        {
            return null;
        }

        int indiceAleatorio = _random.Next(0, cartasJugables.Count);
        return cartasJugables[indiceAleatorio];
    }
    private bool EsCompatible(CartaBase cartaEnMano, CartaBase cartaSuperior)
    {
        if (cartaEnMano.Color == cartaSuperior.Color)
        {
            return true;
        }
        if (cartaEnMano.Valor == cartaSuperior.Valor)
        {
            return true;
        }
        if (cartaEnMano.Color == CartaBase.Colores.Negro)
        {
            return true;
        }

        return false;
    }
}