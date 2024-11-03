using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuButton : MonoBehaviour
{
    public string targetLevelName;


    public void LoadTargetLevel()
    {
        Debug.Log("Метод LoadTargetLevel вызван"); // Добавляем сообщение для диагностики

        if (!string.IsNullOrEmpty(targetLevelName))
        {
            Debug.Log("Загрузка уровня: " + targetLevelName); // Сообщение для проверки загрузки уровня
            SceneManager.LoadScene(targetLevelName);
        }
        else
        {
            Debug.LogWarning("Целевой уровень не задан.");
        }
    }
}
