using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Object_Destroy_When_Touch : MonoBehaviour
{
    private SpriteRenderer spriteRenderer;     /*  <SpriteRenderer>������ ���� ����  */

    private void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();     /*  �ش� ������Ʈ�� <SpriteRenderer>������ ������  */
    }

    private void OnTriggerEnter2D(Collider2D collision)     /*  ��<OnTrigger>�� �Լ����� <Collider>������Ʈ�� <Is Trigger>�� �����־�� �۵���( �� ��� �浹���� X )��  */
    {
        Destroy(collision.gameObject);     /*  ���� ������Ʈ ����  */
        StartCoroutine("HitAnimation");     /*  <HitAnimation>�Լ� ����  */
    }

    private IEnumerator HitAnimation()
    {
        spriteRenderer.color = Color.red;     /*  �� ������Ʈ �� ����( �� ���� )  */

        yield return new WaitForSeconds(0.1f);     /*  0.1�� ��ٸ���  */

        spriteRenderer.color = Color.white;     /*  �� ������Ʈ �� ����( �� �Ͼ� )  */
    }
}
