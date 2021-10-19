using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScenes : MonoBehaviour
{
    //funcion que carga la escena 
    public void Load_Scene(string SceneName)
    {
        SceneManager.LoadScene(SceneName);
    }
}
