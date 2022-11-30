using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moving_Zero_Gravity : MonoBehaviour
{

    private float MoveSpeed = 5.0f;     /*  �������� �ӵ�����  */

    private Rigidbody2D rigid2D;

    void Awake()     /*  ���� ���۵� �� 1ȸ ����  */
    {
        rigid2D = GetComponent<Rigidbody2D>();     /*  "Rigidbody2D" ������Ʈ ���� ������  */
    }

    void Update()     /*  ���� �� �����Ӹ��� ����  */
    {
        float x = Input.GetAxisRaw( "Horizontal" );     /*  ������ ���� �̵�����( " D, �� " = +1  |  " A, �� " = -1 )  */
        float y = Input.GetAxisRaw( "Vertical" );     /*  ������ ���� �̵�����( " W, �� " = +1  |  " S, �� " = -1 )  */

        rigid2D.velocity = new Vector3(x, y, 0) * MoveSpeed;     /*  ���� x, y���� ���� ��ġ�̵�( �������� �켱�� )  */
    }
}