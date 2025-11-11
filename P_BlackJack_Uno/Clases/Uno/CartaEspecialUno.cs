using System;
using P_BlackJack_Uno.Interfaces;

namespace P_BlackJack_Uno.Clases.Uno;

public class CartaEspecialUno : CartaBase, IComportamiento
{
    public enum TipoAccion
    {
        MasDos, Reversa, Bloqueo
    }
    public TipoAccion Accion { get; private set; }
    private const int ValorEspecial = 0;
    public override int Valor { get; set; }
    public override Colores Color
    {
        get => _color;
        set => _color = value;
    }
    public override string Descripcion { get; }

    public CartaEspecialUno(TipoAccion accion, Colores color) : base(ValorEspecial, color)
    {
        this.Accion = accion;
        this.Valor = ValorEspecial;
        this.Descripcion = $"{accion.ToString()} {color}";
    }
    public void AccionEspecial(object juegoActual)
    {
        
    }
}