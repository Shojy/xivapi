using System;

namespace XIVApi.Data
{
    [Flags]
    public enum DataCenter
    {
        None,
        Elemental,
        Gaia,
        Mana,
        Aether,
        Primal,
        Crystal,
        Chaos,
        Light
    }
}