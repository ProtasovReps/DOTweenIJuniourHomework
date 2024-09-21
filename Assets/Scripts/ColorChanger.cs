using DG.Tweening;
using UnityEngine;

public class ColorChanger : MonoBehaviour
{
    [SerializeField] private MeshRenderer _meshRenderer;
    [SerializeField] private Color _targetColor;
    [SerializeField] private float _duration;
    [SerializeField] private LoopType _loopType;
    [SerializeField, Min(-1)] private int _loopsCount;

    private void Start()
    {
        _meshRenderer.material.DOColor(_targetColor, _duration).SetLoops(_loopsCount, _loopType);
    }
}
