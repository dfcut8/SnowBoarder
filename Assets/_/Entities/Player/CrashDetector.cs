using UnityEngine;

public class CrashDetector : MonoBehaviour
{
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
        }
    }
}
