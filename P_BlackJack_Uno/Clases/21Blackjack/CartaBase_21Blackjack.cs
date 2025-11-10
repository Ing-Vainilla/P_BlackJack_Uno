using System;
using System.Drawing;

namespace CartaBase_21Blackjack.clases;

class CartaBase_21Blackjack : CartaBase
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

    public CartaBase_21Blackjack(int valorCarta, Colores colorCarta) : base (valorCarta, colorCarta)
    {
        
    }

}
