using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] float tourque = 10f;
    [SerializeField] float boostSpeed = 30f;
    [SerializeField] float baseSpeed = 10f;
    private Rigidbody2D rb;
    private SurfaceEffector2D surfaceEffector2D;
    private bool isControlsEnabled = true;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        surfaceEffector2D = FindAnyObjectByType<SurfaceEffector2D>();
    }

    void Update()
    {
        if (isControlsEnabled)
        {
            float moveHorizontal = Input.GetAxis("Horizontal");
            rb.AddTorque(-moveHorizontal * tourque);
            responseToBoost();
        }
    }

    public void DisableControls()
    {
        isControlsEnabled = false;
    }

    private void responseToBoost()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            surfaceEffector2D.speed = boostSpeed;
        }
        else
        {
            surfaceEffector2D.speed = baseSpeed;
        }
    }
}
