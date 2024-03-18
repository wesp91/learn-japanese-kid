using DG.Tweening;
using R3;
using UnityEngine;
using UnityEngine.UI;

public class RotateIconOnClick : MonoBehaviour
{
    [SerializeField] private Button _button;
    [SerializeField] private RectTransform _rect;
    [SerializeField] private int _rotation = -360;
    [SerializeField] private float _duration = 0.7f;
    [SerializeField] private RotateMode _rotateMode = RotateMode.FastBeyond360;
    [SerializeField] private Ease _ease = Ease.Linear;


    private void Start()
    {
        DOTween.Init();

        _button
            .OnClickAsObservable()
            .Subscribe(_ =>
            {
                _rect
                    .DOLocalRotate(new Vector3(0, 0, _rotation), _duration, _rotateMode)
                    .SetRelative(true)
                    .SetEase(_ease);
            })
            .AddTo(this);
    }
}
