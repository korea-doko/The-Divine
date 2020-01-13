using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum EGodType
{
    GOD_1,
    GOD_2,
    GOD_3,
    GOD_4,
    GOD_5,
    GOD_6
}


[System.Serializable]
public class God 
{
    public EGodType godType;

    public int divineRank;
    public int divinePower;
    public int popularity;
    public int numberOfApostle;
    public Tendency tendency;

    public God()
    {
        godType = EGodType.GOD_1;

        this.divineRank = 0;
        this.divinePower = 0;
        this.popularity = 0;
        this.numberOfApostle = 0;
        this.tendency = new Tendency();
    }
}
