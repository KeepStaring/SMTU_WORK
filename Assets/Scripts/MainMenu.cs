using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void ReloadScene() => SceneManager.LoadScene(SceneManager.GetActiveScene().name);

    public void QuitApplication() => Application.Quit();
}
