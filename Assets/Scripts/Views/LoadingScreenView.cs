using R3;
using UnityEngine;
using Zenject;

public class LoadingScreenView : MonoBehaviour
{
    [Inject] private IStateController _stateController;
    
    private void Start()
    {
        _stateController
            .OnLoadingStateChanged
            .Subscribe(gameObject.SetActive)
            .AddTo(this);
    }
}
