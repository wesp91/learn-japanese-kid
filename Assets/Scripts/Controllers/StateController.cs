using R3;
using Zenject;

public interface IStateController
{
    #region Actions
    void SetGameState(GameState state);
    void SetHiragana(HiraganaEnum value);
    #endregion

    #region Observables
    Observable<GameState> OnGameStateChanged { get; }
    Observable<HiraganaEnum> OnSelectedHiraganaChanged { get; }
    #endregion
}

public class StateController : IStateController
{
    [Inject] private IStateModel _model;

    public StateController(IStateModel model)
    {
        _model = model;
    }

    #region Actions
    public void SetGameState(GameState state)
    {
        _model.SetState(state);
    }

    public void SetHiragana(HiraganaEnum value)
    {
        _model.SetHiragana(value);
    }
    #endregion

    #region Observables
    public Observable<GameState> OnGameStateChanged => _model.OnStateChanged;
    public Observable<HiraganaEnum> OnSelectedHiraganaChanged => _model.OnSelectedHiraganaChanged;
    #endregion
}