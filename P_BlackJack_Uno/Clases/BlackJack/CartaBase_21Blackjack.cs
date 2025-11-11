using System;
using P_BlackJack_Uno.Interfaces;

namespace P_BlackJack_Uno.Clases.BlackJack;

public abstract class CartaBase_21Blackjack : CartaBase, iFigura
{
     public override int Valor
    {
        get {return _valor; }
        set {
            if (value < 2 || value > 10)
            {
                throw new Exception($"Ek valor de la carta no es valido");
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
    
    public override string Descripcion
    {
        get => $"{Color} {Valor} {figura}";
    }


    public CartaBase_21Blackjack(int valorCarta, Colores colorCarta, iFigura.Figura figura) : base(valorCarta, colorCarta)
    {
         _figura = figura;
    }

}
