using R3;
using Zenject;

public interface IStateController
{
    #region Actions
    void SetGameState(GameState state);
    void SetHiragana(HiraganaEnum value);
    void SetLoading(bool isLoading);
    #endregion

    #region Observables
    Observable<GameState> OnGameStateChanged { get; }
    Observable<HiraganaEnum> OnSelectedHiraganaChanged { get; }
    Observable<bool> OnLoadingStateChanged { get; }
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

    public void SetLoading(bool isLoading)
    {
        _model.SetLoading(isLoading);
    }
    #endregion

    #region Observables
    public Observable<GameState> OnGameStateChanged => _model.OnStateChanged;
    public Observable<HiraganaEnum> OnSelectedHiraganaChanged => _model.OnSelectedHiraganaChanged;
    public Observable<bool> OnLoadingStateChanged => _model.OnLoadingStateChanged;
    #endregion
}