using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum EPersonJobType
{
    Jobless,
    Hunter,
    Warrior
}

public partial class Person
{
    private static readonly int numberOfPersonJobType = System.Enum.GetNames(typeof(EPersonJobType)).Length;

    public static int NumberOfPersonJobType => numberOfPersonJobType;
}

[System.Serializable]
public partial class Person 
{
    [SerializeField] private Tendency tendency;
    [SerializeField] private EPersonJobType jobType;

    public Tendency Tendency { get => tendency;}
    public EPersonJobType JobType { get => jobType; set => jobType = value; }

    public Person(EPersonJobType _type = EPersonJobType.Jobless)
    {
        this.tendency = new Tendency();
        this.jobType = _type;
    }    

    public void SetTendencyValue(ETendencyType _type, int _value)
    {
        this.Tendency.SetTendencyValue(_type, _value);
    }
    public void AddTendencyValue(ETendencyType _type, int _value)
    {
        this.Tendency.AddTendencyValue(_type, _value);
    }
    public int GetTendencyValue(ETendencyType _type)
    {
        return this.tendency.GetTendencyValue(_type);
    }
    public float GetTendencyValueRatio(ETendencyType _type)
    {
        return this.tendency.GetTendencyValueRatio(_type);
    }
}



