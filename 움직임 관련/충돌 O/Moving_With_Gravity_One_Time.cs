using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moving_With_Gravity_One_Time : MonoBehaviour
{
    [SerializeField]     /*  컴포넌트에 값 조절 바를 생성시켜줌  */
    private float speed = 5.0f;

    [SerializeField]     /*  컴포넌트에 값 조절 바를 생성시켜줌  */
    private float jumpPower = 13.0f;     /*  점프파워 조절  */

    private Rigidbody2D rigid2D;     /*  이 오브젝트의 물리엔진을 가져올 변수  */

    [SerializeField]     /*  컴포넌트에 값 조절 바를 생성시켜줌  */
    private LayerMask groundLayer;     /*  밟은 판정을 낼 레이어를 넣을 변수  */

    private CircleCollider2D circleCollider2D;     /*  이 오브젝트의 Collider2D를 저장할 변수( 스크립트를 가질 오브젝트에 맞는 Collider2D로 설정해야 함  )  */

    private bool isGround;     /*  발이 땅에 닿아있는지를 검사하는 변수  */

    private Vector3 footPosition;     /*  발의 위치를 저장할 변수  */

    private void Awake()
    {
        rigid2D = GetComponent<Rigidbody2D>();     /*  이 오브젝트의 Rigidbody2D를 가져옴  */
        circleCollider2D = GetComponent<CircleCollider2D>();     /*  이 오브젝트의 Collider2D를 가져옴  */
    }

    private void FixedUpdate()     /*  모든 Update함수가 작동된 후 작동하는 함수  */
    {
        Bounds bounds = circleCollider2D.bounds;     /*  이 오브젝트의 Collider의 bounds값( Collider2D.Bounds = Collider2D의 x축과 y축의 최대, 최소, 중간값이 저장되어있는 곳 )을 가져옴  */
                                                                          /*  ★ 이 오브젝트에 맞는 collider2D로 바꾸는 것 잊지 말기!!! ★  */

        footPosition = new Vector2(bounds.center.x, bounds.min.y);     /*  이 오브젝트의 충돌범위( Collider2D )의 ( x축 ( 정가운데값 ), y축 ( 맨 밑의 값 ) )위치를 footPosition에 저장  */

        isGround = Physics2D.OverlapCircle(footPosition, 0.1f, groundLayer);     /*  footPosition에 반지를 0.1크기의 원을 생성해, groundLayer에 소속된 오브젝트와 닿을 경우 true를, 아닐 경우 false를 저장  */
    }                                                                                                           /*  이 원은 Scene View에서도 보이지 않기 때문에 <OnDrawGizmos>함수를 이용해 같은 위치에 도형을 그려야 한다( 봐야 할 때만 ).  */

    private void Update()
    {
        float x = Input.GetAxisRaw("Horizontal");     /*  가로축 관련 이동설정( " D, → " = +1  |  " A, ← " = -1 )  */

        rigid2D.velocity = new Vector2(x * speed, rigid2D.velocity.y);     /*  위에서 가쳐온 x축 이동값만큼 축 이동( y축은 물리엔진 계산값 )  */

        if (Input.GetKeyDown(KeyCode.Space)) if (isGround == true) rigid2D.velocity = Vector2.up * jumpPower;     /*  스페이스바를 누를 시 → jump가 true일 시 → jumpPower값만큼 위로 이동( 물리엔진에 의해 저절로 속도가 줄어듦 )  */
        if (Input.GetKeyUp(KeyCode.Space)) if (rigid2D.velocity.y > 1.0f) rigid2D.velocity = Vector2.up * 1.0f;     /*  스페이스바에서 손을 뗄 시 → y축 속도가 1 이상일 시 → y축 이동속도를 1로 바꿈  */
    }
}
