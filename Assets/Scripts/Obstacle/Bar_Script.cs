using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Bar_Script : MonoBehaviour
{
    public Image Bar;
    public float Fill;
	public bool boolean=true;

    void Start()
    {
		Bar.fillAmount=0;
    }
	
    void Update()
    {
		if(Input.GetMouseButtonDown(0))
		{
        Bar.fillAmount+=Fill;
		}
		
	
    }
	
	
}
