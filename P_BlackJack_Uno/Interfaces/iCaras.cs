using System;

namespace P_BlackJack_Uno.Interfaces;

public interface iCaras
{
    Caras caras {get;}
    public enum Caras
    {
        AS,
        J,
        Q,
        K,
    }
}
