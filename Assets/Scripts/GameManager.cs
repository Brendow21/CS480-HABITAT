using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManagerVR : MonoBehaviour
{
    public void RestartGame()
    {
        SceneManager.LoadScene("Scene 1"); // Reloads current scene
    }

    public void QuitGame()
    {
        Debug.Log("Game is quitting...");
        Application.Quit(); // Works in a built app
    }
}
