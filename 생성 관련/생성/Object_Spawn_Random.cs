using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Object_Spawn_Random : MonoBehaviour
{
    [SerializeField]     /*  컴포넌트에 값 조절 바를 생성시켜줌  */
    private GameObject[] prefabArray;     /*  프리팹들을 넣을 배열  */

    [SerializeField]     /*  컴포넌트에 값 조절 바를 생성시켜줌  */
    private int count;     /*  생성 횟수 지정  */

    private void Awake()
    {
        for ( int i = 0; i < count; i++)      /*  count( 생성 횟수 )만큼 반복  */
        {
            int index = Random.Range(0, prefabArray.Length);     /*  임의의 배열 번호 지정  */

            float x = Random.Range(-9.6f, 9.6f);     /*  임의의 x좌표 지정  */
            float y = Random.Range(-5.0f, 5.0f);     /*  임의의 y좌표 지정  */
            Vector3 position = new Vector3(x, y, 0);     /*  소환할 좌표 지정  */

            int z = Random.Range(-180, 180);     /*  임의의 각도 지정  */
            Debug.Log(z);
            Quaternion rotation = Quaternion.Euler(0, 0, z);     /*  소환할 각도 지정  */

            Instantiate(prefabArray[index], position, rotation);     /*  임의의 오브젝트( 17번 줄 )를 임의의 위치에( 19 ~ 21번 줄 ) 임의의 각도( 23 ~ 24번 줄 )로 생성  */
        }
    }
}
