using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;     /*  씬 관련 스크립트에는 이게 들어가야 함  */
using UnityEngine.SceneManagement;     /*  씬 관련 스크립트에는 이게 들어가야 함  */

public class Scene_Move : MonoBehaviour
{
    public void GameSceneCtrl()
    {
        SceneManager.LoadScene("Game_Scene");     /*  ("  ") 안에 이동할 씬 이름을 작성   */
    }
}     /*  ★ <On Click> 에 바로 넣는 것이 아닌 컴포넌트로서 넣은 다음 컴포넌트로 들어가 있는 스크립트를 드래그&드롭 해야 한다. ★  */
      /*  옆의 <No function> 를 <해당 스크립트 제목> → <해당 클래스 제목> 을 선택한다.  */
