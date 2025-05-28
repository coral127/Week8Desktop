using UnityEngine;

public class PlayerShooting : MonoBehaviour
{
    public GameObject projectilePrefab; 
    public float projectileSpeed = 10f; 
    public Transform aimPivotTransform; 
                                        

    void Update()
    {
        
        if (Input.GetMouseButtonDown(0)) 
        {
            Shoot();
        }
    }

    void Shoot()
    {
        

        
        Vector3 spawnPosition = transform.position + aimPivotTransform.up * 0.5f ; 

       
        Vector3 fireDirection = aimPivotTransform.up; 

        
        GameObject projectile = Instantiate(projectilePrefab, spawnPosition, Quaternion.identity);

        
        Rigidbody2D rb = projectile.GetComponent<Rigidbody2D>(); 
        if (rb != null)
        {
            rb.linearVelocity = fireDirection.normalized * projectileSpeed;
        }
       
    }
}
