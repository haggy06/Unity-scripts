using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Object_Spawn_Basic : MonoBehaviour
{
    [SerializeField]     /*  ������Ʈ�� �� ���� �ٸ� ����������  */
    private GameObject Input_Prefab;     /*  ������ ������ ����  */

    [SerializeField]     /*  ������Ʈ�� �� ���� �ٸ� ����������  */
    private Vector3 vector;     /*  ��ġ ���氪 ( 23�� �ٿ� ���� )  */

    [SerializeField]     /*  ������Ʈ�� �� ���� �ٸ� ����������  */
    private Quaternion quaternion;     /*  ȸ�� ���氪 ( 23�� �ٿ� ���� )  */

    private void Awake()     /*  ���� ������ �� 1ȸ ����  */
    {
        vector += transform.position;

        Instantiate(Input_Prefab);     /*  ������ �������� �״�� ����  */

        Instantiate(Input_Prefab, new Vector3(2, 3, 0), Quaternion.identity);     /*  �������� ��ġ�� �ٲ㼭 ����  */

        Quaternion rotation = Quaternion.Euler(0, 0, 45);     /*  ������ ���� ����  */
        Instantiate(Input_Prefab, new Vector3(-2, 3, 0), rotation);     /*  �������� ��ġ �� ������ �ٲ㼭 ����  */

        Instantiate(Input_Prefab, vector, quaternion);     /*   "�� ��ũ��Ʈ�� ���� ������Ʈ�� ��ġ + ������ ������ ��ġ ���氪" ���� �̵�, ������ ������ ������ŭ ȸ��  */
    }
}