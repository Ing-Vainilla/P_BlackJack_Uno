using System;
using P_BlackJack_Uno.Interfaces;

namespace P_BlackJack_Uno.Clases.BlackJack;

public class CartaEspecial_21Blackjack : CartaBase, iCaras
{
     public override int Valor
    {
        get { return _valor; }
        set
        {
            if (value != 10)
            {
                throw new Exception($"El valor de la carta no es valido");
            }
            _valor = value;
        }
    }

    private static readonly Colores[] _coloresBlackjack = new Colores[]
   {
        Colores.Rojo,
        Colores.Negro,
   };
    
     public override Colores Color
    {
        get { return _color; }
        set
        {
            if (_coloresBlackjack.Contains(value))
            {
                _color = value;
            }
            else
            {
                throw new Exception($"El color de la carta no es valido");
            }
        }
    }

    private iFigura.Figura _figura;

     public iFigura.Figura figura
    {
        get { return _figura; }
    }

    private iCaras.Caras _caras;
    public iCaras.Caras caras
    {
        get { return _caras; }
    }

        public override string Descripcion
    {
        get => $" {caras} {figura} {Color} {Valor} ";
    }

    public CartaEspecial_21Blackjack(int valorCarta, Colores colorCarta, iFigura.Figura figura, iCaras.Caras caras) : base(valorCarta, colorCarta)
    {
        _figura = figura;
        _caras = caras;
    }
}
