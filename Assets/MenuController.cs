using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    // Call this from the "Start" button in Main Menu
    public void LoadGame()
    {
        SceneManager.LoadScene("GameScene");
    }

    // Call this from the "Back to Menu" button in Game Over
    public void LoadMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

    // Call this for your "Play Again" button
    public void ReloadCurrent()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("Exiting Game...");
    }
}