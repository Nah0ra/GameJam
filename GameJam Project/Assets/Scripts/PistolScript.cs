using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class PistolScript : MonoBehaviour
{

    [SerializeField]
    private Animator FireAnim;

    public void Start()
    {
        FireAnim = GetComponent<Animator>();
    }

    public void FireGun()
    {
        FireAnim.Play("Fire");
    }

   
}
