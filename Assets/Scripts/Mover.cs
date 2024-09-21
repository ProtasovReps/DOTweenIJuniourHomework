using DG.Tweening;

public class Mover : TransformChanger
{
    private void Start() => Change();

    protected override void Change()
    {
        transform.DOMove(Target, Duration).SetLoops(LoopCount, LoopType);
    }
}