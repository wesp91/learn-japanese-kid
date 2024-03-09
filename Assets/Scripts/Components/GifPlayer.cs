using System.Collections.Generic;
using ModestTree;
using R3;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(RawImage))]
public class GifPlayer : MonoBehaviour
{
    
    [SerializeField] private float _frameDelay = 0.07f;
    [SerializeField] private List<Texture> _frames;


    private RawImage _sprite;
    private int _currentFrame = 0;
    private float _gifTime = 0;


    private void Start()
    {
        _sprite = GetComponent<RawImage>();

        Observable
            .EveryUpdate()
            .Where(_ => gameObject.activeInHierarchy)
            .Subscribe(_ =>
            {
                _gifTime += Time.deltaTime;

                if(_gifTime >= _frameDelay)
                {
                    _currentFrame = ( _currentFrame + 1 ) % _frames.Count;
                    _gifTime = 0.0f;

                    _sprite.texture = _frames[_currentFrame];
                }
            })
            .AddTo(this);
    }
}
