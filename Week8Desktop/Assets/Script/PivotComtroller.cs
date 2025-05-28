using UnityEngine;

public class AimPivotController : MonoBehaviour
{
    
    void Update()
    {
        
        Vector3 mouseScreenPosition = Input.mousePosition;
        mouseScreenPosition.z = Camera.main.WorldToScreenPoint(transform.position).z;
        Vector3 mouseWorldPosition = Camera.main.ScreenToWorldPoint(mouseScreenPosition);

        // ������ ��, ����
        Vector3 directionToMouse = mouseWorldPosition - transform.position;

        float angleRad = Mathf.Atan2(directionToMouse.y, directionToMouse.x);

        //���� -> ���� ��ȯ
        float angleDeg = (angleRad * Mathf.Rad2Deg)-90;
        transform.rotation = Quaternion.Euler(0, 0, angleDeg);

        Debug.DrawRay(transform.position, directionToMouse.normalized * 2f, Color.green);


    }
}