using UnityEngine;

public class LevelGenerator : MonoBehaviour
{
    [SerializeField] private Transform axis;
    [SerializeField] private Floor floorPrefabe;

    [Header("Settings")]
    [SerializeField] private int defaultFloorAmount;
    [SerializeField] private float FloorHeight;
    [SerializeField] private int AmountEmptySegment;
    [SerializeField] private int minTrapSegment;
    [SerializeField] private int maxTrapSegment;

    private float lastFoorY = 0;
    public float LastFloorY => lastFoorY;

    private float floorAmount = 0;
    public float FloorAmount => floorAmount;

   

    public void Generate(int level)
    {
        DestroyChild();
        floorAmount = defaultFloorAmount + level;
        axis.transform.localScale = new Vector3(1, floorAmount * FloorHeight + FloorHeight, 1);

        for (int i = 0; i < floorAmount; i++)
        {
            Floor floor = Instantiate(floorPrefabe, transform);
            floor.transform.Translate(0, i * FloorHeight, 0);
            floor.name = "Floor " + i;


            if(i == 0)
            {
                floor.SetFinishAllSegment();
            }

            if (i > 0 && i < floorAmount - 1) 
            {
                floor.SetRandomRotation();
                floor.AddEmptySegment(AmountEmptySegment);
                floor.AddRandomTrapSegment(Random.Range(minTrapSegment, maxTrapSegment + 1));
            }

            if (i == floorAmount - 1)
            {
                floor.AddEmptySegment(AmountEmptySegment);
                lastFoorY = floor.transform.position.y;
            }

            

        }
    }

    private void DestroyChild()
    {
        for (int i = 0; i < transform.childCount; i++)
        {
            if (transform.GetChild(i) == axis) continue;
            Destroy(transform.GetChild(i).gameObject);
        }
    }
}
