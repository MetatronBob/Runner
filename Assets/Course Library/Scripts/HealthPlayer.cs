using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthPlayer : MonoBehaviour
{
    private float health;
    public Slider sl;
    public Text txDie;
    // Start is called before the first frame update
    void Start()
    {
        txDie.enabled = false;
        health =sl.value;
    }
    void OnCollisionEnter(Collision other)
    {
        if (other.transform.tag == "hp")
        {
            sl.value -= 25;
            Destroy(other.gameObject);
            if (sl.value == 0)
            {
                sl.gameObject.transform.Find("Fill Area").Find("Fill").GetComponent<Image>().enabled = false;
                txDie.enabled = true;
            }
        }
       
             // Do stuff
     }
    // Update is called once per frame
    void Update()
    {
       
    }
}
