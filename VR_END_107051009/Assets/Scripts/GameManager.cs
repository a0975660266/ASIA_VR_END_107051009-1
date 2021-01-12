using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public void RestartGame()
    {
        SceneManager.LoadScene("丟垃圾");
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
