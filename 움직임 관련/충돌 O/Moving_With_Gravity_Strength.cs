using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moving_With_Gravity_Strength : MonoBehaviour
{
    [SerializeField]     /*  컴포넌트에 값 조절 바를 생성시켜줌  */
    private float speed = 5.0f;     /*  float 형식의 speed 변수 생성( 기본값 = 5 )  */

    [SerializeField]     /*  컴포넌트에 값 조절 바를 생성시켜줌  */
    private float jumpPower = 13.0f;     /*  float 형식의 jumpPower 변수 생성( 기본값 = 13 )  */

    private Rigidbody2D rigid2D;     /*  rigidbody2D 형태의 변수 생성  */

    private void Awake()
    {
        rigid2D = GetComponent<Rigidbody2D>();     /*  이 오브젝트의 물리엔진 불러옴  */
    }

    private void Update()
    {
        float x = Input.GetAxisRaw("Horizontal");     /*  가로축 관련 이동설정( " D, → " = +1  |  " A, ← " = -1 )  */

        rigid2D.velocity = new Vector2(x * speed, rigid2D.velocity.y);     /*  위에서 가쳐온 x축 이동값만큼 축 이동( y축은 물리엔진 계산값 )  */

        if (Input.GetKeyDown(KeyCode.Space)) rigid2D.velocity = Vector2.up * jumpPower;     /*  스페이스바를 누를 시 → jump가 true일 시 → jumpPower값만큼 위로 이동( 물리엔진에 의해 저절로 속도가 줄어듦 )  */

        if (Input.GetKeyUp(KeyCode.Space)) if (rigid2D.velocity.y > 1.0f) rigid2D.velocity = Vector2.up * 1.0f;     /*  스페이스바에서 손을 뗄 시 → y축 속도가 1 이상일 시 → y축 이동속도를 1로 바꿈  */
    }
}
