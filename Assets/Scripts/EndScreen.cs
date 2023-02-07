using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndScreen : MonoBehaviour
{
    public void RestartGame() {
        SceneManager.LoadScene("Level 1");
    }

    public void ExitButton() {
        Application.Quit();
        Debug.Log("Game Closed.");
    }
}
