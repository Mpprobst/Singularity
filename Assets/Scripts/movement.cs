using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    private Rigidbody rb;
    public float speed = 3f;
    public float jump_force = 10f;
    public float grav = 1.5f;
    public float ground_distance = 2f;


    // Start is called before the first frame update
    void Start()
    {
        Cursor.visible = false;
        rb = GetComponent<Rigidbody>();

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Jump") && Physics.Raycast(transform.position, Vector3.down, out RaycastHit grounded, ground_distance))
        {
            rb.velocity = Vector3.up * jump_force;
        }
        //Falling
        if (rb.velocity.y < 0) //if the character is falling
        {
            rb.velocity += Vector3.up * Physics.gravity.y * grav * Time.deltaTime;

        }
        //Walking
        float xmove = Input.GetAxisRaw("Horizontal");
        float zmove = Input.GetAxisRaw("Vertical");

        Vector3 moveH = rb.transform.right * xmove;
        Vector3 moveV = rb.transform.forward * zmove;

        Vector3 velocity = (moveH + moveV).normalized * speed;

        if (velocity != Vector3.zero)
        {
            rb.MovePosition(rb.position + velocity * Time.deltaTime);
        }


    }
}
