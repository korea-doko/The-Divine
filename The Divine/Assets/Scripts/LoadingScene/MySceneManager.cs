using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class MySceneManager : MonoBehaviour
{
    public enum ESceneType
    {
        Loading,
        Lobby,
        Play
    }
    private static MySceneManager inst;

    public static MySceneManager Inst { get => inst; }
    public MySceneManager() { inst = this; }

    private void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
    }

    public static void ChangeSceneTo(ESceneType _type)
    {
        UnityEngine.SceneManagement.SceneManager.LoadSceneAsync((int)_type);
    }
}
