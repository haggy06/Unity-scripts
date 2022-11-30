using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement_One_Way : MonoBehaviour
{
    [SerializeField]     /*  ������Ʈ�� �� ���� �ٸ� ����������  */
    private float moveSpeed = 5.0f;     /*  ������ �ӵ� ����  */

    private Vector3 moveDirection;     /*  ������ �������� ���� ����  */

    public void Setup(Vector3 direction)     /*  �ٸ� ��ũ��Ʈ���� < moveDirection >�� ���� �޾ƿ��� Ŭ����  */
    {
        moveDirection = direction;     /*  �ٸ� ��ũ��Ʈ���� ������ ���Ⱚ�� < moveDirection >�� �־���  */
    }

    private void Update()
    {
        transform.position += moveDirection * moveSpeed * Time.deltaTime;     /*  ������ġ = ������ġ + �̵�����( moveDirection ) * �̵��ӵ�( moveSpeed ) * ��ǻ�� ����ӵ�( Time.deltaTime )  */
    }                                                                           /*  Time.deltaTime : ��ǻ�� ����ӵ��� �������� �����Ӽ��� ���� ������ �̵��Ÿ��� �����ϴµ�, �̸� ���� ���� �����ִ� ���̴�. */
}
