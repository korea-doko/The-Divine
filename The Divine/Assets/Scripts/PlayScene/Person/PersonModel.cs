using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PersonModel : MonoBehaviour
{
    public List<Person> personPool;
    public List<Person> activeList;

    public void Init()
    {
        personPool = new List<Person>();
        activeList = new List<Person>();

    }
    public Person GetPerson()
    {
        
        Person p = personPool[0];
        personPool.RemoveAt(0);
        activeList.Add(p);

        return p;
    }

    public void MakePersonPool(int _number)
    {        
        for(int i = 0; i < _number; i++)
        {
            Person p = new Person();
            personPool.Add(p);
        }
    }    
}
