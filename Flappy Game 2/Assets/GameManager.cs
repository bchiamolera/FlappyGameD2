using UnityEngine;

public class GameManager : MonoBehaviour
{
    private void Awake()
    {
        Time.timeScale = 1.0f;
    }

    public void GameOver()
    {
        Time.timeScale = 0f;
    }
}
