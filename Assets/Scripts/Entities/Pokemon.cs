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
    public static Vector2 GetHiraganaMenuOffset(Pokemon pokemon)
    {
        switch(pokemon)
        {
            case Pokemon.Venusaur:
                return new Vector2(-10,0);
            case Pokemon.Charizard:
                return new Vector2(-15,-10);
            case Pokemon.Caterpie:
                return new Vector2(10,5);
            case Pokemon.Arbok:
                return new Vector2(0,0);
            case Pokemon.Raichu:
                return new Vector2(5,0);
            case Pokemon.Nidoking:
                return new Vector2(-10,0);
            case Pokemon.Vulpix:
                return new Vector2(10,5);
            case Pokemon.Gloom:
                return new Vector2(0,0);
            case Pokemon.Arcanine:
                return new Vector2(6,0);
            case Pokemon.Abra:
                return new Vector2(0,0);
            case Pokemon.Kadabra:
                return new Vector2(0,0);
            case Pokemon.Machop:
                return new Vector2(15,0);
            case Pokemon.Slowbro:
                return new Vector2(0,0);
            case Pokemon.Magnemite:
                return new Vector2(10,15);
            case Pokemon.Hitmonlee:
                return new Vector2(10,0);
            case Pokemon.Electrode:
                return new Vector2(0,0);
            case Pokemon.Exeggcute:
                return new Vector2(0,0);
            case Pokemon.Exeggutor:
                return new Vector2(-35,0);
            case Pokemon.Tangela:
                return new Vector2(10,0);
            case Pokemon.Goldeen:
                return new Vector2(0,10);
            case Pokemon.Staryu:
                return new Vector2(10,5);
            case Pokemon.Starmie:
                return new Vector2(0,0);
            case Pokemon.Jynx:
                return new Vector2(0,0);
            case Pokemon.Electabuzz:
                return new Vector2(0,0);
            case Pokemon.Ditto:
                return new Vector2(0,0);
            case Pokemon.Eevee:
                return new Vector2(0,0);
            case Pokemon.Vaporeon:
                return new Vector2(0,0);
            case Pokemon.Omastar:
                return new Vector2(0,0);
            case Pokemon.Dratini:
                return new Vector2(15,0);
            case Pokemon.Dragonair:
                return new Vector2(0,0);
            case Pokemon.Dragonite:
                return new Vector2(0,-10);
            case Pokemon.Chikorita:
                return new Vector2(20,0);
            case Pokemon.Quagsire:
                return new Vector2(10,0);
            case Pokemon.Unown:
                return new Vector2(0,0);
            case Pokemon.Wobbuffet:
                return new Vector2(15,0);
            case Pokemon.Shuckle:
                return new Vector2(0,0);
            case Pokemon.Heracross:
                return new Vector2(0,0);
            case Pokemon.Smoochum:
                return new Vector2(15,0);
            case Pokemon.Celebi:
                return new Vector2(0,0);
            case Pokemon.Nosepass:
                return new Vector2(0,0);
            case Pokemon.Wailmer:
                return new Vector2(-5,0);
            case Pokemon.Duskull:
                return new Vector2(10,0);
            case Pokemon.Metagross:
                return new Vector2(-30,-5);
            case Pokemon.Rayquaza:
                return new Vector2(-30,-40);
            case Pokemon.Braixen:
                return new Vector2(0,0);
            case Pokemon.Coalossal:
                return new Vector2(-10,-9);
            case Pokemon.Sirfetchd:
                return new Vector2(0,0);
            case Pokemon.Unown_A:
                return new Vector2(0,0);
            case Pokemon.Unown_Interrogation:
                return new Vector2(10,10);
            default:
                return Vector2.zero;
        }
    }
}