using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Object_Spawn_Random : MonoBehaviour
{
    [SerializeField]     /*  ������Ʈ�� �� ���� �ٸ� ����������  */
    private GameObject[] prefabArray;     /*  �����յ��� ���� �迭  */

    [SerializeField]     /*  ������Ʈ�� �� ���� �ٸ� ����������  */
    private int count;     /*  ���� Ƚ�� ����  */

    private void Awake()
    {
        for ( int i = 0; i < count; i++)      /*  count( ���� Ƚ�� )��ŭ �ݺ�  */
        {
            int index = Random.Range(0, prefabArray.Length);     /*  ������ �迭 ��ȣ ����  */

            float x = Random.Range(-9.6f, 9.6f);     /*  ������ x��ǥ ����  */
            float y = Random.Range(-5.0f, 5.0f);     /*  ������ y��ǥ ����  */
            Vector3 position = new Vector3(x, y, 0);     /*  ��ȯ�� ��ǥ ����  */

            int z = Random.Range(-180, 180);     /*  ������ ���� ����  */
            Debug.Log(z);
            Quaternion rotation = Quaternion.Euler(0, 0, z);     /*  ��ȯ�� ���� ����  */

            Instantiate(prefabArray[index], position, rotation);     /*  ������ ������Ʈ( 17�� �� )�� ������ ��ġ��( 19 ~ 21�� �� ) ������ ����( 23 ~ 24�� �� )�� ����  */
        }
    }
}
