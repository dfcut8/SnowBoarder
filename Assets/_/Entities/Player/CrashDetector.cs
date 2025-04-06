using UnityEngine;
using UnityEngine.SceneManagement;

public class CrashDetector : MonoBehaviour
{
    [SerializeField] private float delayAfterCrash = 1f;
    CircleCollider2D cc2d;
    void Start()
    {
      cc2d = GetComponent<CircleCollider2D>();
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            Debug.Log("Player hit the ground!");
            Invoke("reloadScene", delayAfterCrash);
        }
    }

    private void reloadScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
