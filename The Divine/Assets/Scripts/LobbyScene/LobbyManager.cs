using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LobbyManager : MonoBehaviour
{
    private static LobbyManager inst;

    public static LobbyManager Inst { get => inst; }
    public LobbyManager() { inst = this; }

    private void Awake()
    {
        
    }

    private void Update()
    {       
        if( Input.GetKeyDown(KeyCode.Alpha1))
        {
            InfoManager.Inst.DifficultyType = InfoManager.EGameDifficultyType.Easy;
            MySceneManager.ChangeSceneTo(MySceneManager.ESceneType.Play);
        }
        if( Input.GetKeyDown(KeyCode.Alpha2))
        {
            InfoManager.Inst.DifficultyType = InfoManager.EGameDifficultyType.Normal;
            MySceneManager.ChangeSceneTo(MySceneManager.ESceneType.Play);
        }
        if( Input.GetKeyDown(KeyCode.Alpha3))
        {
            InfoManager.Inst.DifficultyType = InfoManager.EGameDifficultyType.Hard;
            MySceneManager.ChangeSceneTo(MySceneManager.ESceneType.Play);
        }
    }
}
