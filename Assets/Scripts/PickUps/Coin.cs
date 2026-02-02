using UnityEngine;

public class Coin : PickUp
{
    [SerializeField] int coinValue = 100;
    ScoreManager scoreManager;

    public void Init(ScoreManager scoreManager)
    {
        this.scoreManager = scoreManager;
    }

    protected override void OnPickUp()
    {
        scoreManager.AddScore(coinValue);
    }
}
