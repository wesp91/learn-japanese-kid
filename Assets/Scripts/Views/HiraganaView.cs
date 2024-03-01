using R3;
using UnityEngine;
using Zenject;

public class HiraganaManuView : MonoBehaviour
{
    [Inject] private IStateController _stateController;

    [SerializeField] private Canvas _mainMenu;

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
    }
}
