using R3;
using UnityEngine;
using UnityEngine.SceneManagement;
using Zenject;

public class StateView : MonoBehaviour
{
    [Inject] private IStateController _controller;

    private void Start()
    {
        SceneManager.sceneLoaded += OnSceneLoaded;

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
                {
                    _controller.SetLoading(true);
                    SceneManager.LoadSceneAsync(0,LoadSceneMode.Single);
                } 
                return;
            case GameState.HiraganaMenu:
                if(!SceneManager.GetSceneByBuildIndex(1).IsValid())
                {
                    _controller.SetLoading(true);
                    SceneManager.LoadSceneAsync(1,LoadSceneMode.Single);
                }
                    
                return;
        }
    }

    private void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        _controller.SetLoading(false);
    }
}
