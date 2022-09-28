using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour
{
    public GameObject objetoAspawnear;
    public float minX = 12f;
    public float maxX = 15f;
    public float Ypos = 0;
    public float mintiempoSpawn = 3f;
    public float maxtiempoSpawn = 5f;

    private void Start()
    {
        StartCoroutine(spawnObstaculo(Random.Range(mintiempoSpawn, maxtiempoSpawn),objetoAspawnear));
    }

    private IEnumerator spawnObstaculo(float intervalo,GameObject obstaculo)
    {
        yield return new WaitForSeconds(intervalo);
        Instantiate(obstaculo, new Vector3(Random.Range(minX,maxX), Ypos, 0),Quaternion.identity);
        StartCoroutine(spawnObstaculo(intervalo, obstaculo));
    }
}
