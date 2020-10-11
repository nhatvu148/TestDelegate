using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // public delegate void OnDeath();
    // public static event OnDeath onDeath;
    public static Action OnDeath; // same as delegate

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(MyRoutine(() =>
        {
            Debug.Log("Hello World!");
        }));
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Death();
        }
    }

    void Death()
    {
        if (OnDeath != null)
        {
            OnDeath();
        }
    }

    public IEnumerator MyRoutine(Action onComplete = null)
    {
        while (true)
        {
            yield return new WaitForSeconds(2.0f);
            if (onComplete != null)
            {
                onComplete();
            }
        }

    }
}
