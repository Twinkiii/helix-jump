using UnityEngine;

public class PaintFloor : BallEvents
{
    [SerializeField] private Transform paint;
    [SerializeField] private Transform ball;
    [SerializeField] private Transform level;
    [SerializeField] private SpriteRenderer ColorOfPaint;
    [SerializeField] private Material ballMaterial;

    int i = 0;

    

    protected override void OnBallCollisionSegment(SegmentType type)
    {
        ColorOfPaint.color = ballMaterial.color;
        if (type != SegmentType.Empty)
        {
            Transform blot = Instantiate(paint, level);
            
            blot.position = new Vector3(ball.position.x, ball.position.y - 0.12f, ball.position.z);
            
            blot.name = "blot" + i;
            i++;
        }


}
}
