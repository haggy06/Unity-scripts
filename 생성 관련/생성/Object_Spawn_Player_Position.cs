using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Object_Spawn_Player_Position : MonoBehaviour
{
    [SerializeField]     /*  컴포넌트에 값 조절 바를 생성시켜줌  */
    private KeyCode fireCode = KeyCode.Z;     /*  클래스 실행에 쓰일 키 지정 : 변수명 = fireCode( 기본값 = Z )  */

    [SerializeField]     /*  컴포넌트에 값 조절 바를 생성시켜줌  */
    private GameObject bulletPrefab;     /*  생성될 오브젝트 지정  */

    private Vector3 lastMoveDirection = Vector3.right;     /*  프리팹을 이동시킬 방향 지정에 쓰일 변수  */

    void Update()
    {
        float x = Input.GetAxisRaw("Horizontal");     /*  가로축 관련 이동설정( " D, → " = +1  |  " A, ← " = -1 )  */
        float y = Input.GetAxisRaw("Vertical");     /*  세로축 관련 이동설정( " W, ↑ " = +1  |  " S, ↓ " = -1 )  */

        if ( x != 0 || y != 0)     /*  x 또는 y가 0이 아닐 경우 실행됨  */
        {
            lastMoveDirection = new Vector3(x, y, 0);     /*  마지막으로 움직인 이동방향을 저장  */
        }

        if ( Input.GetKeyDown( fireCode ))     /*  <fireCode>에 지정된 키를 누를 경우 실행됨  */
        {
            GameObject clone = Instantiate(bulletPrefab, transform.position, Quaternion.identity);     /*  해당 컴포넌트를 가지고 있는 오브젝트의 위치에 프리팹 생성 : 생성된 프리팹의 변수명 = clone  */

            clone.name = "bullet";     /*  생성된 프리팹( clone )의 이름을 "bullet"으로 변경  */
            clone.transform.localScale = Vector3.one * 0.5f;     /*  생성된 프리팹( clone )의 크기를 Vector.one( (1, 1, 1) ) * 0.5로 지정  */
            clone.GetComponent<SpriteRenderer>().color = Color.red;     /*  생성된 프리팹( clone )의 색깔을 빨간색으로 변경  */

            clone.GetComponent<Movement_One_Way>().Setup(lastMoveDirection);     /*  22번 줄에서 지정된 이동방향을 프리팹의 < Movement_One_Way >스크립트 속 < Setup >함수에 넣어 줌  */
        }
    }
}
