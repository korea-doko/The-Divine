using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InfoManager : MonoBehaviour
{
    private static InfoManager inst;
    public static InfoManager Inst { get => inst; }
    public EGameDifficultyType DifficultyType { get => difficultyType; set => difficultyType = value; }

    public InfoManager() { inst = this; }

    public enum EGameDifficultyType
    {
        Easy,
        Normal,
        Hard
    }

    private EGameDifficultyType difficultyType;

    private void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
    }
}

