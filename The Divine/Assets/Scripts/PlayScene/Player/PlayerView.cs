using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerView : MonoBehaviour
{
    public PlayerPanel playerPanel;

    public void Init(PlayerModel model)
    {
        playerPanel.Init();
    }
}
