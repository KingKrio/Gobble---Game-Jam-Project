using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    // Method to load the first game scene
    public void PlayGame()
    {
        SceneManager.LoadScene("GameScene"); // Replace "Scene1" with your scene name
    }

    // Method to load the second game scene
    public void Instructions()
    {
        SceneManager.LoadScene("Instructions"); // Replace "Scene2" with your scene name
    }

    // Method to quit the game
    public void QuitGame()
    {
        Debug.Log("Quit Game"); // Log for testing in the editor
        Application.Quit(); // Quits the application
    }
}
