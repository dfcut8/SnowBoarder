using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] float tourque = 1f;
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
        float moveVertical = Input.GetAxis("Vertical");
        rb.AddTorque(moveHorizontal * tourque, ForceMode2D.Force);
    }
}
