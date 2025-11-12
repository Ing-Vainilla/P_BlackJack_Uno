using System;

namespace P_BlackJack_Uno.Interfaces;

public interface iCaras
{
    Caras caras {get;}
    public enum Caras
    {
        Uno,
        Dos,
        Tres,
        Cuatro,
        Cinco,
        Seis,
        Siete,
        Ocho,
        Nueve,
        Diez,
        AS,
        J,
        Q,
        K,
    }
}
