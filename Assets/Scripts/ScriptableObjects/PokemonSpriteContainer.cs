using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using UnityEditor;
using UnityEngine;

[CreateAssetMenu(fileName = "Gif", menuName = "ScriptableObjects/PokemonSpriteContainer", order = 1)]
public class PokemonSpriteContainer : ScriptableObject
{
    public List<SpriteContainer> Gifs = new();
    
    [EditorCools.Button(name: "Load sprites")]
    private void LoadSprites() => LoadSprites(Gifs);   
     

    public void OnValidate()
    {
        Gifs = Gifs.OrderBy(x => x.PokemonName).ToList();
    }

    private void LoadSprites(List<SpriteContainer> elements)
    {
        foreach(SpriteContainer c in elements)
        {
            string folderPath = $"Assets/Textures/PokemonGifs/{(int)c.PokemonName}_{c.PokemonName.ToString().ToLower()}";
            
            string[] files = Directory.GetFiles(folderPath, "*.gif", SearchOption.TopDirectoryOnly);
            c.Sprites.Clear();
            foreach (var file in files)
            {
                Texture2D sprite = AssetDatabase.LoadAssetAtPath<Texture2D>(file);
                c.Sprites.Add(sprite);
            }
        }
    }
}

[Serializable]
public class SpriteContainer
{
    public Pokemon PokemonName;
    public List<Texture> Sprites = new();
    public float FrameDelay = 0f;
} 