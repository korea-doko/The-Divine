using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PersonManager : MonoBehaviour
{
    private static PersonManager inst;
    public static PersonManager Inst { get => inst; }
    public PersonManager(){ inst = this; }

    [SerializeField] private PersonModel model;
    [SerializeField] private readonly int numberOfRegenPerson = 100;
    [SerializeField] private readonly int basePersonTendencyAmount = 10;

    private void Awake()
    {
        model.Init();

        model.MakePersonPool(numberOfRegenPerson);
    } 

    public Person GetRandomPerson()
    {
        Person p = GetPersonWithTendency();

        EPersonJobType jobType = (EPersonJobType)UnityEngine.Random.Range(0, Person.NumberOfPersonJobType);

        p.JobType = jobType;

        return p;
    }

    public Person GetPerson(EPersonJobType _type)
    {
        Person p = GetPersonWithTendency();
        p.JobType = _type;
        return p;
    }

    private Person GetPersonWithTendency()
    {
        if (model.personPool.Count <= 0)
            model.MakePersonPool(numberOfRegenPerson);

        Person p = model.GetPerson();

        int amount = basePersonTendencyAmount;
        
        while(amount > 0)
        {
            ETendencyType randType = (ETendencyType)UnityEngine.Random.Range(0, Tendency.NumberOfTendencyType);
            p.AddTendencyValue(randType, 1);

            amount--;
        }

        return p;
    }

 
}
