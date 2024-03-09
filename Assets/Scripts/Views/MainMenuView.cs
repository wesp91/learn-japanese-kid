using R3;
using UnityEngine;
using UnityEngine.UI;

public class MainMenuView : MonoBehaviour
{
    [SerializeField]
    private SerializableReactiveProperty<bool> _oldStyleSoundtrack = new SerializableReactiveProperty<bool>(false);
    [SerializeField] private Button _soundtrackSwapper;
    [SerializeField] private Image _soundtrackButtonIcon;
    [SerializeField] private AudioSource _soundtrackPlayer;
    [SerializeField] private AudioClip _oldSoundtrack;
    [SerializeField] private AudioClip _newSoundtrack;
    [SerializeField] private Sprite _oldPickachu;
    [SerializeField] private Sprite _newPickachu;


    private void Start()
    {
        _oldStyleSoundtrack
            .Where(isOld => isOld)
            .Select(_ => (_oldSoundtrack,_newPickachu))
            .Merge(_oldStyleSoundtrack.Where(isOld => !isOld).Select(_ => (_newSoundtrack,_oldPickachu)))
            .Subscribe(data =>
            {
                SwapSoundtrack(data.Item1);
                _soundtrackButtonIcon.sprite = data.Item2;
            })
            .AddTo(this);

        _soundtrackSwapper
            .OnClickAsObservable()
            .Subscribe(_ => _oldStyleSoundtrack.Value = !_oldStyleSoundtrack.Value)
            .AddTo(this);
    }

    private void SwapSoundtrack(AudioClip clip)
    {   
        _soundtrackPlayer.Stop();
        _soundtrackPlayer.clip = clip;
        _soundtrackPlayer.Play();
    }
}
