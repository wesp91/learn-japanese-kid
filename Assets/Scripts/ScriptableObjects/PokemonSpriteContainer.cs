using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
#if UNITY_EDITOR
using UnityEditor;
#endif
using UnityEngine;

[CreateAssetMenu(fileName = "Gif", menuName = "ScriptableObjects/PokemonSpriteContainer", order = 1)]
public class PokemonSpriteContainer : ScriptableObject
{
    public List<SpriteContainer> Gifs = new();
    
    #if UNITY_EDITOR
    [EditorCools.Button(name: "Load pokemon")]
    private void LoadPokemon() => LoadPokemonObject();
    [EditorCools.Button(name: "Load sprites")]
    private void LoadSprites() => LoadSprites(Gifs);
    #endif

    public void OnValidate()
    {
        Gifs = Gifs.OrderBy(x => x.PokemonName).ToList();
    }


    #if UNITY_EDITOR
    private void LoadPokemonObject()
    {
        Gifs = new();
        foreach(var elem in Enum.GetValues(typeof(Pokemon)))
        {
            SpriteContainer container = new SpriteContainer();
            container.PokemonName = (Pokemon) elem;
            Gifs.Add(container);
        }
    }

    private void LoadSprites(List<SpriteContainer> elements)
    {
        foreach(SpriteContainer c in elements)
        {
            //Debug.Log($"Loading {c.PokemonName}...");
            string folderPath = $"Assets/Textures/PokemonGifs/{(int)c.PokemonName}_{c.PokemonName.ToString().ToLower()}";
            
            // load sprites
            string[] files = Directory.GetFiles(folderPath, "*.gif", SearchOption.TopDirectoryOnly);
            if(files.Length == 0)
            {
                files = Directory.GetFiles(folderPath, "*.png", SearchOption.TopDirectoryOnly);
            }
            c.Sprites.Clear();
            
            foreach (var file in files)
            {
                Texture2D sprite = AssetDatabase.LoadAssetAtPath<Texture2D>(file);
                c.Sprites.Add(sprite);
            }

            // load options
            string optionFilePath = $"{folderPath}/options.json";
            if (File.Exists(optionFilePath))
            {
                string jsonContent = File.ReadAllText(optionFilePath);
                SpriteOptions options = JsonUtility.FromJson<SpriteOptions>(jsonContent);
                c.FrameDelay = options.FrameDelay;
            }
            else
            {
                Debug.LogError("JSON file not found at path: " + optionFilePath);
            }

            //Debug.Log($"\tLoaded {c.PokemonName}!");
        }
    }
    #endif
}

[Serializable]
public class SpriteContainer
{
    public Pokemon PokemonName;
    public List<Texture> Sprites = new();
    public float FrameDelay = 0f;
}

[Serializable]
public class SpriteOptions
{
    [SerializeField]
    private float frame_delay;


    public float FrameDelay 
    { 
        get { return frame_delay; } 
        private set { frame_delay = value ; } 
        }
}