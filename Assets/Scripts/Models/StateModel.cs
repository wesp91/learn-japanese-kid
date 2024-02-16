using R3;

public interface IStateModel
{
    #region Actions
    void SetState(GameState value);
    void SetHiragana(HiraganaEnum value);
    #endregion

    #region Observables
    Observable<GameState> OnStateChanged { get; }
    Observable<HiraganaEnum> OnSelectedHiraganaChanged { get; }
    #endregion
}

public class StateModel : IStateModel
{
    public ReactiveProperty<GameState> _currentState = new ReactiveProperty<GameState>(GameState.MainMenu);
    public ReactiveProperty<HiraganaEnum> _currentHiragana = new ReactiveProperty<HiraganaEnum>();

    #region Actions
    public void SetState(GameState value)
    {
        _currentState.Value = value;
    }

    public void SetHiragana(HiraganaEnum value)
    {
        _currentHiragana.Value = value;
    }
    #endregion

    #region Obervables
        public Observable<GameState> OnStateChanged => _currentState;
        public Observable<HiraganaEnum> OnSelectedHiraganaChanged => _currentHiragana;
    #endregion
}
