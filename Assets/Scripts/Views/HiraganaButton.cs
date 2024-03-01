using System.Collections.Generic;
using System.IO;
using R3;
using ThreeDISevenZeroR.UnityGifDecoder;
using TMPro;
using UnityEngine;
using UnityEngine.UI;


public class HiraganaButton : MonoBehaviour
{
    [SerializeField] private Button _button;
    [SerializeField] private HiraganaEnum _letter;
    [SerializeField] private TextMeshProUGUI _text;
    [SerializeField] private RawImage _sprite;
    [SerializeField] private Pokemon _pokemon;


    private List<Texture> _gifFrames = new List<Texture>();
    private List<float> _frameDelays = new List<float>();
    private int _currentFrame = 0;
    private float _gifTime = 0.0f;

    private void Start()
    {
        _text.text = _letter.ToString();

        gameObject.name = $"Button - {_text.text}";

        string path = Path.Combine(Application.streamingAssetsPath, $"{(int)_pokemon}_{_pokemon.ToString().ToLower()}.gif");
        
        _sprite.GetComponent<RectTransform>().anchoredPosition += PokemonHelper.GetOffset(_pokemon);

        LoadGif(path);
    }

    private void LoadGif(string gifPath)
    {
        using (var gifStream = new GifStream(gifPath))
        {
            while (gifStream.HasMoreData)
            {
                switch (gifStream.CurrentToken)
                {
                    case GifStream.Token.Image:
                        var image = gifStream.ReadImage();
                        var frame = new Texture2D(
                            gifStream.Header.width, 
                            gifStream.Header.height, 
                            TextureFormat.ARGB32, false); 

                        frame.SetPixels32(image.colors);
                        frame.Apply();

                        _gifFrames.Add(frame);
                        _frameDelays.Add(image.SafeDelaySeconds); // More about SafeDelay below
                        break;
                    
                    case GifStream.Token.Comment:
                        var commentText = gifStream.ReadComment();
                        Debug.Log(commentText);
                        break;

                    default:
                        gifStream.SkipToken(); // Other tokens
                        break;
                }
            }

            _sprite.GetComponent<RectTransform>().sizeDelta = new Vector2(_gifFrames[0].width, _gifFrames[0].height) * 1.2f;
        }

        Observable
            .EveryUpdate()
            .Subscribe(_ =>
            {
                _gifTime += Time.deltaTime;

                if( _gifTime >= _frameDelays[ _currentFrame ] )
                {
                    _currentFrame = ( _currentFrame + 1 ) % _gifFrames.Count;
                    _gifTime = 0.0f;

                    _sprite.texture = _gifFrames[_currentFrame];
                }
            })
            .AddTo(this);
    }

    public Observable<HiraganaEnum> OnClick => _button.OnClickAsObservable().Select(_ => _letter);
}
