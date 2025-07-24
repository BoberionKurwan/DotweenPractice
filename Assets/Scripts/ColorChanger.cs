using UnityEngine;
using DG.Tweening;

public class ColorChanger : MonoBehaviour
{
    [SerializeField] private float _duration;
    [SerializeField] private int _repeats;
    [SerializeField] private LoopType _loopType;
    [SerializeField] private Color _toColor;
    [SerializeField] private Color _fromColor;

    private Renderer _renderer;

    private void Start()
    {
        _renderer = GetComponent<Renderer>();

        _renderer.material.DOColor(_toColor, _duration)
            .From(_fromColor)
            .SetLoops(_repeats, _loopType);
           
    }
}
