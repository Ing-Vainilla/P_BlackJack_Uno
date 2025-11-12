using System;

namespace P_BlackJack_Uno.Interfaces;

public interface iCaras
{
    Caras Tipo {get;}
    public enum Caras
    {
        AS,
        J,
        Q,
        K,
    }
}
