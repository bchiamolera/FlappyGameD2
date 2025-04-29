using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject button;

    private void Awake()
    {
        Time.timeScale = 1.0f;
    }

    public void GameOver()
    {
        Time.timeScale = 0f;
        button.SetActive(true);
    }

    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
