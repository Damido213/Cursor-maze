using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;

public class CursorFollower : MonoBehaviour
{
    public GameObject CursorHitBox;
    public Camera mainCamera;
    public Vector2 startPosition;

    private void Start()
    {
        startPosition = new Vector2(-0.83f, -4.5f);
        CursorHitBox.transform.position = startPosition;
    }

    private void Update()
    {

        Vector2 mousePosition = Mouse.current.position.ReadValue();


        Vector3 worldPosition = mainCamera.ScreenToWorldPoint(new Vector3(mousePosition.x, mousePosition.y, mainCamera.nearClipPlane));
        worldPosition.z = 0;  


        CursorHitBox.transform.position = worldPosition;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Checkpoint"))
        {
            SceneManager.UnloadSceneAsync("Level1");
            SceneManager.LoadSceneAsync("Level2");
        }
        if (collision.gameObject.CompareTag("Jumpscare"))
        {
            SceneManager.UnloadSceneAsync("Level2");
            SceneManager.LoadSceneAsync("Jumpscare");
        }
        if (collision.gameObject.CompareTag("Wall1"))
        {
            Debug.Log("Курсор столкнулся со стеной, возвращаем на стартовую позицию.");
            SceneManager.UnloadSceneAsync("Level1");
            SceneManager.LoadSceneAsync("Menu");
        }
        if (collision.gameObject.CompareTag("Wall2"))
        {
            Debug.Log("Курсор столкнулся со стеной, возвращаем на стартовую позицию.");
            SceneManager.UnloadSceneAsync("Level2");
            SceneManager.LoadSceneAsync("Menu");
        }
    }
}
