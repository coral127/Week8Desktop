using UnityEngine;

public class Shoot : MonoBehaviour
{
    public GameObject ball;
    public float ballSpeed = 50f;
    public Transform aimTransform;


    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            shoot();
        }

    }
    void shoot()
    {
        
        Vector2 ballSpwan = transform.position + aimTransform.forward*1f;
        Vector2 fireDirection = aimTransform.forward;
         
        GameObject Ball = Instantiate(ball, ballSpwan, Quaternion.identity);
        
        Rigidbody2D clone = Ball.GetComponent<Rigidbody2D>();
        clone.linearVelocity = fireDirection.normalized.normalized * ballSpeed;
        
        
    }

   
   
}
