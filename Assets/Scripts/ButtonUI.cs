using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonUI : MonoBehaviour
{
    [SerializeField] private string Test = "Test";
    public AudioSettings audioSettings;

    private void Awake()
    {
        audioSettings = GetComponent<AudioSettings>();
    }

    public void Scene2()
    {
        SceneManager.LoadScene(Test);
    }
}




