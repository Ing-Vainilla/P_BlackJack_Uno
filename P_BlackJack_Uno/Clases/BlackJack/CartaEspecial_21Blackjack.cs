using System;
using P_BlackJack_Uno.Interfaces;

namespace P_BlackJack_Uno.Clases.BlackJack;

public class CartaEspecial_21Blackjack : CartaBase, iCaras
{
    private const int ValorEspecial = 10;
    public override int Valor { get; set; }

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

    public CartaEspecial_21Blackjack(Colores colorCarta, iFigura.Figura figura, iCaras.Caras caras) : base(ValorEspecial, colorCarta)
    {
        _figura = figura;
        _caras = caras;
        _valor = ValorEspecial;
    }
}
