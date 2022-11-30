using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Change_Color_While_Touch : MonoBehaviour
{
    [SerializeField]     /*  ������Ʈ�� �� ���� �ٸ� ����������  */
    private Color Whilecolor;     /*  �����ϴ� ���� �ٲ� ����  */

    [SerializeField]     /*  ������Ʈ�� �� ���� �ٸ� ����������  */
    private Color Aftercolor;     /*  ���� ������ �ٲ� ����  */

    private SpriteRenderer spriteRenderer;


    private void Awake()     /*  ���� ���۵� �� 1ȸ ����  */
    {
        spriteRenderer = GetComponent<SpriteRenderer>();     /*  "SpriteRenderer" ������Ʈ ���� ������  */
    }

    private void OnCollisionEnter2D(Collision2D collision)     /*  �����ϴ� ���� 1ȸ ����  */
    {
        spriteRenderer.color = Whilecolor;     /*  ������Ʈ ���� �� Whilecolor  */
    }

    private void OnCollisionExit2D(Collision2D collision)     /*  ���� ���� �� 1ȸ ����  */
    {
        spriteRenderer.color = Aftercolor;     /*  ������Ʈ ���� �� aftercolor  */
    }
}
