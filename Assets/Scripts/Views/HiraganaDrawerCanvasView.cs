using R3;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using Zenject;

public class HiraganaDrawerCanvasView : MonoBehaviour
{
    [Inject] private IStateController _stateController;

    [SerializeField] private TextMeshProUGUI _drawerText;
    [SerializeField] private Button _homeButton;
    [SerializeField] private Button _clearLinesButton;
    [SerializeField] private LineDrawer _lineDrawer;

    private void Start()
    {
        _stateController
            .OnSelectedHiraganaChanged
            .Subscribe(hiragana => _drawerText.text = hiragana.ToString())
            .AddTo(this);

        _clearLinesButton
            .OnClickAsObservable()
            .Subscribe(_ => _lineDrawer.ClearDrawnLines())
            .AddTo(this);

        _homeButton
            .OnClickAsObservable()
            .Subscribe(_ => _stateController.SetGameState(GameState.HiraganaMenu))
            .AddTo(this);
    }
}
