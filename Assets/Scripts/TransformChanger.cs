using DG.Tweening;
using UnityEngine;

public abstract class TransformChanger : MonoBehaviour
{
    [SerializeField] private Vector3 _target;
    [SerializeField] private LoopType _loopType;
    [SerializeField] private float _duration;
    [SerializeField, Min(-1)] private int _loopCount;

    public Vector3 Target => _target;
    public LoopType LoopType => _loopType;
    public int LoopCount => _loopCount;
    public float Duration => _duration;

    protected abstract void Change();
}
