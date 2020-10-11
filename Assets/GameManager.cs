using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private void OnEnable()
    {
        Player.OnDeath += ResetPlayer;
    }
    public void ResetPlayer()
    {
        Debug.Log("Resetting Player");
    }
}
