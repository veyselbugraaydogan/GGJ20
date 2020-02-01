using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Bar_Script : MonoBehaviour
{
    public Image Bar;
    public float Fill;
    public Obstacle obstacle;

    void Update()
    {
        Bar.fillAmount = obstacle.currentTickNumber;
    }
	
	
}
