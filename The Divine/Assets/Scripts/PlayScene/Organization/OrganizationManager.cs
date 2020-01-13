using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrganizationManager : MonoBehaviour
{
    private static OrganizationManager inst;
    public static OrganizationManager Inst { get => inst; }
    public OrganizationManager() { inst = this; }

    [SerializeField] private OrganizationModel model;
    [SerializeField] private OrganizationView view;

   
    private void Awake()
    {
        model.Init();
        view.Init(model);
    }
    private void Start()
    {
        MakeOrgByDataPrevScene();

    }
    private void Update()
    {
        if( Input.GetKeyDown(KeyCode.T))
            ShowOrganization();
        
    }
    public void ShowOrganization()
    {
        view.Show(model);
    }

    /// <summary>
    /// Make the number of Org by given datas 
    /// from prevScene which is selected by player
    /// </summary>
    private void MakeOrgByDataPrevScene()
    {
        Debug.Log("Need to balance difficult Type");

        int givenNumberOfOrg = 2 * (1 + (int)InfoManager.Inst.DifficultyType);
        model.MakeOrg(givenNumberOfOrg);
    }
}
