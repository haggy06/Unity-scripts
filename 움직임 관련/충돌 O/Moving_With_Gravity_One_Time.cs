using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moving_With_Gravity_One_Time : MonoBehaviour
{
    [SerializeField]     /*  ������Ʈ�� �� ���� �ٸ� ����������  */
    private float speed = 5.0f;

    [SerializeField]     /*  ������Ʈ�� �� ���� �ٸ� ����������  */
    private float jumpPower = 13.0f;     /*  �����Ŀ� ����  */

    private Rigidbody2D rigid2D;     /*  �� ������Ʈ�� ���������� ������ ����  */

    [SerializeField]     /*  ������Ʈ�� �� ���� �ٸ� ����������  */
    private LayerMask groundLayer;     /*  ���� ������ �� ���̾ ���� ����  */

    private CircleCollider2D circleCollider2D;     /*  �� ������Ʈ�� Collider2D�� ������ ����( ��ũ��Ʈ�� ���� ������Ʈ�� �´� Collider2D�� �����ؾ� ��  )  */

    private bool isGround;     /*  ���� ���� ����ִ����� �˻��ϴ� ����  */

    private Vector3 footPosition;     /*  ���� ��ġ�� ������ ����  */

    private void Awake()
    {
        rigid2D = GetComponent<Rigidbody2D>();     /*  �� ������Ʈ�� Rigidbody2D�� ������  */
        circleCollider2D = GetComponent<CircleCollider2D>();     /*  �� ������Ʈ�� Collider2D�� ������  */
    }

    private void FixedUpdate()     /*  ��� Update�Լ��� �۵��� �� �۵��ϴ� �Լ�  */
    {
        Bounds bounds = circleCollider2D.bounds;     /*  �� ������Ʈ�� Collider�� bounds��( Collider2D.Bounds = Collider2D�� x��� y���� �ִ�, �ּ�, �߰����� ����Ǿ��ִ� �� )�� ������  */
                                                                          /*  �� �� ������Ʈ�� �´� collider2D�� �ٲٴ� �� ���� ����!!! ��  */

        footPosition = new Vector2(bounds.center.x, bounds.min.y);     /*  �� ������Ʈ�� �浹����( Collider2D )�� ( x�� ( ������� ), y�� ( �� ���� �� ) )��ġ�� footPosition�� ����  */

        isGround = Physics2D.OverlapCircle(footPosition, 0.1f, groundLayer);     /*  footPosition�� ������ 0.1ũ���� ���� ������, groundLayer�� �Ҽӵ� ������Ʈ�� ���� ��� true��, �ƴ� ��� false�� ����  */
    }                                                                                                           /*  �� ���� Scene View������ ������ �ʱ� ������ <OnDrawGizmos>�Լ��� �̿��� ���� ��ġ�� ������ �׷��� �Ѵ�( ���� �� ���� ).  */

    private void Update()
    {
        float x = Input.GetAxisRaw("Horizontal");     /*  ������ ���� �̵�����( " D, �� " = +1  |  " A, �� " = -1 )  */

        rigid2D.velocity = new Vector2(x * speed, rigid2D.velocity.y);     /*  ������ ���Ŀ� x�� �̵�����ŭ �� �̵�( y���� �������� ��갪 )  */

        if (Input.GetKeyDown(KeyCode.Space)) if (isGround == true) rigid2D.velocity = Vector2.up * jumpPower;     /*  �����̽��ٸ� ���� �� �� jump�� true�� �� �� jumpPower����ŭ ���� �̵�( ���������� ���� ������ �ӵ��� �پ�� )  */
        if (Input.GetKeyUp(KeyCode.Space)) if (rigid2D.velocity.y > 1.0f) rigid2D.velocity = Vector2.up * 1.0f;     /*  �����̽��ٿ��� ���� �� �� �� y�� �ӵ��� 1 �̻��� �� �� y�� �̵��ӵ��� 1�� �ٲ�  */
    }
}
