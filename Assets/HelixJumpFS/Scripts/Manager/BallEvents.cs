using UnityEngine;

public abstract class BallEvents : MonoBehaviour
{
    [SerializeField] private BallController balController;

    protected virtual void Awake()
    {
        balController.CollisionSegment.AddListener(OnBallCollisionSegment);
    }

    protected virtual void OnDestroy()
    {
        balController.CollisionSegment.RemoveListener(OnBallCollisionSegment);
    }

    protected virtual void OnBallCollisionSegment(SegmentType type) { }
    
}
