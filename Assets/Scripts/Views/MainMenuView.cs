using R3;
using UnityEngine;
using UnityEngine.UI;

public class MainMenuView : MonoBehaviour
{
    [SerializeField]
    private SerializableReactiveProperty<bool> _oldStyleSoundtrack = new SerializableReactiveProperty<bool>(false);
    [SerializeField] private Button _soundtrackSwapper;
    [SerializeField] private AudioSource _soundtrackPlayer;
    [SerializeField] private AudioClip _oldSoundtrack;
    [SerializeField] private AudioClip _newSoundtrack;   


    private void Start()
    {
        _oldStyleSoundtrack
            .Where(isOld => isOld)
            .Select(_ => _oldSoundtrack)
            .Merge(_oldStyleSoundtrack.Where(isOld => !isOld).Select(_ => _newSoundtrack))
            .Subscribe(SwapSoundtrack)
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
