using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sphere : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Main.onClick += Fall;
        Main.onTeleport += Spawn;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Fall()
    {
        GetComponent<Rigidbody>().useGravity = true;
    }

    public void Spawn(Vector3 pos)
    {
        transform.position = pos;
    }
}
