using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animation_For_Test : MonoBehaviour
{
    private Animator animator;     /*  Animator 형식의 animator라는 변수 지정  */

    private void Awake()
    {
        animator = GetComponent<Animator>();     /*  이 오브젝트의 <Animation> 컴포넌트를 animation 변수에 넣음  */
    }

    private void Update()
    {
        if ( Input.GetKeyDown(KeyCode.Space))     /*  스페이스 키를 눌렀을 때 실행  */
        {
            animator.SetTrigger("Trigger");     /*  <Animator> 속 <Parameters>의 <Trigger>를 실행  */
        }                                                    /*  Bool 타입 파라미터는 " animator.SetBool( string name, bool value ); "로, Float 타입은 " animator.SetFloat( String name, float value ); "로, Int 타입은 " animator.SetInteger( string name, int value ); "로, Trigger 타입은 " animator.SetTrigger( string name ); "로 나타낼 수 있다.  */
    }                                                        /*  불러올 땐 각각 " animatorGetBool(string name); ", " animatorGetFloat(string name ); ", " animatorGetInteger( string name ); "가 있다( Trigger는 단순 실행타입이라서 불러오기 X ).  */
    
    public void OnDieEvent()    /*  Public 형식의 함수는 Animation 편집창의 <Add event>로 에니메이션 실행 중 불러오게 할 수 있다.  */
    {
        Debug.Log("작동 잘 되는 중");     /*  콜솔 창에 괄호 속 메시지 출력  */
    }
}
