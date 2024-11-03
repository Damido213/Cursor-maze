using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuButton : MonoBehaviour
{
    public string targetLevelName;


    public void LoadTargetLevel()
    {
        Debug.Log("����� LoadTargetLevel ������"); // ��������� ��������� ��� �����������

        if (!string.IsNullOrEmpty(targetLevelName))
        {
            Debug.Log("�������� ������: " + targetLevelName); // ��������� ��� �������� �������� ������
            SceneManager.LoadScene(targetLevelName);
        }
        else
        {
            Debug.LogWarning("������� ������� �� �����.");
        }
    }
}
