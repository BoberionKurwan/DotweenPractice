using DG.Tweening;
using System.Runtime.CompilerServices;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    [SerializeField] private Vector3 _rotation;
    [SerializeField] private float _duration;
    [SerializeField] private int _repeats;
    [SerializeField] private LoopType _loopType;
    [SerializeField] private RotateMode _rotateMode;

    private void Start()
    {
        transform.DORotate(_rotation, _duration, _rotateMode).SetLoops(_repeats, _loopType);
    }
}
