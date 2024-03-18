using R3;
using UnityEngine;
using UnityEngine.UI;

public class RandomSoundPlayer : MonoBehaviour
{
    [SerializeField] private AudioSource _soundSource;
    [SerializeField] private AudioClip[] _sounds;
    [SerializeField] private Button _swapper;

    private int _playingIndex = 0;

    private void Awake()
    {
        ChangeSongRandomly();
    }

    private void Start()
    {
        if(_swapper != null)
        {
            _swapper
                .OnClickAsObservable()
                .Subscribe(_ => ChangeSongRandomly())
                .AddTo(this);
        }
    }

    private void ChangeSongRandomly()
    {
        int next;
        do
        {
            next = Random.Range(0,_sounds.Length);
        }
        while(next == _playingIndex);

        _soundSource.Stop();
        _soundSource.clip = _sounds[next];
        _soundSource.Play();

        _playingIndex = next;
    }
}
