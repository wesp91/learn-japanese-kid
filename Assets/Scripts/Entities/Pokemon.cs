using UnityEngine;

public enum Pokemon 
{
    Venusaur = 3,
    Charizard = 9,
    Caterpie = 10,
    Arbok = 24,
    Raichu = 26,
    Nidoking = 34,
    Vulpix = 37,
    Gloom = 44,
    Arcanine = 59,
    Abra = 63,
    Kadabra = 64,
    Machop = 66,
    Slowbro = 80,
    Magnemite = 81,
    Hitmonlee = 108,
    Electrode = 101,
    Exeggcute = 102,
    Exeggutor = 103,
    Tangela = 114,
    Goldeen = 118,
    Staryu = 120,
    Starmie = 121,
    Jynx = 124,
    Electabuzz = 125,
    Ditto = 132,
    Eevee = 133,
    Vaporeon = 134,
    Omastar = 139,
    Dratini = 147,
    Dragonair = 148,
    Dragonite = 149,
    Chikorita = 152,
    Quagsire = 195,
    Unown = 201,
    Wobbuffet = 202,
    Shuckle = 213,
    Heracross = 214,
    Smoochum = 238,
    Celebi = 251,
    Nosepass = 299,
    Wailmer = 320,
    Duskull = 355,
    Metagross = 376,
    Rayquaza = 384,
    Braixen = 654,
    Coalossal = 839,
    Sirfetchd = 865,

    Unown_A = 1001,
    Unown_Interrogation = 1028,
}


public static class PokemonHelper
{
    public static Vector2 GetOffset(Pokemon pokemon)
    {
        switch(pokemon)
        {
            case Pokemon.Charizard:
                return new Vector2(-10,-10);
            case Pokemon.Arcanine:
                return new Vector2(6,0);
            case Pokemon.Dragonite:
                return new Vector2(0,-10);
            case Pokemon.Caterpie:
                return new Vector2(10,5);
            case Pokemon.Magnemite:
                return new Vector2(10,15);
            case Pokemon.Hitmonlee:
                return new Vector2(10,0);
            default:
                return Vector2.zero;
        }
    }
}