using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Pool;
using static UnityEngine.GraphicsBuffer;

public class obstaculo : MonoBehaviour
{
    public Rigidbody2D piedra;
    public float piedraSpeed;

    private void OnEnable()
    {
        piedra.velocity = Vector2.left * piedraSpeed;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("cayo");
        gameObject.SetActive(false);
    }
}
