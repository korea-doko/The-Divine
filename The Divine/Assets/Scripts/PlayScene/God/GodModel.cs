using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GodModel : MonoBehaviour
{
    public List<God> generatedGotList;

    public void Init()
    {
        generatedGotList = new List<God>();
    }

    public void AddGod(God _god)
    {
        generatedGotList.Add(_god);
    }
    
}
