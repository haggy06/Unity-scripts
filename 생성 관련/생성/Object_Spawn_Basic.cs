using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Object_Spawn_Basic : MonoBehaviour
{
    [SerializeField]     /*  컴포넌트에 값 조절 바를 생성시켜줌  */
    private GameObject Input_Prefab;     /*  생성할 프리팹 지정  */

    [SerializeField]     /*  컴포넌트에 값 조절 바를 생성시켜줌  */
    private Vector3 vector;     /*  위치 변경값 ( 23번 줄에 쓰임 )  */

    [SerializeField]     /*  컴포넌트에 값 조절 바를 생성시켜줌  */
    private Quaternion quaternion;     /*  회전 변경값 ( 23번 줄에 쓰임 )  */

    private void Awake()     /*  씬이 시작할 때 1회 실행  */
    {
        vector += transform.position;

        Instantiate(Input_Prefab);     /*  프리팹 내부정보 그대로 생성  */

        Instantiate(Input_Prefab, new Vector3(2, 3, 0), Quaternion.identity);     /*  프리팹의 위치를 바꿔서 생성  */

        Quaternion rotation = Quaternion.Euler(0, 0, 45);     /*  변경할 각도 지정  */
        Instantiate(Input_Prefab, new Vector3(-2, 3, 0), rotation);     /*  프리팹의 위치 및 각도를 바꿔서 생성  */

        Instantiate(Input_Prefab, vector, quaternion);     /*   "이 스크립트를 가진 오브젝트의 위치 + 위에서 지정한 위치 변경값" 으로 이동, 위에서 변경한 각도만큼 회전  */
    }
}