using System.Collections;
using System.Collections.Generic;
using Cinemachine;
using UnityEngine;

public class Player : MonoBehaviour
{
    private GameObject CinematicCutscene;

    private GameObject PlayerCam;

    private GameObject Gun;

    private GameObject Hammer;

    private GameObject GunHolster;

    private GameObject HammerHolster;

    private void Start() 
    {
        CinematicCutscene = GameObject.Find("CinematicCutscene");
        PlayerCam = GameObject.Find("Main Camera");
        PlayerCam.SetActive(false);
        StartCoroutine(SwitchCam());
        Gun = GameObject.Find("Pistol");
        Hammer = GameObject.Find("Hammer");
        GunHolster = GameObject.Find("GunHolster");
        HammerHolster = GameObject.Find("HammerHolster");
    }

    public void ReturnToHolster()
    {
        Gun.transform.position = GunHolster.transform.position;
        Hammer.transform.position = HammerHolster.transform.position;
    }


    IEnumerator SwitchCam()
    {
        yield return new WaitForSeconds(28);
        CinematicCutscene.SetActive(false);
        PlayerCam.SetActive(true);
    }
}
