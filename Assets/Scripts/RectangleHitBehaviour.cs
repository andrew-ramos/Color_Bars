using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RectangleHitBehaviour : MonoBehaviour
{


    public int maxHit;
    protected int hitNumber;
    
    // Start is called before the first frame update
    void Start()
    {
        hitNumber = 0;
        GetComponentInChildren<Text>().text = maxHit.ToString();
        Debug.Log(GetComponentInChildren<Text>().text);
    }

    private void OnTriggerEnter2D(Collider2D collider)
        
    {
               
         hitNumber++;
         GetComponentInChildren<Text>().text = (maxHit-hitNumber).ToString();

        if (hitNumber == maxHit)
            {
                Destroy(gameObject);
            }
              
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
