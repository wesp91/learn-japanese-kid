using R3;

public interface IStateModel
{
    #region Actions
    void SetState(GameState value);
    void SetHiragana(HiraganaEnum value);
    void SetLoading(bool isLoading);
    #endregion

    #region Observables
    Observable<GameState> OnStateChanged { get; }
    Observable<HiraganaEnum> OnSelectedHiraganaChanged { get; }
    Observable<bool> OnLoadingStateChanged { get; }
    #endregion
}

public class StateModel : IStateModel
{
    private ReactiveProperty<GameState> _currentState = new ReactiveProperty<GameState>(GameState.MainMenu);
    private ReactiveProperty<bool> _loadingState = new ReactiveProperty<bool>(false);
    private ReactiveProperty<HiraganaEnum> _currentHiragana = new ReactiveProperty<HiraganaEnum>();


    #region Actions
    public void SetState(GameState value)
    {
        _currentState.Value = value;
    }

    public void SetHiragana(HiraganaEnum value)
    {
        _currentHiragana.Value = value;
    }

    public void SetLoading(bool isLoading)
    {
        _loadingState.Value = isLoading;
    }
    #endregion

    #region Obervables
    public Observable<GameState> OnStateChanged => _currentState;
    public Observable<HiraganaEnum> OnSelectedHiraganaChanged => _currentHiragana;
    public Observable<bool> OnLoadingStateChanged => _loadingState;
    #endregion
}
