using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour
{
    public Rigidbody rb;
    private float moveSpeed = 6;

    // Start is called before the first frame update
    void Start()
    {
        rb.velocity = new Vector3(0, 0, moveSpeed);
        Destroy(gameObject, 3);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Enemy")
        {
            Destroy(this.gameObject);
            Destroy(other.gameObject);
        }
    }

}
