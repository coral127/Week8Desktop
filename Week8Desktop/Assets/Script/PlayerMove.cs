using System.Collections;
using System.Collections.Concurrent;
using Unity.Hierarchy;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Timeline;

public class PlayerMove : MonoBehaviour
{

    GameObject scanObject;

    public float maxSpeed;
    public float jumpPower;
    Rigidbody2D rigid;

    void Awake()
    {
        rigid = GetComponent<Rigidbody2D>();
    }

    public void Update()
    {
        Debug.DrawRay(rigid.position, Vector2.down, new Color(0, 1, 0));       

        RaycastHit2D rayHit = Physics2D.Raycast(rigid.position, Vector2.down, 0.5f, LayerMask.GetMask("groundLayer"));
        

        if (Input.GetKeyDown(KeyCode.Space) && rayHit.collider != null)
        {
            rigid.AddForce(Vector2.up * jumpPower, ForceMode2D.Impulse);
        }
    }

    


    void FixedUpdate()
    {
       

       
        
        
        
        float h = Input.GetAxisRaw("Horizontal");

        rigid.AddForce(Vector2.right * h, ForceMode2D.Impulse);

        if(rigid.linearVelocity.x > maxSpeed) //Right max speed
        {
            rigid.linearVelocity = new Vector2(maxSpeed, rigid.linearVelocity.y); 
        }
        else if(rigid.linearVelocity.x < maxSpeed * (-1)) //Left max speed
        {
            rigid.linearVelocity = new Vector2(maxSpeed*(-1), rigid.linearVelocity.y);
        }

        

        if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
        {

            rigid.linearDamping = 5f;

        }
        else
        {
            rigid.linearDamping = 0f;
        }
    }

    
}
