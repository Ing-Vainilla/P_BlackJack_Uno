using System;
namespace P_BlackJack_Uno.Clases.Uno;
using P_BlackJack_Uno.Interfaces;

public class CartaComodinUno : CartaBase, IComportamiento
{
    public enum TipoComodin
    {
        CambioColor, MasCuatro
    }

    public TipoComodin Comodin { get; private set; }
    public Colores ColorElegido { get; set; }
    private const int ValorComodin = 0;
    public override int Valor { get; set; }
    public override Colores Color
    {
        get => Colores.Negro;
        set => _color = Colores.Negro;
    }

    public override string Descripcion { get; }

    public CartaComodinUno(TipoComodin comodin) : base(ValorComodin, Colores.Negro)
    {
        this.Comodin = comodin;
        this.Valor = ValorComodin;
        this.Descripcion = $"{Comodin.ToString()}, cambio de color a {ColorElegido}";
    }
    public void AccionEspecial(object juegoActual)
    {
        
    }
}