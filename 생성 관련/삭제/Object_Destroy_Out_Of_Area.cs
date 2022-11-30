using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Object_Destroy_Out_Of_Area : MonoBehaviour
{
    [SerializeField]     /*  컴포넌트에 값 조절 바를 생성시켜줌  */
    private Vector2 limit_Min = new Vector2(-10.2f, -5.5f);     /*  존재 가능 위치의 최솟값 지정  */

    [SerializeField]     /*  컴포넌트에 값 조절 바를 생성시켜줌  */
    private Vector2 limit_Max = new Vector2(10.2f, 5.5f);     /*  존재 가능 취치의 최댓값 지정  */

    private void Update()
    {
        if (transform.position.x < limit_Min.x || transform.position.x > limit_Max.x ||transform.position.y < limit_Min.y || transform.position.y > limit_Max.y) Destroy(gameObject);     /*  현재 위치가 최솟값보다 작거나 최댓값보다 높으면 이 오브젝트 삭제  */
    }
}
