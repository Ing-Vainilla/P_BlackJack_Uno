using System;

namespace P_BlackJack_Uno.Interfaces;

public interface iFigura
{
    Figura figura {get;}
    public enum Figura{
        Espadas,
        Corazones,
        Diamantes,
        Treboles
    }
}
