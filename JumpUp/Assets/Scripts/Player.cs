using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor.SceneManagement;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Rigidbody2D rb;
    public float moveX,moveY;
    public float jumpForce;
    public float speed;
    public bool isGround;

    // Start is called before the first frame update
    void Start()
    {
        rb= GetComponent<Rigidbody2D>();
        if(rb == null )
        {
            rb.AddComponent<Rigidbody2D>();
        }
    }

    // Update is called once per frame
    void Update()
    {
        moveX = Input.GetAxis("Horizontal");
        moveY = Input.GetAxis("Vertical");
        Vector2 direction = new Vector2(moveX, moveY);
        
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Jump();
            rb.AddForce(new Vector2(0, moveY) * jumpForce * Time.deltaTime, ForceMode2D.Impulse);
        }
    }
    private void Jump()
    {
        
    }
}
