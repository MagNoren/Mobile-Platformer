using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {

    public float speed;
    public float jumpHeight;

	// Use this for initialization
	void Start ()
    {
	
	}
	
	// Update is called once per frame
	void Update ()
    {
	
	}

    void FixedUpdate()
    {
        Movement();
    }

    void Movement()
    {

        if (Input.GetAxisRaw("Horizontal") > 0.1)
        {
            GetComponent<Rigidbody2D>().AddForce(transform.forward * speed);
        }
        
        if (Input.GetAxisRaw("Horizontal") < -0.1)
        {
            GetComponent<Rigidbody2D>().AddForce(transform.forward * -speed);
        }

        if (Input.GetAxisRaw("Vertical") > 0.1)
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(GetComponent<Rigidbody2D>().velocity.x, jumpHeight);
        }

    }

}
