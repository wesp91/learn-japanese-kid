using UnityEngine;
using Zenject;

[CreateAssetMenu(fileName = "GifContainerInstaller", menuName = "Installers/GifContainerInstaller")]
public class GifContainerInstaller : ScriptableObjectInstaller<GifContainerInstaller>
{
    [SerializeField]
        private PokemonSpriteContainer _pokemon;

        public override void InstallBindings()
        {
            Container.BindInstance(_pokemon).AsCached();
        }
}