using System.Collections.Generic;
using R3;
using UnityEngine;

public class HiraganaGridView : MonoBehaviour
{
    [SerializeField] private List<HiraganaButton> _buttons;

    private void Start()
    {
        foreach(HiraganaButton b in _buttons)
        {
            b.OnClick
                .Subscribe(type =>
                {

                })
                .AddTo(this);
        }
    }
}
