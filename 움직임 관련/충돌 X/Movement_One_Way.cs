using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement_One_Way : MonoBehaviour
{
    [SerializeField]     /*  컴포넌트에 값 조절 바를 생성시켜줌  */
    private float moveSpeed = 5.0f;     /*  움직임 속도 지정  */

    private Vector3 moveDirection;     /*  방향을 지정받을 변수 생성  */

    public void Setup(Vector3 direction)     /*  다른 스크립트에서 < moveDirection >에 값을 받아오는 클래스  */
    {
        moveDirection = direction;     /*  다른 스크립트에서 보내준 방향값을 < moveDirection >에 넣어줌  */
    }

    private void Update()
    {
        transform.position += moveDirection * moveSpeed * Time.deltaTime;     /*  현재위치 = 현재위치 + 이동방향( moveDirection ) * 이동속도( moveSpeed ) * 컴퓨터 연산속도( Time.deltaTime )  */
    }                                                                           /*  Time.deltaTime : 컴퓨터 연산속도가 빠를수록 프레임수가 많기 때문에 이동거리가 증가하는데, 이를 막기 위해 곱해주는 값이다. */
}
