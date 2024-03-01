using R3;
using UnityEngine;
using UnityEngine.UI;
using Zenject;

public class TrainingModeSelectorView : MonoBehaviour
{
    [Inject] private IStateController _stateController;

    [SerializeField] private Button _hiraganaButton;

    private void Start()
    {
            _hiraganaButton
                .OnClickAsObservable()
                .Subscribe(_ => _stateController.SetGameState(GameState.HiraganaMenu))
                .AddTo(this);
    }
}
