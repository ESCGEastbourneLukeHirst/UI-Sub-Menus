using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonUI : MonoBehaviour
{

    [SerializeField] private string Test = "Test";

    public void Scene2()
    {
        SceneManager.LoadScene(Test);
    }
}
