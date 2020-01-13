using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using System;



[System.Serializable]
public class Organization 
{
    
    public event EventHandler OnPeopleChanged;
    

    [SerializeField] private Dictionary<EPersonJobType, List<Person>> personPerJobDic;
    [SerializeField] private Tendency baseTendency;
    [SerializeField] private int numberOfMembers;


    public Organization()
    {

        this.baseTendency = new Tendency();
        this.personPerJobDic = new Dictionary<EPersonJobType, List<Person>>();
        this.numberOfMembers = 0;


        int numberOfPersonJob = Person.NumberOfPersonJobType;

        for(int i = 0; i < numberOfPersonJob;i++)
        {
            List<Person> personList = new List<Person>();
            EPersonJobType jobType = (EPersonJobType)i;
            personPerJobDic.Add(jobType, personList);
        }

        OnPeopleChanged += Organization_OnPeopleChanged;
    }

    

    public List<Person> GetPersonListByJob(EPersonJobType _personJobType)
    {
        return personPerJobDic[_personJobType];
    }
    public void AddPerson(Person _person)
    {
        EPersonJobType jopType = _person.JobType;
        personPerJobDic[jopType].Add(_person);
        this.numberOfMembers++;

        OnPeopleChanged(this, EventArgs.Empty);
    }

    
    private void CalculateBaseTendency()
    {
        baseTendency.ClearTendencyValue();

        for(int i = 0; i < Person.NumberOfPersonJobType;i++)
        {
            EPersonJobType jobType = (EPersonJobType)i;
            List<Person> personList = GetPersonListByJob(jobType);

            for(int pIndex = 0; pIndex < personList.Count; pIndex++)
            {
                Person p = personList[pIndex];

                for (int tendencyIndex = 0; tendencyIndex < Tendency.NumberOfTendencyType; tendencyIndex++)
                {
                    ETendencyType tendencyType = (ETendencyType)tendencyIndex;

                    int value = p.GetTendencyValue(tendencyType);

                    baseTendency.AddTendencyValue(tendencyType, value);
                }
            }
        }
    }
  

    /// 
    /// Belows are eventHandlers
    /// 
    private void Organization_OnPeopleChanged(object sender, EventArgs e)
    {
        CalculateBaseTendency();
    }

}
