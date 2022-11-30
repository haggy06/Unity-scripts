using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Object_Destroy_Out_Of_Area : MonoBehaviour
{
    [SerializeField]     /*  ������Ʈ�� �� ���� �ٸ� ����������  */
    private Vector2 limit_Min = new Vector2(-10.2f, -5.5f);     /*  ���� ���� ��ġ�� �ּڰ� ����  */

    [SerializeField]     /*  ������Ʈ�� �� ���� �ٸ� ����������  */
    private Vector2 limit_Max = new Vector2(10.2f, 5.5f);     /*  ���� ���� ��ġ�� �ִ� ����  */

    private void Update()
    {
        if (transform.position.x < limit_Min.x || transform.position.x > limit_Max.x ||transform.position.y < limit_Min.y || transform.position.y > limit_Max.y) Destroy(gameObject);     /*  ���� ��ġ�� �ּڰ����� �۰ų� �ִ񰪺��� ������ �� ������Ʈ ����  */
    }
}
