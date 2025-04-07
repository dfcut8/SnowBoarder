using UnityEngine;
using UnityEngine.SceneManagement;

public class CrashDetector : MonoBehaviour
{
    [SerializeField] private float delayAfterCrash = 1f;
    [SerializeField] private ParticleSystem hitEffect;
    [SerializeField] private AudioClip crashSFX;

    private CircleCollider2D cc2d;
    private AudioSource audioSource;
    void Start()
    {
      cc2d = GetComponent<CircleCollider2D>();
      audioSource = GetComponent<AudioSource>();
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            Debug.Log("Player hit the ground!");
            var player = FindAnyObjectByType<Player>();
            player.DisableControls();
            hitEffect.Play();
            audioSource.PlayOneShot(crashSFX);
            Invoke("reloadScene", delayAfterCrash);
        }
    }

    private void reloadScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
