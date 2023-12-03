using System.Collections;
using System.Collections.Generic;
using Cinemachine;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField]
    private GameObject CinematicCutscene;

    [SerializeField]
    private GameObject PlayerCam;

    private void Start() 
    {
        CinematicCutscene = GameObject.Find("CinematicCutscene");
        PlayerCam = GameObject.Find("Main Camera");
        PlayerCam.SetActive(false);
        StartCoroutine(SwitchCam());
    }


    IEnumerator SwitchCam()
    {
        yield return new WaitForSeconds(28);
        CinematicCutscene.SetActive(false);
        PlayerCam.SetActive(true);
    }
}
