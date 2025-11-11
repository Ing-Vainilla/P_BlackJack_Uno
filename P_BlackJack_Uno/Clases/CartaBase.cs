using System;

namespace P_BlackJack_Uno.Clases;

public abstract class CartaBase
{
    protected int _valor;
    protected Colores _color;
    
    public enum Colores
    {
        Rojo, Verde, Azul, Amarillo, Blanco, Negro
    }

    public abstract int Valor { get; set;  }
    public abstract Colores Color { get; set; }
    public abstract string Descripcion { get; }

    protected CartaBase(int valorCarta, Colores colorCarta)
    {
        this.Valor = valorCarta;
        this.Color = colorCarta;
    }
}
