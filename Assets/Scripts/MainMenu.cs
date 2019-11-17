using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class MainMenu : MonoBehaviour
{
    public void PlayGame()
    {
        StartCoroutine(WaitGameplay());
    }
    
    private IEnumerator WaitGameplay()
    {
        yield return new WaitForSeconds(0.5f);
        SceneManager.LoadScene("Gameplay");
    }
}
