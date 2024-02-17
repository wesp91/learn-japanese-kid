using R3;
using TMPro;
using UnityEngine;
using UnityEngine.UI;


public class HiraganaButton : MonoBehaviour
{
    [SerializeField] private Button _button;
    [SerializeField] private HiraganaEnum _letter;
    [SerializeField] private TextMeshProUGUI _text;

    private void Start()
    {
        _text.text = _letter.ToString();

        gameObject.name = $"Button - {_text.text}";
    }

    public Observable<HiraganaEnum> OnClick => _button.OnClickAsObservable().Select(_ => _letter);
}
