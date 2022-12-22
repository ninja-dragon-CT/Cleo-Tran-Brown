using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HUD : MonoBehaviour
{
    public Level level;
    public GameOver gameOver;

    public Text remainingText;
    public Text remainingSubtext;
    public Text targetText;
    public Text targetSubtext;
    public Text scoreText;

    public Image[] stars;

    private int starIndex;
    private bool isGameOver;

    // Start is called before the first frame update
    void Start()
    {
        UpdateStars();
    }

    public void UpdateStars()
    {
        for (int i = 0; i < stars.Length; i++)
        {
             if (i == starIndex)
            {
                stars[i].enabled = true;
            }
            else
            {
                stars[i].enabled = false;
            }
        }
    }

    public void SetScore(int score)
    {
        scoreText.text = score.ToString();

        int visibleStar = 0;

        if (score >= level.score1Star && score < level.score2Star)
        {
            visibleStar = 1;
        }
        else if (score >= level.score2Star && score < level.score3Star)
        {
            visibleStar = 2;
        }
        else if (score >= level.score3Star)
        {
            visibleStar = 3;
        }

        starIndex = visibleStar;

        UpdateStars();
    }

    public void SetTarget (int target)
    {
        targetText.text = target.ToString();
    }

    public void SetRemaining(int remaining)
    {
        remainingText.text = remaining.ToString();
    }

    public void SetRemaining(string remaining)
    {
        remainingText.text = remaining;
    }

    public void SetLevelType (Level.LevelType type)
    {
        switch (type)
        {
            case Level.LevelType.MOVES:
                remainingSubtext.text = "Moves Remaining";
                targetSubtext.text = "Target Score";
                break;
            case Level.LevelType.OBSTACLE:
                remainingSubtext.text = "Moves Remaining";
                targetSubtext.text = "Dishes Remaining";
                break;
            case Level.LevelType.TIMER:
                remainingSubtext.text = "Moves Remaining";
                targetSubtext.text = "Target Score";
                break;
        }
    }

    public void OnGameWin(int score)
    {
        gameOver.ShowWin(score, starIndex);
    }

    public void OnGameLose()
    {
        gameOver.ShowLose();
    }
}
