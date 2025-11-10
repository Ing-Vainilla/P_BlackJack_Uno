using System;

namespace P_BlackJack_Uno.Clases.BlackJack;

public abstract class CartaBase_21Blackjack : CartaBase
{
     public override int Valor
    {
        get {return _valor; }
        set {_valor = value; }
    }

    public override Colores Color
    {
        get {return _color; }
        set {_color = value; } 
    }

    public CartaBase_21Blackjack (int valorCarta, Colores colorCarta) : base (valorCarta, colorCarta)
    {
        
    }

}
