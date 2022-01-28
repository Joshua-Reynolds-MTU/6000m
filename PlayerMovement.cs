using UnityEngine;
public class PlayerMovement : MonoBehaviour
{

    public Rigidbody rb;

    public float forwardForce = 2000f;
    public float sidewaysForce = 500f;

    private float screenWidth;


    void FixedUpdate()
    {

        float moveHorizontal = Input.GetAxisRaw("Horizontal");

        Vector3 movement = new Vector3(moveHorizontal, 0, 0);

        rb.AddForce(movement * sidewaysForce);

        if (rb.position.y < -1f)
        {
            FindObjectOfType<GameManager>().EndGame();
        }
    }

    void Start()
    {
        screenWidth = Screen.width;
    }

    void Update()
    {
        int i = 0;
        while(i < Input.touchCount)
        {
            if (Input.GetTouch (i).position.x > screenWidth / 2)
            {
                runCharacter (1.0f);
            }
            if (Input.GetTouch(i).position.x < screenWidth / 2)
            {
                runCharacter (-1.0f);
            }
        }
    }

    private void runCharacter(float horizontalInput)
    {
        rb.AddForce(new Vector3(horizontalInput * sidewaysForce * Time.deltaTime, 0, 0));
    }
}