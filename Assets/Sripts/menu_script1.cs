using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menu_script1 : MonoBehaviour
{
    public string sceneToOpenName = "SampleScene"; // ��'� �����, ��� �� ������ �������

    public void LoadScene()
    {
        SceneManager.LoadScene(sceneToOpenName); // ����������� ���� �����
    }
}
