using UnityEngine;
using UnityEngine.UI;


public class ColorGenerate : MonoBehaviour
{
    [Header ("Colorway")]
    [SerializeField] private Material axis;
    [SerializeField] private Material ball;
    [SerializeField] private Camera highCol;
    [SerializeField] private Material segmentFinish;
    [SerializeField] private Material segmentTrap;
    [SerializeField] private Image lowCol;
    [SerializeField] private Material segmentDefault;
    



    public void GenerateColor()
    {
        int rand = UnityEngine.Random.Range(0, 3);
        switch (rand)
        {
            case 0:
                axis.color = new Color(255.0f / 255f, 255.0f / 255f, 255.0f / 255f); 
                ball.color = new Color(76.0f / 255f, 207.0f / 255f, 50.0f / 255f);   
                lowCol.color = new Color(43.0f / 255f, 178.0f / 255f, 174.0f / 255f); 
                highCol.backgroundColor = new Color(255.0f / 255f, 244.0f / 255f, 214.0f / 255f); 
                segmentFinish.color = new Color(92.0f / 255f, 97.0f / 255f, 192.0f / 255f); 
                segmentTrap.color = new Color(190.0f / 255f, 49.0f / 255f, 49.0f / 255f); 
                segmentDefault.color = new Color(82.0f / 255f, 81.0f / 255f, 81.0f / 255f); 

                break;
            case 1:
                axis.color = new Color(233f / 255f, 210f / 255f, 63f / 255f);
                ball.color = new Color(49f / 255f, 76f / 255f, 204f / 255f);
                lowCol.color = new Color(115f / 255f, 120f / 255f, 224f / 255f);
                highCol.backgroundColor = new Color(204f / 255f, 150f / 255f, 150f / 255f);
                segmentFinish.color = new Color(120f / 255f, 24f / 255f, 106f / 255f);
                segmentTrap.color = new Color(229f / 255f, 109f / 255f, 135f / 255f);
                segmentDefault.color = new Color(233f / 255f, 224f / 255f, 72f / 255f);
                break;
            case 2:
                axis.color = new Color(151f / 255f, 0f, 188f / 255f);
                ball.color = new Color(238f / 255f, 143f / 255f, 91f / 255f);
                lowCol.color = new Color(178f / 255f, 52f / 255f, 43f / 255f);
                highCol.backgroundColor = new Color(39f / 255f, 156f / 255f, 161f / 255f);
                segmentFinish.color = new Color(26f / 255f, 120f / 255f, 24f / 255f);
                segmentTrap.color = new Color(229f / 255f, 207f / 255f, 38f / 255f);
                segmentDefault.color = new Color(93f / 255f, 87f / 255f, 168f / 255f);
                break;


            default:
                break;
        }
    }
    
}
