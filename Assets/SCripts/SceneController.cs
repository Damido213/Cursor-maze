using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    public MenuButton menuButton; 
    private string activeSceneName = "Menu";
    private string[] allSceneNames = { "Menu", "Level1", "Level2", "Jumpscare" };

    void Start()
    {
        menuButton = FindObjectOfType<MenuButton>();

       if (menuButton != null)
       {
           menuButton.targetLevelName = "Level1";
       }


        foreach (string sceneName in allSceneNames)
        {
            if (sceneName != activeSceneName && SceneManager.GetSceneByName(sceneName).isLoaded)
            {
                SceneManager.UnloadSceneAsync(sceneName);
            }
        }

        if (!SceneManager.GetSceneByName(activeSceneName).isLoaded)
        {
            SceneManager.LoadSceneAsync(activeSceneName, LoadSceneMode.Additive);
        }
    }
}
