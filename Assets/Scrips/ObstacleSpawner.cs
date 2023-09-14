using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Pool;
using static UnityEngine.GraphicsBuffer;

public class ObstacleSpawner : MonoBehaviour
{

    public void Start()
    {
        spawnear();
    }
    private void spawnear()
    {
        GameObject obstaculo = objetPool.SharedInstance.GetPooledObject();

        if (obstaculo != null)
        {
            obstaculo.transform.position = transform.position; 
            obstaculo.SetActive(true);
            Invoke("spawnear", Random.Range(1.5f,3f));
        }
    }
}
