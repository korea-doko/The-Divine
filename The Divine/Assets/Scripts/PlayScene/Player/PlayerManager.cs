using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerManager : MonoBehaviour
{
    private static PlayerManager inst;

    public static PlayerManager Inst { get => inst; }
    public PlayerManager() { inst = this; }

    [SerializeField] private PlayerModel model;
    [SerializeField] private PlayerView view;

    private void Awake()
    {
        model.Init();
        view.Init(model);
    }

}
