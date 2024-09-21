using DG.Tweening;

public class Rotator : TransformChanger
{
    private void Start() => Change();

    protected override void Change()
    {
        transform.DORotate(Target, Duration).SetLoops(LoopCount, LoopType);
    }
}
