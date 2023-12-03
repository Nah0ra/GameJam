using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField]
    private List<GameObject> SpawnAbles;

    [SerializeField]
    private GameObject SpawnArea;

    private UnityEngine.Vector3 RandomPos;


    private void Start() 
    {
        SpawnArea = gameObject;
        StartCoroutine(BeginSpawning());
        
    }

    IEnumerator BeginSpawning()
    {
        while (true)
        {
            int size = SpawnAbles.Count - 1;
            float Rand = Random.Range(-5, 5);
            RandomPos = new UnityEngine.Vector3(SpawnArea.transform.position.x + Rand, SpawnArea.transform.position.y, SpawnArea.transform.position.z);
            Instantiate(SpawnAbles[0], RandomPos, UnityEngine.Quaternion.Euler(0,180,0));
            yield return new WaitForSeconds(3);
        }
        
    }

    private void Update() 
    {
        
    }
}
