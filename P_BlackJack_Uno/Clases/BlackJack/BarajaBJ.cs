using System;
using System.Drawing;
using P_BlackJack_Uno.Interfaces;

namespace P_BlackJack_Uno.Clases.BlackJack;

public class BarajaBJ : BarajaBase, IPilaActiva
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

    private readonly CartaBase.Colores[] _coloresBlackjack = { CartaBase.Colores.Rojo, CartaBase.Colores.Negro };
    protected override void LlenarMazo()
    {
        this.Cartas.Clear();
        
    }
}
