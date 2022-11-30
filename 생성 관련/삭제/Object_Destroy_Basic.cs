using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Object_Destroy_Basic : MonoBehaviour
{
    [SerializeField]     /*  컴포넌트에 값 조절 바를 생성시켜줌  */
    private GameObject playerObject;     /*  대상이 될 오브젝트 지정  */

    private void Awake()
    {
        Destroy(playerObject.GetComponent<Moving_zero_Gravity>());     /*  지정된 오브젝트의 <Moving_Zero_Gravity>컴포넌트를 삭제함  */
                                                                                                          /*  " playerObject.GetComponent<Moving_zero_Gravity>().enabled = false; "로 꺼두는 것을 더 권장함  */
    }
}
