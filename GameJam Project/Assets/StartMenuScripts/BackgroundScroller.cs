using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Background_Scroll : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] float scrollSpeed = 0.02f;
    // Material from the texture
    Material backgroundMaterial;
    // the movement
    Vector2 offset;
    void Start()
    {
        backgroundMaterial = GetComponent<MeshRenderer>().material;

        offset = new Vector2(0f, scrollSpeed);
    }

    // Update is called once per frame
    void Update()
    {
        backgroundMaterial.mainTextureOffset += offset * Time.deltaTime;


    }
}
