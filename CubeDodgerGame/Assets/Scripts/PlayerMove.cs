using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public Rigidbody rb;

    public float fowardF = 2000f;
    public float sideF = 500f;
    // Update is called once per frame
    void FixedUpdate()
    {
        rb.AddForce(0, 0, fowardF * Time.deltaTime);

        if (Input.GetKey("d"))
        {
            rb.AddForce(sideF * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (Input.GetKey("a"))
        {
            rb.AddForce(-sideF * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (rb.position.y < -1.5f)
        {
            FindObjectOfType<GameManager>().GameOver();
        }
    }
}
