using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Object_Destroy_Basic : MonoBehaviour
{
    [SerializeField]     /*  ������Ʈ�� �� ���� �ٸ� ����������  */
    private GameObject playerObject;     /*  ����� �� ������Ʈ ����  */

    private void Awake()
    {
        Destroy(playerObject.GetComponent<Moving_zero_Gravity>());     /*  ������ ������Ʈ�� <Moving_Zero_Gravity>������Ʈ�� ������  */
                                                                                                          /*  " playerObject.GetComponent<Moving_zero_Gravity>().enabled = false; "�� ���δ� ���� �� ������  */
    }
}
