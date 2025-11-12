using System.Collections.Generic;
using P_BlackJack_Uno.Interfaces;
using P_BlackJack_Uno.Clases;
using P_BlackJack_Uno.Clases.BlackJack;

namespace P_BlackJack_Uno.Clases.BlackJack;

public class BarajaBJ : BarajaBase
{
    private static readonly Dictionary<iFigura.Figura, CartaBase.Colores> _figurayColor=
      new Dictionary<iFigura.Figura, CartaBase.Colores>()
  {
        { iFigura.Figura.Corazones, CartaBase.Colores.Rojo },
        { iFigura.Figura.Diamantes, CartaBase.Colores.Rojo },
        { iFigura.Figura.Espadas, CartaBase.Colores.Negro },
        { iFigura.Figura.Treboles, CartaBase.Colores.Negro }
  };

    private static readonly iCaras.Caras[] _rangosNumericos =
     { iCaras.Caras.Dos, iCaras.Caras.Tres, iCaras.Caras.Cuatro, iCaras.Caras.Cinco,
          iCaras.Caras.Seis, iCaras.Caras.Siete, iCaras.Caras.Ocho, iCaras.Caras.Nueve,
          iCaras.Caras.Diez
        };

    private static readonly iCaras.Caras[] _carasEspeciales = 
        { iCaras.Caras.AS, iCaras.Caras.K, iCaras.Caras.Q, iCaras.Caras.J };


    protected override void LlenarMazo()
    {
        foreach (var par in _figurayColor)
        {
            iFigura.Figura figuraActual = par.Key;
            CartaBase.Colores colorActual = par.Value;

            foreach (iCaras.Caras rango in _rangosNumericos)
            {
                int valorNumerico = (int)rango;
                Cartas.Add(new CartaBase_21Blackjack(valorNumerico, colorActual, figuraActual));
            }
            
            foreach (iCaras.Caras cara in _carasEspeciales)
            {
                Cartas.Add(new CartaEspecial_21Blackjack(colorActual, figuraActual, cara));
            }
        }
    }
}

