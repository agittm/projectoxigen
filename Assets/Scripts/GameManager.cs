using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    [SerializeField] Text textScore;

    private int score = 0;

    private void OnEnable()
    {
        Scoring.OnAddScore += HandleOnScoreAdd;
    }

    private void HandleOnScoreAdd()
    {
        score++;
        textScore.text = score.ToString();
    }
}
