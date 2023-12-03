using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField]
    private List<GameObject> SpawnAbles;

    [SerializeField]
    private float delay;

    [SerializeField]
    private GameObject SpawnArea;

    private UnityEngine.Vector3 RandomPos;

    [Tooltip("Can enemies spawn?")]
    public bool CanElite;

    [Tooltip("How many enemies can spawn before elites")]
    public int EliteRatio;
    


    private void Start() 
    {
        EliteRatio = 0;
        CanElite = false;
        SpawnArea = gameObject;
        StartCoroutine(BeginSpawning());
        
    }

    IEnumerator BeginSpawning()
    {
        while (true)
        {
            if (!CanElite)
            {
                float Rand = Random.Range(-5, 5);
                RandomPos = new UnityEngine.Vector3(SpawnArea.transform.position.x + Rand, SpawnArea.transform.position.y, SpawnArea.transform.position.z);
                Instantiate(SpawnAbles[0], RandomPos, UnityEngine.Quaternion.Euler(0,180,0));
                yield return new WaitForSeconds(delay);
            }
            else
            {
                for (int i = EliteRatio; i > 0; i--)
                {
                    float Rand = Random.Range(-5, 5);
                    RandomPos = new UnityEngine.Vector3(SpawnArea.transform.position.x + Rand, SpawnArea.transform.position.y, SpawnArea.transform.position.z);
                    Instantiate(SpawnAbles[0], RandomPos, UnityEngine.Quaternion.Euler(0,180,0));
                    yield return new WaitForSeconds(delay);
                }
                Instantiate(SpawnAbles[1], RandomPos, UnityEngine.Quaternion.Euler(0,180,0));
                yield return new WaitForSeconds(delay);
            }
       }
        
    }

    private void Update() 
    {
        
    }
}
