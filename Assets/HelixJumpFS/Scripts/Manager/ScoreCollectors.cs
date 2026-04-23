using UnityEngine;


public class ScoreCollectors : BallEvents
{
    [SerializeField] private LevelProgress levelProgress;

    [SerializeField] private int scores;
    
    private int coefficient = 0;

    public int Scores => scores;
    private int maxScore;
    public int MaxScore => maxScore;
    
  

    protected override void Awake()
    {
        base.Awake();
        LoadMaxScore();


    }

    public void UpdateMaxScore()
    {
        maxScore = scores;
        PlayerPrefs.SetInt("LevelProgress:MaxScore", maxScore);
        PlayerPrefs.Save(); 
    }

    private void LoadMaxScore()
    {
        maxScore = PlayerPrefs.GetInt("LevelProgress:MaxScore", 0);
    }


    protected override void OnBallCollisionSegment(SegmentType type)
    {
        if (type == SegmentType.Empty)
        {

            coefficient += 1 ;

        }
        else {
            if (coefficient == 1) { scores += levelProgress.CurrentLevel * coefficient; }
            else { scores += levelProgress.CurrentLevel * coefficient * 2; }
            coefficient = 0;
        }

        if (type == SegmentType.Finish)
        {
            {
                if (scores > maxScore)
                {
                    UpdateMaxScore();
                }
            }
        }

    }
}
