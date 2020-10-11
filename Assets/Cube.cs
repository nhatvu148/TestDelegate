using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Main.onClick += TurnRed;
        Main.onTeleport += Spawn;
    }

    public void TurnRed()
    {
        GetComponent<MeshRenderer>().material.color = Color.blue;
    }

    public void Spawn(Vector3 pos)
    {
        transform.position = pos;
    }

    private void OnDisable()
    {
        Main.onClick -= TurnRed;
        Main.onTeleport -= Spawn;
    }
}
