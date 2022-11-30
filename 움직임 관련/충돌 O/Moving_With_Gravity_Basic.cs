using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moving_With_Gravity_Basic : MonoBehaviour
{
    [SerializeField]     /*  컴포넌트에 값 조절 바를 생성시켜줌  */
    private float speed = 5.0f;     /*  이동속도 조절  */

    [SerializeField]     /*  컴포넌트에 값 조절 바를 생성시켜줌  */
    private float jumpPower = 8.0f;     /*  점프 세기 조절  */
    
    private Rigidbody2D rigid2D;     /*  <Rigidbody2D>형식의 변수 생성  */

    private void Awake()
    {
        rigid2D = GetComponent<Rigidbody2D>();     /*  이 오브젝트의 물리엔진 불러옴  */
    }

    private void Update()
    {
        float x = Input.GetAxisRaw("Horizontal");     /*  가로축 관련 이동설정( " D, → " = +1  |  " A, ← " = -1 )  */

        Move(x);     /*  위에서 가쳐온 x축 이동값으로 밑에 있는 Move함수 실행  */
        if (Input.GetKeyDown(KeyCode.Space)) Jump();     /*  스페이스바를 누를 시 밑에 있는 Jump함수 실행  */
    }

    public void Move( float x)     /*  float 형식의 데이터를 입력받는 <Move>함수  */
    {
        rigid2D.velocity = new Vector2(x * speed, rigid2D.velocity.y);     /*  x좌표  = 입력받은 데이터 * speed, y좌표 = 물리엔진 계산값  */
    }
    
    public void Jump()     /*  아무 데이터도 입력받지 않는 <Jump> 함수  */
    {
        rigid2D.velocity = Vector2.up * jumpPower;     /*  jumpPower값만큼 위로 이동( 물리엔진에 의해 저절로 속도가 줄어듦 )  */
    }
}
