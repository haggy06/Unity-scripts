using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moving_Zero_Gravity : MonoBehaviour
{

    private float MoveSpeed = 5.0f;     /*  움직임의 속도조절  */

    private Rigidbody2D rigid2D;

    void Awake()     /*  씬이 시작될 때 1회 실행  */
    {
        rigid2D = GetComponent<Rigidbody2D>();     /*  "Rigidbody2D" 컴포넌트 정보 가져옴  */
    }

    void Update()     /*  씬의 매 프레임마다 실행  */
    {
        float x = Input.GetAxisRaw( "Horizontal" );     /*  가로축 관련 이동설정( " D, → " = +1  |  " A, ← " = -1 )  */
        float y = Input.GetAxisRaw( "Vertical" );     /*  세로축 관련 이동설정( " W, ↑ " = +1  |  " S, ↓ " = -1 )  */

        rigid2D.velocity = new Vector3(x, y, 0) * MoveSpeed;     /*  위의 x, y값을 통해 위치이동( 물리엔진 우선시 )  */
    }
}