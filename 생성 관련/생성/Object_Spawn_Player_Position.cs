using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Object_Spawn_Player_Position : MonoBehaviour
{
    [SerializeField]     /*  ������Ʈ�� �� ���� �ٸ� ����������  */
    private KeyCode fireCode = KeyCode.Z;     /*  Ŭ���� ���࿡ ���� Ű ���� : ������ = fireCode( �⺻�� = Z )  */

    [SerializeField]     /*  ������Ʈ�� �� ���� �ٸ� ����������  */
    private GameObject bulletPrefab;     /*  ������ ������Ʈ ����  */

    private Vector3 lastMoveDirection = Vector3.right;     /*  �������� �̵���ų ���� ������ ���� ����  */

    void Update()
    {
        float x = Input.GetAxisRaw("Horizontal");     /*  ������ ���� �̵�����( " D, �� " = +1  |  " A, �� " = -1 )  */
        float y = Input.GetAxisRaw("Vertical");     /*  ������ ���� �̵�����( " W, �� " = +1  |  " S, �� " = -1 )  */

        if ( x != 0 || y != 0)     /*  x �Ǵ� y�� 0�� �ƴ� ��� �����  */
        {
            lastMoveDirection = new Vector3(x, y, 0);     /*  ���������� ������ �̵������� ����  */
        }

        if ( Input.GetKeyDown( fireCode ))     /*  <fireCode>�� ������ Ű�� ���� ��� �����  */
        {
            GameObject clone = Instantiate(bulletPrefab, transform.position, Quaternion.identity);     /*  �ش� ������Ʈ�� ������ �ִ� ������Ʈ�� ��ġ�� ������ ���� : ������ �������� ������ = clone  */

            clone.name = "bullet";     /*  ������ ������( clone )�� �̸��� "bullet"���� ����  */
            clone.transform.localScale = Vector3.one * 0.5f;     /*  ������ ������( clone )�� ũ�⸦ Vector.one( (1, 1, 1) ) * 0.5�� ����  */
            clone.GetComponent<SpriteRenderer>().color = Color.red;     /*  ������ ������( clone )�� ������ ���������� ����  */

            clone.GetComponent<Movement_One_Way>().Setup(lastMoveDirection);     /*  22�� �ٿ��� ������ �̵������� �������� < Movement_One_Way >��ũ��Ʈ �� < Setup >�Լ��� �־� ��  */
        }
    }
}
