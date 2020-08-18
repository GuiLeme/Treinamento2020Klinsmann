using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour
{
    public GameObject toDestroy;

    // Start is called before the first frame update
    void Start()
    {
        Destroy(toDestroy);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
