using UnityEngine;

public class DustTrail : MonoBehaviour
{
    [SerializeField] private ParticleSystem dustEffect;
    void Start()
    {
        if (dustEffect == null)
        {
            dustEffect = GetComponent<ParticleSystem>();
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            if (dustEffect != null)
            {
                dustEffect.Play();
            }
        }
    }

    void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            if (dustEffect != null)
            {
                dustEffect.Stop();
            }

        }
    }
}