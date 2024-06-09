using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.XR.Interaction.Toolkit.Inputs.Simulation;

public class MenuController : MonoBehaviour
{

    [SerializeField] XRDeviceSimulator XRDSim;
    public void StartBtn()
    {
        Destroy(XRDSim);
        SceneManager.LoadScene("Interview Scene");
    }
}
