using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

public class SequentialTextChanger : MonoBehaviour
{
    private const string Replace = "����� �������";
    private const string Expand = "����� ��������";
    private const string Hack = "����� �������";

    [SerializeField] private Text _text;
    [SerializeField] private float _duration;
    [SerializeField, Min(-1)] private int _loopsCount;

    private void Start()
    {
        DOTween.Sequence()
            .Append(_text.DOText(Replace, _duration))
            .Append(_text.DOText(Expand, _duration).SetRelative())
            .Append(_text.DOText(Hack, _duration, false, ScrambleMode.All))
            .SetLoops(_loopsCount);
    }
}
