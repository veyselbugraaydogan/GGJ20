using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinAmination : MonoBehaviour
{

    public GameObject particle;
    public Transform refpoint;
    private bool isCreated = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(!isCreated){
            isCreated = true;
            Instantiate(particle, refpoint.position, Quaternion.identity);
        }

    }
}
