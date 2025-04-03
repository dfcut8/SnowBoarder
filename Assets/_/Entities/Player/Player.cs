using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] float tourque = 10f;
    private Rigidbody2D rb;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        // Get the input from the player
        float moveHorizontal = Input.GetAxis("Horizontal");
        rb.AddTorque(-moveHorizontal * tourque);
    }
}
