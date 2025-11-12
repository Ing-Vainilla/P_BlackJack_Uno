using System;
using P_BlackJack_Uno.Clases.Uno;
using P_BlackJack_Uno.Interfaces;
namespace P_BlackJack_Uno.Clases.Uno;
public class BarajaUno : BarajaBase, IPilaActiva
{
    private readonly List<CartaBase> _pilaDescarte = new List<CartaBase>();

    public List<CartaBase> PilaDescarte => _pilaDescarte;
    public CartaBase CartaSuperior
    {
        get => _pilaDescarte.Last();
    }

    public void DescartarCarta(CartaBase carta)
    {
        _pilaDescarte.Add(carta);
    }

    public void ReciclarDescarte()
    {
        if (PilaDescarte.Count <= 1)
        {
            throw new InvalidOperationException("No hay suficientes cartas para reciclar.");
        }

        CartaBase cartaSuperior = PilaDescarte.Last();
        PilaDescarte.RemoveAt(PilaDescarte.Count - 1);
        this.Cartas.AddRange(PilaDescarte);
        _pilaDescarte.Clear();
        _pilaDescarte.Add(cartaSuperior);
        this.Barajar();
    }
    private readonly CartaBase.Colores[] _coloresUNO = { CartaBase.Colores.Rojo, CartaBase.Colores.Azul, CartaBase.Colores.Verde, CartaBase.Colores.Amarillo };
    protected override void LlenarMazo()
    {
        this.Cartas.Clear();
        foreach (var color in _coloresUNO)
        {
            Cartas.Add(new CartaNormalUNO(0, color));
            for (int valor = 1; valor <= 9; valor++)
            {
                Cartas.Add(new CartaNormalUNO(valor, color));
                Cartas.Add(new CartaNormalUNO(valor, color));
            }
            foreach (CartaEspecialUno.TipoAccion accion in Enum.GetValues(typeof(CartaEspecialUno.TipoAccion)))
            {
                Cartas.Add(new CartaEspecialUno(accion, color));
                Cartas.Add(new CartaEspecialUno(accion, color));
            }
        }
        for(int i = 0; i < 4; i++)
        {
            Cartas.Add(new CartaComodinUno(CartaComodinUno.TipoComodin.CambioColor));
            Cartas.Add(new CartaComodinUno(CartaComodinUno.TipoComodin.MasCuatro));
        }
    }
}