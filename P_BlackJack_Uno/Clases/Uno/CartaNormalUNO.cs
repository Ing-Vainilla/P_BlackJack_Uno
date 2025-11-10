using System;

namespace P_BlackJack_Uno.Clases.Uno;

public class CartaNormalUNO : CartaBase
{   
    public override int Valor
    {
        get => _valor;
        set
        {
            if (value < 0 || value > 9)
            {
                throw new ArgumentOutOfRangeException(nameof(value), "El valor de una carta normal de UNO debe estar entre 0 y 9.");
            }
            _valor = value;
        }
    }
    private static readonly Colores[] _coloresUNO = new Colores[]
    {
        Colores.Rojo,
        Colores.Azul,
        Colores.Verde,
        Colores.Amarillo
    };

    public override Colores Color
    {
        get => _color;
        set
        {
            if (_coloresUNO.Contains(value))
            {
                _color = value;
            }
            else
            {
                throw new ArgumentException("El color no es válido para una carta normal de UNO.", nameof(value));
            }
        }
    }
    public override string Descripcion
    {
        get => $"{Color} {_valor}";
    }
    
    public CartaNormalUNO(int valorCarta, Colores colorCarta) : base(valorCarta, colorCarta)
    {
        
    }
}
