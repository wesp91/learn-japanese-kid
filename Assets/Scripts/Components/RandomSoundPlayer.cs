using UnityEngine;

public class RandomSoundPlayer : MonoBehaviour
{
    [SerializeField] private AudioSource _soundSource;
    [SerializeField] private AudioClip[] _sounds;

    private void Awake()
    {
        int n = Random.Range(0,_sounds.Length);

        _soundSource.clip = _sounds[n];
        _soundSource.Play();
    }
}
