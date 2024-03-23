using UnityEngine;

public enum Pokemon 
{
    Bulbasaur = 1, //
    Ivysaur = 2, //
    Venusaur = 3,
    Charmander = 4, //
    Charmeleon = 5, //
    Charizard = 6,
    Squirtel = 7, //
    Wartortle = 8, //
    Blastoise = 9, //
    Caterpie = 10,
    Metapod = 11, //
    Butterfree = 12, //
    Weedle = 13, //
    Kakuna = 14, //
    Beedrill = 15, //
    Pidgey = 16, //
    Pidgeotto = 17, //
    Pidgeot = 18, //
    Rattata = 19, //
    Raticate = 20, //
    Spearow = 21, //
    Fearow = 22, //
    Ekans = 23, //
    Arbok = 24,
    Pikachu = 25, //
    Raichu = 26,
    Sandshrew = 27, //
    Sandslash = 28, //
    NidoranF = 29, //
    Nidorina = 30, //
    Nidoqueen = 31, //
    NidoranM = 32, //
    Nidorino = 33, //
    Nidoking = 34,
    Clefairy = 35, //
    Clefable = 36, //
    Vulpix = 37,
    Ninetales = 38, //
    Jigglypuff = 39, //
    Wigglytuff = 40, //
    Zubat = 41, //
    Golbat = 42, //
    Oddish = 43, //
    Gloom = 44,
    Vileplume = 45, //
    Paras = 46, //
    Parasect = 47, //
    Venonat = 48, //
    Venomoth = 49, //
    Diglett = 50, //
    Dugtrio = 51, //
    Meowth = 52, //
    Persian = 53, //
    Psyduck = 54, //
    Golduck = 55, //
    Mankey = 56, //
    Primeape = 57, //
    Growlithe = 58, //
    Arcanine = 59,
    Poliwag = 60, //
    Poliwhirl = 61, //
    Poliwrath = 62, //
    Abra = 63,
    Kadabra = 64,
    Alakazam = 65, //
    Machop = 66,
    Machoke = 67, //
    Machamp = 68, //
    Bellsprout = 69, //
    Weepinbell = 70, //
    Victreebel = 71, //
    Tentacool = 72, //
    Tentacruel = 73, //
    Geodude = 74, //
    Graveler = 75, //
    Golem = 76, //
    Ponyta = 77, //
    Rapidash = 78, //
    Slowpoke = 79, //
    Slowbro = 80,
    Magnemite = 81,
    Magneton = 82, //
    Farfetchd = 83, //
    Doduo = 84, //
    Dodrio = 85, //
    Seel = 86, //
    Dewgong = 87, //
    Grimer = 88, //
    Muk = 89 , //
    Shellder = 90, //
    Cloyster = 91, //
    Gastly = 92, //
    Haunter = 93, //
    Gengar = 94, //
    Onix = 95, //
    Drowzee = 96, //
    Hypno = 97, //
    Krabby = 98, //
    Kingler = 99, //
    Voltorb = 100, //
    Electrode = 101,
    Exeggcute = 102,
    Exeggutor = 103,
    Cubone = 104, //
    Marowak = 105, //
    Hitmonlee = 106,
    Hitmonchan = 107, //
    Lickitung = 108, //
    Koffing = 109, //
    Weezing = 110, //
    Rhyhorn = 111, //
    Rhydon = 112, //
    Chansey = 113, //
    Tangela = 114,
    Kangaskhan = 115, //
    Horsea = 116, //
    Seadra = 117, //
    Goldeen = 118,
    Seaking = 119, //
    Staryu = 120,
    Starmie = 121,
    MrMime = 122, //
    Scyther = 123, //
    Jynx = 124,
    Electabuzz = 125,
    Magmar = 126, //
    Pinsir = 127, //
    Tauros = 128, //
    Magikarp = 129, //
    Gyarados = 130, //
    Lapras = 131, //
    Ditto = 132,
    Eevee = 133,
    Vaporeon = 134,
    Jolteon = 135, //
    Flareon = 136, //
    Porygon = 137, //
    Omanyte = 138, //
    Omastar = 139,
    Kabuto = 140, //
    Kabutops = 141, //
    Aerodactyl = 142, //
    Snorlax = 143, //
    Articuno = 144, //
    Zapdos = 145, //
    Moltres = 146, //
    Dratini = 147,
    Dragonair = 148,
    Dragonite = 149,
    Mewtwo = 150, //
    Mew = 151, //
    
    
    // Gen 2
    Chikorita = 152,
    Quagsire = 195,
    Unown = 201,
    Wobbuffet = 202,
    Shuckle = 213,
    Heracross = 214,
    Smoochum = 238,
    Celebi = 251,

    // Gen 3
    Nosepass = 299,
    Wailmer = 320,
    Duskull = 355,
    Metagross = 376,
    Rayquaza = 384,

    // Gen 
    Braixen = 654,
    Coalossal = 839,
    Sirfetchd = 865,

    // Extra
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