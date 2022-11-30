using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Object_Spawn_Term : MonoBehaviour
{
    [SerializeField]     /*  컴포넌트에 값 조절 바를 생성시켜줌  */
    private int count = 15;     /*  생성횟수 지정( 기본값 = 15 )  */

    [SerializeField]     /*  컴포넌트에 값 조절 바를 생성시켜줌  */
    private GameObject[] prefabArray;     /*  생성될 프리팹들을 넣을 배열  */

    [SerializeField]     /*  컴포넌트에 값 조절 바를 생성시켜줌  */
    private Transform[] spawnpointArray;     /*  프리팹 생성위치가 될 위치 컴포넌트를 넣을 배열( 오브젝트째 삽입 )  */

    private int spawncount = 0;     /*  현재까지 생성한 프리팹 개수를 기록할 변수  */
    private float term = 0.0f;     /*  시간을 잴 때 쓰일 변수  */

    private void Update()
    {
        if (spawncount == count)     /*  생성횟수( count )와 생성횟수( spawncount )가 같을 경우 실행됨  */
        {
            return;     /*  밑의 코드를 무시하고 해당 클래스( private void Update() )를 종료함  */
        }

        term += Time.deltaTime;     /*  타이머 용도로 쓰임 : <Time.deltaTime>을 더할 경우 실제시간과 똑같이 흐른다  */

        if ( term >= 0.5f)     /*  타이머가 0.5초 이상이 될 시 실행  */
        {
            int prefabIndex = Random.Range(0, prefabArray.Length);     /*  임의의 프리팹 배열번호 지정  */
            int spawnIndex = Random.Range(0, spawnpointArray.Length);     /*  임의의 생성좌표 배열번호 지정  */

            Vector3 position = spawnpointArray[spawnIndex].position;     /*  28번 줄에서 지정된 <Transform>데이터에서 위치정보 추출  */
            GameObject clone = Instantiate(prefabArray[prefabIndex], position, Quaternion.identity);     /*  위에서 지정된 정보들로 프리팹 생성  */

            Vector3 moveDirection = (spawnIndex == 0 ? Vector3.right : Vector3.left);     /*  " ? " = 삼항연산자 : ( A ? B : C )에서 A가 참일 경우 B를, A가 거짓일 경우 C를 반환함  */
            clone.GetComponent<Movement_One_Way>().Setup(moveDirection);     /*  33번 줄에서 지정된 이동방향을 프리팹의 < Movement_One_Way >스크립트 속 < Setup >함수에 넣어 줌  */

            spawncount++;     /*  생성한 프리팹 개수 + 1  */
            term = 0.0f;     /*  타이머 초기화  */
        }
    }
}
