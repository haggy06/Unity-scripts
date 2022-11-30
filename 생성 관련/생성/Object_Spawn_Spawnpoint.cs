using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Object_Spawn_Spawnpoint : MonoBehaviour
{
    [SerializeField]     /*  ������Ʈ�� �� ���� �ٸ� ����������  */
    private int count = 15;     /*  ���� Ƚ�� ����  */

    [SerializeField]     /*  ������Ʈ�� �� ���� �ٸ� ����������  */
    private GameObject[] prefabArray;     /*  �����յ��� ���� �迭  */

    [SerializeField]     /*  ������Ʈ�� �� ���� �ٸ� ����������  */
    private Transform[] spawnpointArray;     /*  <Transform>�����͵��� ���� �迭  */

    private void Awake()
    {
        for ( int i = 0; i < count; i++)     /*  count( ���� Ƚ�� )��ŭ �ݺ�  */
        {
            int prefabIndex = Random.Range(0, prefabArray.Length);     /*  ������ ������ �迭��ȣ ����  */
            int spawnIndex = Random.Range(0, spawnpointArray.Length);     /*  ������ ��ǥ �迭��ȣ ����  */

            Vector3 position = spawnpointArray[spawnIndex].position;     /*  21�� �ٿ��� ������ <Transform>�����Ϳ��� ��ġ���� ����  */

            GameObject clone = Instantiate(prefabArray[prefabIndex], position, Quaternion.identity);     /*  ������ ������Ʈ( 20�� �� )�� Ư�� ����Ʈ( 23�� �� )�� ����  */

            Vector3 moveDirection = (spawnIndex == 0 ? Vector3.right : Vector3.left);     /*  " ? " = ���׿����� : ( A ? B : C )���� A�� ���� ��� B��, A�� ������ ��� C�� ��ȯ��  */
            clone.GetComponent<Movement_One_Way>().Setup(moveDirection);     /*  27�� �ٿ��� ������ �̵������� �������� < Movement_One_Way >��ũ��Ʈ �� < Setup >�Լ��� �־� ��  */
        }
    }
}