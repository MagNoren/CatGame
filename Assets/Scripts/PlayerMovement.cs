using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {

    public int speed;
    public int jumpHeight;

    public Transform groundCheck;
    public float groundCheckRadius;
    public LayerMask whatIsGround;
    private bool grounded;
	
	// Update is called once per frame
	void Update () {
        Movement();
	}

    void FixedUpdate()
    {
        grounded = Physics2D.OverlapCircle(groundCheck.position, groundCheckRadius, whatIsGround);
    }

    void Movement()
    {
        //Right on D
        if(Input.GetKey (KeyCode.D))
        {
            transform.Translate(Vector2.right * speed * Time.deltaTime);
            transform.eulerAngles = new Vector2(0, 0);
        }
        //Left on A
        if (Input.GetKey (KeyCode.A))
        {
            transform.Translate(Vector2.right * speed * Time.deltaTime);
            transform.eulerAngles = new Vector2(0, 180);
        }
        //Jump on W
        if (Input.GetKeyDown(KeyCode.W) && grounded)
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(GetComponent<Rigidbody2D>().velocity.x, jumpHeight);
        }
    }
}
