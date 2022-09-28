using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Piso : MonoBehaviour
{
    public int offsetx = -26;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position -= new Vector3(6 * Time.deltaTime, 0, 0);

        if(transform.position.x <= -offsetx)
        {
            transform.position = new Vector3(26, transform.position.y, 0);

        }
    }
}
