using R3;
using TMPro;
using UnityEngine;
using Zenject;

public class HiraganaDrawerCanvasView : MonoBehaviour
{
    [Inject] private IStateController _stateController;

    [SerializeField] private TextMeshProUGUI _drawerText;

    private void Start()
    {
        _stateController
            .OnSelectedHiraganaChanged
            .Subscribe(hiragana => _drawerText.text = hiragana.ToString())
            .AddTo(this);    
    }
}
