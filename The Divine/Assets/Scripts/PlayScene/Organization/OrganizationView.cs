using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrganizationView : MonoBehaviour
{
    public OrganizationPanel organizationPanel;

    public void Init(OrganizationModel model)
    {
        organizationPanel.Init();
    }

    public void Show(OrganizationModel _model)
    {
        organizationPanel.Show(_model);
    }
}
