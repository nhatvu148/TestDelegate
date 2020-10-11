using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class Linq : MonoBehaviour
{
    public string[] names = { "jon", "jon", "julie", "alex", "julie", "jessie", "david", "mark", "matt"};
    // Start is called before the first frame update
    void Start()
    {
        var nameFound = names.Any(name => name == "jon");
        Debug.Log(nameFound);

        var nameDistinct = names.Distinct();
        foreach (string name in nameDistinct)
        {
         //   Debug.Log(name);
        }

        var result = names.Where(n => n.Length > 5);
        foreach (string name in result)
        {
            Debug.Log(name);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
