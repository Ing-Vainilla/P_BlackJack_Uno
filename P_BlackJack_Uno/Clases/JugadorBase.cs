using System;
using System.Linq;
using System.Collections.Generic;
using P_BlackJack_Uno.Interfaces;
namespace P_BlackJack_Uno.Clases;

public class JugadorBase : IJugador
{
    protected readonly Dictionary<string, IEstrategia> _estrategias;

    public string Nombre { get; protected set; }
    public List<CartaBase> Mano { get; } = new List<CartaBase>();

    public JugadorBase(string nombre, Dictionary<string, IEstrategia> estrategias)
    {
        this.Nombre = nombre;
        this._estrategias = estrategias;
    }

    public void RecibirCarta(CartaBase carta) => Mano.Add(carta);
    public void DescartarCarta(CartaBase carta) => Mano.Remove(carta);

    /// <summary>
    /// Método para ejecutar una estrategia específica.
    /// </summary>
    /// <typeparam name="TEstrategia">Nombre de la estrategia a ejecutar</typeparam>
    /// <param name="nombreJuego">Nombre del juego actual</param>
    /// <returns>Resultado de la estrategia</returns>

    public TEstrategia GetEstrategia<TEstrategia>(string nombreJuego) where TEstrategia : IEstrategia
    {
        if (_estrategias.TryGetValue(nombreJuego, out var estrategiaBase))
        {
            return (TEstrategia)estrategiaBase;
        }
        throw new KeyNotFoundException($"Estrategia para el juego '{nombreJuego}' no encontrada.");
    }
}
