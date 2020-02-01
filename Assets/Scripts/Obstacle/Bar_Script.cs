using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Bar_Script : MonoBehaviour
{
    public Image Bar;
    public float Fill;
    public Obstacle obstacle;

    void Start()
    {
        Bar.gameObject.SetActive(false);
        Bar.enabled = false;
        Bar.fillAmount = obstacle.currentTickNumber;
    }

    void Update()
    {
        if(obstacle.isFinished);
            //canvas.SetActive(false);
        else
        {
            Bar.fillAmount = obstacle.currentTickNumber;
        }
    }
	
	
}
