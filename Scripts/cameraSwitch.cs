using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class cameraSwitch : MonoBehaviour
{
    

    [SerializeField]
    private CinemachineVirtualCamera vcamA; // player
    [SerializeField]
    private CinemachineVirtualCamera vcamB; // group of enemy
    [SerializeField]
    private CinemachineVirtualCamera vcamC; // single enemy


    void Update()
    {
        if(Input.GetKey(KeyCode.F1)){
            vcamA.Priority = 1;
            vcamB.Priority = 0;
            vcamC.Priority = 0;
        } else if (Input.GetKey(KeyCode.F2)){
            vcamA.Priority = 0;
            vcamB.Priority = 1;
            vcamC.Priority = 0;
        } else if (Input.GetKey(KeyCode.F3)){
            vcamA.Priority = 0;
            vcamB.Priority = 0;
            vcamC.Priority = 1;
        }

    }

}

