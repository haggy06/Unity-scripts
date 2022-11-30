using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Object_Destroy_When_Touch : MonoBehaviour
{
    private SpriteRenderer spriteRenderer;     /*  <SpriteRenderer>형식의 변수 생성  */

    private void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();     /*  해당 오브젝트의 <SpriteRenderer>데이터 가져옴  */
    }

    private void OnTriggerEnter2D(Collider2D collision)     /*  ★<OnTrigger>류 함수들은 <Collider>컴포넌트의 <Is Trigger>가 켜져있어야 작동함( 이 경우 충돌판정 X )★  */
    {
        Destroy(collision.gameObject);     /*  닿은 오브젝트 삭제  */
        StartCoroutine("HitAnimation");     /*  <HitAnimation>함수 실행  */
    }

    private IEnumerator HitAnimation()
    {
        spriteRenderer.color = Color.red;     /*  이 오브젝트 색 변경( → 빨강 )  */

        yield return new WaitForSeconds(0.1f);     /*  0.1초 기다리기  */

        spriteRenderer.color = Color.white;     /*  이 오브젝트 색 변경( → 하양 )  */
    }
}
