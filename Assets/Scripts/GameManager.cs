using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class GameManager : MonoBehaviour
{
    //public static GameManager Instance;

    public Rotator rotator;
    public PinSpawner pinSpawner;
    public Animator animator;
    public TextMeshProUGUI scoreText;

    public int score;

    private bool gameIsEnded = false;
    //private void Awake()
    //{
    //    if (Instance == null)
    //    {
    //        Instance = this;
    //        DontDestroyOnLoad(gameObject);
    //    }
    //    else
    //    {
    //        Destroy(gameObject);
    //    }
    //}
    public void EndGame()
    {
        if (gameIsEnded) return;
        {
            rotator.enabled = false;
            pinSpawner.enabled = false;

            animator.SetTrigger("EndGame");
            Invoke("RestartLevel", 0.7f);

            gameIsEnded = true;
        }       
    }

    public void RestartLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void IncreaseScore()
    {
        score += 1;
        scoreText.text = score.ToString();
    }
}
