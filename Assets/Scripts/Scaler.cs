using DG.Tweening;

public class Scaler : TransformChanger
{
    private void Start() => Change();

    protected override void Change()
    {
        transform.DOScale(Target, Duration).SetLoops(LoopCount, LoopType);
    }
}
