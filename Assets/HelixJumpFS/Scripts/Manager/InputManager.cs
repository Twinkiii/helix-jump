using UnityEngine;

public class InputManager : BallEvents
{
    [SerializeField] private MouseRotatoer InputRotatror;

    protected override void OnBallCollisionSegment(SegmentType type)
    {
        if(type == SegmentType.Finish || type == SegmentType.Trap)
        {
            InputRotatror.enabled = false;
        }
    }
}
