using UnityEngine;
using UnityEngine.UIElements;

public class ScoreManager : MonoBehaviour
{
    UIDocument score;
    Label scoreText;

    void OnEnable()
    {
        score = GetComponent<UIDocument>();
        VisualElement root = score.rootVisualElement;

        scoreText = root.Q<Label>("scoreText");
    }

    int currentScore = 0;

    public void AddScore(int amount)
    {
        currentScore += amount;
        scoreText.text = currentScore.ToString();
    }
}
