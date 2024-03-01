using R3;
using UnityEngine;
using UnityEngine.SceneManagement;
using Zenject;

public class StateView : MonoBehaviour
{
    [Inject] private IStateController _controller;

    private void Start()
    {
        _controller
            .OnGameStateChanged
            .Subscribe(LoadScene)
            .AddTo(this);    
    }

    private void LoadScene(GameState state)
    {
        switch(state)
        {
            case GameState.MainMenu:
                if(!SceneManager.GetSceneByBuildIndex(0).IsValid())
                    SceneManager.LoadSceneAsync(0,LoadSceneMode.Single);
                return;
            case GameState.HiraganaMenu:
                if(!SceneManager.GetSceneByBuildIndex(1).IsValid())
                    SceneManager.LoadSceneAsync(1,LoadSceneMode.Single);
                return;
        }
    }
}
