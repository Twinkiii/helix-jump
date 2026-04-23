
public class FloorFall : BallEvents
{
    protected override void OnBallCollisionSegment(SegmentType type)
    {
        if (type == SegmentType.Empty)
        {
            for (int i = transform.childCount; i > 0; i--)
            {

            }
        }

    }
}
