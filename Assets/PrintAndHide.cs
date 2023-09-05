using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrintAndHide : MonoBehaviour
{

    public int i = 3;
    public int RandNum1;

    public Renderer rend;

    // Start is called before the first frame update
    void Start()
    {
        RandNum1 = Random.Range(150, 250);
    }

    // Update is called once per frame
    void Update()
    {
        i++;
        Debug.Log(gameObject.name + ":" + i);
        if (gameObject.tag == "Red" && i > 100)
        {
            gameObject.SetActive(false);
        }
        if (gameObject.tag == "Blue" && i == RandNum1)
        {
            gameObject.GetComponent<Renderer>().enabled = false;
        }
        
        
    }
}
