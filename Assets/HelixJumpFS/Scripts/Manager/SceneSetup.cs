using UnityEngine;

public class SceneSetup : MonoBehaviour
{
    [SerializeField] private LevelGenerator levelGenerator;
    [SerializeField] private BallController ballController;
    [SerializeField] private LevelProgress levelProgress;
    [SerializeField] private ColorGenerate colorGenerate;



    

    private void Start()
    {
        
        levelGenerator.Generate(levelProgress.CurrentLevel);
        colorGenerate.GenerateColor();
        ballController.transform.position = new Vector3(ballController.transform.position.x, levelGenerator.LastFloorY, ballController.transform.position.z);   


    }
}
