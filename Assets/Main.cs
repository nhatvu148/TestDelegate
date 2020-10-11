using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main : MonoBehaviour
{
    public delegate void ActionClick();
    public static event ActionClick onClick;
    public void ButtonClick()
    {
        if (onClick != null)
        {
            onClick();
        }
    }

    public delegate void Teleport(Vector3 pos);
    public static event Teleport onTeleport;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (onTeleport != null)
            {
                Vector3 pos = new Vector3(2, 3, 5);
                onTeleport(pos);
            }
        }
    }
}
