using UnityEngine;

public class BallDistroy : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Wall"))
        {
            Debug.Log("공이 groundLayer 태그를 가진 오브젝트와 트리거되었습니다. 사라집니다.");
            Destroy(gameObject);
        }
    }
}
