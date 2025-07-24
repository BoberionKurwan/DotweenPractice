using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

public class TextHandler : MonoBehaviour
{
    [SerializeField] private Text _text;
    [SerializeField] private string[] _phrases;
    [SerializeField] private float _duration;
    [SerializeField] private bool _isRichText;
    [SerializeField] private ScrambleMode _scrambleMode;

    private void Start()
    {
        Sequence sequence = DOTween.Sequence();

        sequence.Append(_text.DOText("Start", _duration));
        sequence.Append(_text.DOText(" Added text", _duration).SetRelative());
        sequence.Append(_text.DOText("Scrambled text", _duration, _isRichText, _scrambleMode));
    }
}
