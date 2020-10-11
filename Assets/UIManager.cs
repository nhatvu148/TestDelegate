using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public int deathCount;
    [SerializeField]
    public Text deathCountText;

    public void OnEnable()
    {
        Player.OnDeath += UpdateDeathCount;
    }

    public void UpdateDeathCount()
    {
        Debug.Log(deathCountText);
        deathCount++;
        deathCountText.text = "Death Count: " + deathCount;
    }
}
