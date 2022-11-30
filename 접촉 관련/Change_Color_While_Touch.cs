using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Change_Color_While_Touch : MonoBehaviour
{
    [SerializeField]     /*  컴포넌트에 값 조절 바를 생성시켜줌  */
    private Color Whilecolor;     /*  접촉하는 동안 바뀔 색상  */

    [SerializeField]     /*  컴포넌트에 값 조절 바를 생성시켜줌  */
    private Color Aftercolor;     /*  접촉 끝나고 바뀔 색상  */

    private SpriteRenderer spriteRenderer;


    private void Awake()     /*  씬이 시작될 때 1회 실행  */
    {
        spriteRenderer = GetComponent<SpriteRenderer>();     /*  "SpriteRenderer" 컴포넌트 정보 가져옴  */
    }

    private void OnCollisionEnter2D(Collision2D collision)     /*  접촉하는 순간 1회 실행  */
    {
        spriteRenderer.color = Whilecolor;     /*  오브젝트 색상 → Whilecolor  */
    }

    private void OnCollisionExit2D(Collision2D collision)     /*  접촉 끝날 때 1회 실행  */
    {
        spriteRenderer.color = Aftercolor;     /*  오브젝트 색상 → aftercolor  */
    }
}
