using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerModel : MonoBehaviour
{
    public God myGod;
   
    public void Init()
    {
        myGod = new God();
    }
}
