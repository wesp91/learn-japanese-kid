using R3;
using UnityEngine;
using UnityEngine.UI;


public class HiraganaButton : MonoBehaviour
{
    [SerializeField] private Button _button;
    [SerializeField] private HiraganaEnum _letter;

    private void Start()
    {

    }

    public Observable<HiraganaEnum> OnClick => _button.OnClickAsObservable().Select(_ => _letter);
}
