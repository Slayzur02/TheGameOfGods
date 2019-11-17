using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
public class PauseMenu : MonoBehaviour
{
    public static bool GameIsPaused = false;
    public GameObject pauseMenuUI;
    public GameObject deathScreen;
    public TextMeshProUGUI highScore;
    public TextMeshProUGUI Score;
    public TextMeshProUGUI displayScore;
    public Animator deathMenuAnim;
    // Update is called once per frame
    public void SettingsInGame()
    {
            if (GameIsPaused)
            {
                Resume();
            }
            else
            {
                Pause();
            }
    }
    public void Resume()
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        StartCoroutine(waitForBugs());
        
    }
    void Pause()
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
    }
    public void LoadMenu()
    {
        // ScenceManager.LoadScence("Menu");
    }
    public void QuitMenu()
    {   
        Time.timeScale=1f;
        GameIsPaused = false;
        SceneManager.LoadScene("StartMenu");
    }

    public void Replay()
    {
        SceneManager.LoadScene("Gameplay");
    }
    public void showDeathScreen()
    {
        StartCoroutine(waitForDeathScreen());

    }
    private IEnumerator waitForBugs()
    {
        yield return new WaitForSeconds(0.05f);
        GameIsPaused = false;
    }

    private IEnumerator waitForDeathScreen()
    {
        yield return new WaitForSeconds(0.3f);
        deathScreen.SetActive(true);
        deathMenuAnim.Play("DeathScreen");
        Score.text = displayScore.text;
        highScore.text = PlayerPrefs.GetInt("HighScore",0).ToString();
    }
}
