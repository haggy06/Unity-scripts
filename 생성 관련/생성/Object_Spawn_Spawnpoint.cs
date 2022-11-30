using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Object_Spawn_Spawnpoint : MonoBehaviour
{
    [SerializeField]     /*  컴포넌트에 값 조절 바를 생성시켜줌  */
    private int count = 15;     /*  생성 횟수 지정  */

    [SerializeField]     /*  컴포넌트에 값 조절 바를 생성시켜줌  */
    private GameObject[] prefabArray;     /*  프리팹들을 넣을 배열  */

    [SerializeField]     /*  컴포넌트에 값 조절 바를 생성시켜줌  */
    private Transform[] spawnpointArray;     /*  <Transform>데이터들을 넣을 배열  */

    private void Awake()
    {
        for ( int i = 0; i < count; i++)     /*  count( 지정 횟수 )만큼 반복  */
        {
            int prefabIndex = Random.Range(0, prefabArray.Length);     /*  임의의 프리팹 배열번호 지정  */
            int spawnIndex = Random.Range(0, spawnpointArray.Length);     /*  임의의 좌표 배열번호 지정  */

            Vector3 position = spawnpointArray[spawnIndex].position;     /*  21번 줄에서 지정된 <Transform>데이터에서 위치정보 추출  */

            GameObject clone = Instantiate(prefabArray[prefabIndex], position, Quaternion.identity);     /*  임의의 오브젝트( 20번 줄 )를 특정 포인트( 23번 줄 )에 생성  */

            Vector3 moveDirection = (spawnIndex == 0 ? Vector3.right : Vector3.left);     /*  " ? " = 삼항연산자 : ( A ? B : C )에서 A가 참일 경우 B를, A가 거짓일 경우 C를 반환함  */
            clone.GetComponent<Movement_One_Way>().Setup(moveDirection);     /*  27번 줄에서 지정된 이동방향을 프리팹의 < Movement_One_Way >스크립트 속 < Setup >함수에 넣어 줌  */
        }
    }
}