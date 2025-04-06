using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishLine : MonoBehaviour
{
    [SerializeField] private float delayAfterFinishLine = 2f;
    [SerializeField] private ParticleSystem finishEffect;

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Debug.Log("Player has crossed the finish line!");
            finishEffect.Play();
            Invoke("reloadScene", delayAfterFinishLine);
        }
    }

    private void reloadScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
