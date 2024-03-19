using System.Linq;
using R3;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using Zenject;


public class HiraganaButton : MonoBehaviour
{
    [Inject] private PokemonSpriteContainer _pokemonSpriteContainer;
    [SerializeField] private Button _button;
    [SerializeField] private HiraganaEnum _letter;
    [SerializeField] private TextMeshProUGUI _text;
    [SerializeField] private RawImage _sprite;
    [SerializeField] private Pokemon _pokemon;


    private SpriteContainer _gif;
    private int _currentFrame = 0;
    private float _gifTime = 0.0f;
    private RectTransform _rect;

    private void Start()
    {
        _rect = _sprite.GetComponent<RectTransform>();
        
        _text.text = _letter.ToString();
        gameObject.name = $"Button - {_text.text}";

        _gif = _pokemonSpriteContainer.Gifs.Where(x => x.PokemonName == _pokemon).FirstOrDefault();

        
        if(_rect != null && _gif != null && _gif.Sprites != null && _gif.Sprites.Count > 0)
        {
            _rect.anchoredPosition += PokemonHelper.GetHiraganaMenuOffset(_pokemon);
            _rect.sizeDelta = new Vector2(_gif.Sprites[0].width, _gif.Sprites[0].height) * 1.2f;

            Observable
                .EveryUpdate()
                .Subscribe(_ =>
                {
                    _gifTime += Time.deltaTime;

                    if(_gifTime >= _gif.FrameDelay)
                    {
                        _currentFrame = ( _currentFrame + 1 ) % _gif.Sprites.Count;
                        _gifTime = 0.0f;

                        _sprite.texture = _gif.Sprites[_currentFrame];
                    }
                })
                .AddTo(this);
        }
    }

    public Observable<HiraganaEnum> OnClick => _button.OnClickAsObservable().Select(_ => _letter);
}
