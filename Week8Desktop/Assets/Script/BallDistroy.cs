using UnityEngine;

public class BallDistroy : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Wall"))
        {
            Debug.Log("���� groundLayer �±׸� ���� ������Ʈ�� Ʈ���ŵǾ����ϴ�. ������ϴ�.");
            Destroy(gameObject);
        }
    }
}
