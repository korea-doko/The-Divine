using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class OrganizationModel : MonoBehaviour
{
    public List<Organization> organizationList;

    public void Init()
    {
        organizationList = new List<Organization>();

        
    }

    public void MakeOrg(int _givenNumberOfOrg)
    {
        if (_givenNumberOfOrg == 0)
            throw new Exception();



        for (int i = 0; i < _givenNumberOfOrg; i++)
        {
            Organization o = new Organization();

            int randInitPersonNumber = UnityEngine.Random.Range(1, 5);

            for (int j = 0; j < randInitPersonNumber; j++)
            {

                Person p = PersonManager.Inst.GetRandomPerson();

                o.AddPerson(p);
            }

            organizationList.Add(o);
        }
    }
}
