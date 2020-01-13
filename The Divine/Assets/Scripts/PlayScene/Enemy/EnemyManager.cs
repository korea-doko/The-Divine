using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    private static EnemyManager inst;

    public static EnemyManager Inst { get => inst;  }
    public EnemyManager() { inst = this; }

    [SerializeField] private EnemyModel model;
    [SerializeField] private EnemyView view;

    private void Awake()
    {
        model.Init();
        view.Init(model);

        MakeGodByDataPrevScene();

    }
    
    private void MakeGodByDataPrevScene()
    {
        Debug.Log(" 이전 씬에서 적당히 난이도에 따라서 가져오고 신에 대해서도 특성을 문명처럼 만들면 좋겠다.");

        for(int i = 0; i< 4 ; i++)
        {
            God newGod = GodManager.Inst.GetNewGod();
            model.AddGod(newGod);
        }
    }
}
