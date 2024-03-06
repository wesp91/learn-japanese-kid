using System;
using System.Collections.Generic;
using System.Linq;
using NUnit.Framework.Internal;
using UnityEngine;

[CreateAssetMenu(fileName = "Gif", menuName = "ScriptableObjects/PokemonSpriteContainer", order = 1)]
public class PokemonSpriteContainer : ScriptableObject
{
    public List<SpriteContainer> Gifs = new();

    public void OnValidate()
    {
        Gifs = Gifs.OrderBy(x => x.PokemonName).ToList();
    }
}

[Serializable]
public class SpriteContainer
{
    public Pokemon PokemonName;
    public List<Texture> Sprites = new();
    public float FrameDelay = 0f;
} 