using UnityEngine;


public enum SegmentType
{
    Default,
    Trap,
    Empty,
    Finish
}

public class Segment : MonoBehaviour
{
    
    [SerializeField] private Material trapMaterial;
    [SerializeField] private Material finishMaterial;

    [SerializeField] private SegmentType type;

    public SegmentType Type => type;

    private MeshRenderer MeshRenderer;

    private void Awake()
    {
        MeshRenderer = GetComponent<MeshRenderer>();
    }

    public void SetTrap()
    {
        MeshRenderer.enabled = true;
        MeshRenderer.material = trapMaterial;

        type = SegmentType.Trap;
    }
    public void SetEmpty()
    {
        MeshRenderer.enabled = false;

        type = SegmentType.Empty;
    }
    public void SetFinish()
    {
        MeshRenderer.enabled = true;
        MeshRenderer.material = finishMaterial;

        type = SegmentType.Finish;
    }
    
}
