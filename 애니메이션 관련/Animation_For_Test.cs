using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animation_For_Test : MonoBehaviour
{
    private Animator animator;     /*  Animator ������ animator��� ���� ����  */

    private void Awake()
    {
        animator = GetComponent<Animator>();     /*  �� ������Ʈ�� <Animation> ������Ʈ�� animation ������ ����  */
    }

    private void Update()
    {
        if ( Input.GetKeyDown(KeyCode.Space))     /*  �����̽� Ű�� ������ �� ����  */
        {
            animator.SetTrigger("Trigger");     /*  <Animator> �� <Parameters>�� <Trigger>�� ����  */
        }                                                    /*  Bool Ÿ�� �Ķ���ʹ� " animator.SetBool( string name, bool value ); "��, Float Ÿ���� " animator.SetFloat( String name, float value ); "��, Int Ÿ���� " animator.SetInteger( string name, int value ); "��, Trigger Ÿ���� " animator.SetTrigger( string name ); "�� ��Ÿ�� �� �ִ�.  */
    }                                                        /*  �ҷ��� �� ���� " animatorGetBool(string name); ", " animatorGetFloat(string name ); ", " animatorGetInteger( string name ); "�� �ִ�( Trigger�� �ܼ� ����Ÿ���̶� �ҷ����� X ).  */
    
    public void OnDieEvent()    /*  Public ������ �Լ��� Animation ����â�� <Add event>�� ���ϸ��̼� ���� �� �ҷ����� �� �� �ִ�.  */
    {
        Debug.Log("�۵� �� �Ǵ� ��");     /*  �ݼ� â�� ��ȣ �� �޽��� ���  */
    }
}
