using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{
    public new Rigidbody2D rigidbody;
    private float speed = 100f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Left(InputAction.CallbackContext context)
    {
        if (context.started)
        {
            rigidbody.AddForce(Vector2.left * speed);
        }
    }

    public void Right(InputAction.CallbackContext context)
    {
        if (context.started)
        {
            rigidbody.AddForce(Vector2.right * speed);
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        Destroy(this.gameObject);
    }
}
