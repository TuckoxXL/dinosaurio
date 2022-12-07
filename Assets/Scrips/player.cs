using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class player : MonoBehaviour
{
    public int fuerzadesalto = 10;
    public bool estasaltando;     
    // Start is called before the first frame update
    void Start()
    {
        estasaltando = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && estasaltando == false )
        {
            GetComponent<Rigidbody2D>().velocity = new Vector3(0,fuerzadesalto, 0);
            estasaltando=true;
        }
        if (Input.GetKeyDown(KeyCode.S) && estasaltando == true)
        {
            GetComponent<Rigidbody2D>().velocity = new Vector3(0, 0, 0);
        }
    }
 
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "piso")
        {
            estasaltando= false;
        }

        if (collision.gameObject.tag == "obstaculo")
        {
            
            SceneManager.LoadScene("Derrota");
        }

    }
}
