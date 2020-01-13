using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GodManager : MonoBehaviour
{
    private static GodManager inst;

    public static GodManager Inst { get => inst; }
    public GodManager() { inst = this; }

    [SerializeField] private GodModel model;
    [SerializeField] private GodView view;


    private void Awake()
    {
        model.Init();
        view.Init(model);
    }


    public God GetNewGod()
    {
        God newGod = new God();

        model.AddGod(newGod);

        return newGod;
    }
}
