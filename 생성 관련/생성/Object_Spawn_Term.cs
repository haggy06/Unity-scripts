using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Object_Spawn_Term : MonoBehaviour
{
    [SerializeField]     /*  ������Ʈ�� �� ���� �ٸ� ����������  */
    private int count = 15;     /*  ����Ƚ�� ����( �⺻�� = 15 )  */

    [SerializeField]     /*  ������Ʈ�� �� ���� �ٸ� ����������  */
    private GameObject[] prefabArray;     /*  ������ �����յ��� ���� �迭  */

    [SerializeField]     /*  ������Ʈ�� �� ���� �ٸ� ����������  */
    private Transform[] spawnpointArray;     /*  ������ ������ġ�� �� ��ġ ������Ʈ�� ���� �迭( ������Ʈ° ���� )  */

    private int spawncount = 0;     /*  ������� ������ ������ ������ ����� ����  */
    private float term = 0.0f;     /*  �ð��� �� �� ���� ����  */

    private void Update()
    {
        if (spawncount == count)     /*  ����Ƚ��( count )�� ����Ƚ��( spawncount )�� ���� ��� �����  */
        {
            return;     /*  ���� �ڵ带 �����ϰ� �ش� Ŭ����( private void Update() )�� ������  */
        }

        term += Time.deltaTime;     /*  Ÿ�̸� �뵵�� ���� : <Time.deltaTime>�� ���� ��� �����ð��� �Ȱ��� �帥��  */

        if ( term >= 0.5f)     /*  Ÿ�̸Ӱ� 0.5�� �̻��� �� �� ����  */
        {
            int prefabIndex = Random.Range(0, prefabArray.Length);     /*  ������ ������ �迭��ȣ ����  */
            int spawnIndex = Random.Range(0, spawnpointArray.Length);     /*  ������ ������ǥ �迭��ȣ ����  */

            Vector3 position = spawnpointArray[spawnIndex].position;     /*  28�� �ٿ��� ������ <Transform>�����Ϳ��� ��ġ���� ����  */
            GameObject clone = Instantiate(prefabArray[prefabIndex], position, Quaternion.identity);     /*  ������ ������ ������� ������ ����  */

            Vector3 moveDirection = (spawnIndex == 0 ? Vector3.right : Vector3.left);     /*  " ? " = ���׿����� : ( A ? B : C )���� A�� ���� ��� B��, A�� ������ ��� C�� ��ȯ��  */
            clone.GetComponent<Movement_One_Way>().Setup(moveDirection);     /*  33�� �ٿ��� ������ �̵������� �������� < Movement_One_Way >��ũ��Ʈ �� < Setup >�Լ��� �־� ��  */

            spawncount++;     /*  ������ ������ ���� + 1  */
            term = 0.0f;     /*  Ÿ�̸� �ʱ�ȭ  */
        }
    }
}
