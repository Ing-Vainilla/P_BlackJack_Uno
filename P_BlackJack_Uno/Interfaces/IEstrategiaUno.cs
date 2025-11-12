using System;
using P_BlackJack_Uno.Clases;

namespace P_BlackJack_Uno.Interfaces;

public interface IEstrategiaUno: IEstrategia
{
    CartaBase? ElegirCarta(List<CartaBase> mano, CartaBase cartaSuperior);
}