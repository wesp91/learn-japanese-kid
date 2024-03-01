using R3;
using UnityEngine;
using UnityEngine.UI;
using Zenject;

public class HiraganaManuView : MonoBehaviour
{
    [Inject] private IStateController _stateController;

    [SerializeField] private Canvas _mainMenu;
    [SerializeField] private Button _homeButton;

    private void Start()
    {
        _stateController
            .OnGameStateChanged
            .Select(state => state == GameState.HiraganaMenu)
            .Subscribe(isMainMenu => 
            {
                _mainMenu.enabled = isMainMenu;
            })
            .AddTo(this);

        _homeButton
            .OnClickAsObservable()
            .Subscribe(_ => _stateController.SetGameState(GameState.MainMenu))
            .AddTo(this);
    }
}
