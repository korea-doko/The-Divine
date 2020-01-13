using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public partial class Tendency
{
    private static readonly int numberOfTendencyType = System.Enum.GetNames(typeof(ETendencyType)).Length;

    public static int NumberOfTendencyType
    {
        get { return numberOfTendencyType ; }
    }

    
}

public enum ETendencyType
{
    Light,
    Darkness,
    Life,
    Death,
    Order,
    Disorder,
    Neutrality
}

[System.Serializable]
public partial class Tendency
{
    
    [SerializeField] private int[] tendencyValue;
    [SerializeField] private float[] tendencyValueRatio;
    [SerializeField] private float remainRatio;

    public Tendency()
    {
        tendencyValue = new int[NumberOfTendencyType];
        tendencyValueRatio = new float[NumberOfTendencyType];
    }

    public void SetTendencyValue(ETendencyType _type, int _value)
    {
        this.tendencyValue[(int)_type] = _value;

        CalculateRatio();
    }
    public void AddTendencyValue(ETendencyType type, int value)
    {
        this.tendencyValue[(int)type] += value;

        CalculateRatio();
    }

    public int GetTendencyValue(ETendencyType _type)
    {
        return this.tendencyValue[(int)_type];
    }
    public float GetTendencyValueRatio(ETendencyType _type)
    {
        return this.tendencyValueRatio[(int)_type];
    }

    public void ClearTendencyValue()
    {
        for(int i = 0; i < Tendency.NumberOfTendencyType; i++)
        {
            ETendencyType type = (ETendencyType)i;
            SetTendencyValue(type, 0);
        }

        CalculateRatio();
    }

    private void ClearTendencyValueRatio()
    {
        for(int i = 0; i < Tendency.NumberOfTendencyType;i++)
            tendencyValueRatio[i] = 0.0f;        
    }

    private void CalculateRatio()
    {
        int sum = 0;
        float rawRemainRatio = 100.0f;

        sum = GetSumTendencyValue();

        if (sum == 0)
        {
            ClearTendencyValueRatio();
            return;
        }

        for(int i = 0; i < NumberOfTendencyType;i++)
        {
            float ratio = ((float)tendencyValue[i] / (float)sum) * 100.0f;
            // Change integer variable to float by dividing it.
            // so must check divide by zero exception.
            // so does at above line.

            tendencyValueRatio[i] = Mathf.Floor(ratio * 10.0f) * 0.1f;
            // 0.123 -> 0.1 by this line

            rawRemainRatio -= tendencyValueRatio[i];
        }

        remainRatio = GrindBelowTheDecimalPoint(rawRemainRatio);

        //Debug.Log(rawRemainRatio.ToString() + " // " + remainRatio.ToString());
    }

    private float GrindBelowTheDecimalPoint(float _floatValue)
    {
        float grindedFloat = (float)Mathf.RoundToInt(_floatValue * 10.0f) * 0.1f;

        grindedFloat = Mathf.Floor(grindedFloat * 10.0f) * 0.1f;

        return grindedFloat;
    }

    private int GetSumTendencyValue()
    {
        int sum = 0;

        for (int i = 0; i < NumberOfTendencyType; i++)
            sum += tendencyValue[i];

        return sum;
    }
}
