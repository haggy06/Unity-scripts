using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moving_With_Gravity_Strength : MonoBehaviour
{
    [SerializeField]     /*  ������Ʈ�� �� ���� �ٸ� ����������  */
    private float speed = 5.0f;     /*  float ������ speed ���� ����( �⺻�� = 5 )  */

    [SerializeField]     /*  ������Ʈ�� �� ���� �ٸ� ����������  */
    private float jumpPower = 13.0f;     /*  float ������ jumpPower ���� ����( �⺻�� = 13 )  */

    private Rigidbody2D rigid2D;     /*  rigidbody2D ������ ���� ����  */

    private void Awake()
    {
        rigid2D = GetComponent<Rigidbody2D>();     /*  �� ������Ʈ�� �������� �ҷ���  */
    }

    private void Update()
    {
        float x = Input.GetAxisRaw("Horizontal");     /*  ������ ���� �̵�����( " D, �� " = +1  |  " A, �� " = -1 )  */

        rigid2D.velocity = new Vector2(x * speed, rigid2D.velocity.y);     /*  ������ ���Ŀ� x�� �̵�����ŭ �� �̵�( y���� �������� ��갪 )  */

        if (Input.GetKeyDown(KeyCode.Space)) rigid2D.velocity = Vector2.up * jumpPower;     /*  �����̽��ٸ� ���� �� �� jump�� true�� �� �� jumpPower����ŭ ���� �̵�( ���������� ���� ������ �ӵ��� �پ�� )  */

        if (Input.GetKeyUp(KeyCode.Space)) if (rigid2D.velocity.y > 1.0f) rigid2D.velocity = Vector2.up * 1.0f;     /*  �����̽��ٿ��� ���� �� �� �� y�� �ӵ��� 1 �̻��� �� �� y�� �̵��ӵ��� 1�� �ٲ�  */
    }
}
