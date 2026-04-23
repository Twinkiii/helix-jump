using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIScoreText : BallEvents
{
    [SerializeField] private ScoreCollectors scoreCollector;
    [SerializeField] private Text scoreText;
    [SerializeField] private Text scoreMaxText;
    

    private void Start()
    {
        scoreMaxText.text = "Рекорд: " + scoreCollector.MaxScore.ToString();
    }

    protected override void OnBallCollisionSegment(SegmentType type)
    {
        if(type != SegmentType.Trap)
        {
            scoreText.text = scoreCollector.Scores.ToString();
            

        }

        if (type == SegmentType.Finish)
        {
            scoreMaxText.text = "Рекорд: " + scoreCollector.MaxScore.ToString();
        }
    }
}
