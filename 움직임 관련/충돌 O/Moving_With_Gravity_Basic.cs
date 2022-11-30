using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moving_With_Gravity_Basic : MonoBehaviour
{
    [SerializeField]     /*  ������Ʈ�� �� ���� �ٸ� ����������  */
    private float speed = 5.0f;     /*  �̵��ӵ� ����  */

    [SerializeField]     /*  ������Ʈ�� �� ���� �ٸ� ����������  */
    private float jumpPower = 8.0f;     /*  ���� ���� ����  */
    
    private Rigidbody2D rigid2D;     /*  <Rigidbody2D>������ ���� ����  */

    private void Awake()
    {
        rigid2D = GetComponent<Rigidbody2D>();     /*  �� ������Ʈ�� �������� �ҷ���  */
    }

    private void Update()
    {
        float x = Input.GetAxisRaw("Horizontal");     /*  ������ ���� �̵�����( " D, �� " = +1  |  " A, �� " = -1 )  */

        Move(x);     /*  ������ ���Ŀ� x�� �̵������� �ؿ� �ִ� Move�Լ� ����  */
        if (Input.GetKeyDown(KeyCode.Space)) Jump();     /*  �����̽��ٸ� ���� �� �ؿ� �ִ� Jump�Լ� ����  */
    }

    public void Move( float x)     /*  float ������ �����͸� �Է¹޴� <Move>�Լ�  */
    {
        rigid2D.velocity = new Vector2(x * speed, rigid2D.velocity.y);     /*  x��ǥ  = �Է¹��� ������ * speed, y��ǥ = �������� ��갪  */
    }
    
    public void Jump()     /*  �ƹ� �����͵� �Է¹��� �ʴ� <Jump> �Լ�  */
    {
        rigid2D.velocity = Vector2.up * jumpPower;     /*  jumpPower����ŭ ���� �̵�( ���������� ���� ������ �ӵ��� �پ�� )  */
    }
}
