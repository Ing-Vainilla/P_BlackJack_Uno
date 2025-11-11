using System;
using P_BlackJack_Uno.Interfaces;
namespace P_BlackJack_Uno.Clases;

public abstract class BarajaBase : IBaraja
{
    public List<CartaBase> Cartas { get; private set; } = new List<CartaBase>();

    public BarajaBase()
    {
        LlenarMazo();
    }

    protected abstract void LlenarMazo();

    public void Barajar()
    {
        Random rng = new Random();
        int n = Cartas.Count;
        while (n > 1)
        {
            n--;
            int k = rng.Next(n + 1);
            CartaBase value = Cartas[k];
            Cartas[k] = Cartas[n];
            Cartas[n] = value;
        }
    }
    public CartaBase TomarCarta()
    {
        if (Cartas.Count == 0)
        {
            throw new InvalidOperationException("La baraja está vacía.");
        }

        CartaBase cartaTomada = Cartas[Cartas.Count - 1];
        Cartas.RemoveAt(Cartas.Count - 1);
        return cartaTomada;
    }
}
