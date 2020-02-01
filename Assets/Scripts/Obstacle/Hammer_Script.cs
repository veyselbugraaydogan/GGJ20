using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hammer_Script : MonoBehaviour
{
	public Transform target;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(Camera.main.transform.position);
		//transform.Translate(Vector3.right * Time.deltaTime);
    }
}
