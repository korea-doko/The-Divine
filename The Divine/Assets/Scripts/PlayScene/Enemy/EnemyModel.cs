using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyModel : MonoBehaviour
{
    public List<God> enemyGodList;

    public void Init()
    {
        enemyGodList = new List<God>();
    }

    public void AddGod(God newGod)
    {
        enemyGodList.Add(newGod);
    }
}
