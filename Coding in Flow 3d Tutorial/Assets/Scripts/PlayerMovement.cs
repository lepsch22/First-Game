using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // Start is called before the first frame update

    Rigidbody rb;//physics/movement
    [SerializeField] float movementMultiplier;
    [SerializeField]float jumpForce;
    void Start()
    {
        Debug.Log("Hello from Start");
        rb = GetComponent<Rigidbody>();
        movementMultiplier = 4f;
        jumpForce = 6f;
    }

    // Update is called once per frame
    void Update()
    {
        float horizaontalIn = Input.GetAxis("Horizontal");
        float verticalin = Input.GetAxis("Vertical");

        rb.velocity = new Vector3(horizaontalIn * movementMultiplier, rb.velocity.y, verticalin * movementMultiplier);

        if (Input.GetButtonDown("Jump")) 
        {
            rb.velocity = new Vector3(rb.velocity.x, jumpForce, rb.velocity.z);
        }
        

    }
}
