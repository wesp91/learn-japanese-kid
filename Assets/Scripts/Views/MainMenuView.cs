using R3;
using UnityEngine;
using Zenject;

public class MainMenuView : MonoBehaviour
{
    [Inject] private IStateController _stateController;

    [SerializeField] private Canvas _mainMenu;

    private void Start()
    {
        _stateController
            .OnGameStateChanged
            .Select(state => state == GameState.MainMenu)
            .Subscribe(isMainMenu => 
            {
                _mainMenu.enabled = isMainMenu;
            })
            .AddTo(this);
    }
}
