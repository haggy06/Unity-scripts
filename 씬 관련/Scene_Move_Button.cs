using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;     /*  �� ���� ��ũ��Ʈ���� �̰� ���� ��  */
using UnityEngine.SceneManagement;     /*  �� ���� ��ũ��Ʈ���� �̰� ���� ��  */

public class Scene_Move : MonoBehaviour
{
    public void GameSceneCtrl()
    {
        SceneManager.LoadScene("Game_Scene");     /*  ("  ") �ȿ� �̵��� �� �̸��� �ۼ�   */
    }
}     /*  �� <On Click> �� �ٷ� �ִ� ���� �ƴ� ������Ʈ�μ� ���� ���� ������Ʈ�� �� �ִ� ��ũ��Ʈ�� �巡��&��� �ؾ� �Ѵ�. ��  */
      /*  ���� <No function> �� <�ش� ��ũ��Ʈ ����> �� <�ش� Ŭ���� ����> �� �����Ѵ�.  */
