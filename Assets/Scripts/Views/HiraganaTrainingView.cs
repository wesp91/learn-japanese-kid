using R3;
using UnityEngine;
using UnityEngine.UI;
using Zenject;

public class HiraganaTrainingView : MonoBehaviour
{
    [Inject] private IStateController _stateController;


    [SerializeField] private Canvas _mainCanvas;
    [SerializeField] private LineDrawer _drawer;
    [SerializeField] private Button _backToMainButton;

    private void Start()
    {
        _stateController
            .OnGameStateChanged
            .Select(state => state == GameState.HiraganaDraw)
            .Subscribe(isHiraganaState => 
            {
                _mainCanvas.enabled = isHiraganaState;
                _drawer.gameObject.SetActive(isHiraganaState);
            })
            .AddTo(this);
        
        _stateController
            .OnGameStateChanged
            .Where(state => state == GameState.HiraganaDraw)
            .Subscribe(x => _drawer.ClearDrawnLines())
            .AddTo(this);
    }
}
