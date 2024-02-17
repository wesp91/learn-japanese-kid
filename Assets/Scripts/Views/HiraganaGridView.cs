using System.Collections.Generic;
using R3;
using UnityEngine;
using Zenject;

public class HiraganaGridView : MonoBehaviour
{
    [Inject] private IStateController _stateController;
    [SerializeField] private List<HiraganaButton> _buttons;

    private void Start()
    {
        foreach(HiraganaButton b in _buttons)
        {
            b.OnClick
                .Subscribe(type =>
                {
                    _stateController.SetHiragana(type);
                    _stateController.SetGameState(GameState.HiraganaDraw);
                })
                .AddTo(this);
        }
    }
}
