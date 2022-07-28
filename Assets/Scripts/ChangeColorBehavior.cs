using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColorBehavior : MonoBehaviour
{
    
    protected Transform currentPosition;
    protected Vector2 nextPosition;
    private string actualColor;
    private int cannonPosition;


    
    private void Start()
    {
        cannonPosition = 2;
            }

               
    

    // Update is called once per frame
    void Update()
    {
                
       if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            if(cannonPosition > 0)
            {
                //Debug.Log("objeto: " + transform.gameObject);
               transform.position += Vector3.left * 1.41f;
                
                cannonPosition--;
               
            }            
            
            
        }

        if (Input.GetKeyDown(KeyCode.RightArrow))
        {

            if(cannonPosition < 4)
            {
                transform.position += Vector3.right * 1.41f;
                cannonPosition++;
                
            }
            
            
        }

        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            actualColor = CheckActualColor(cannonPosition);
            GetComponentInChildren<Animator>().SetTrigger("shoot");
            GetComponentInChildren<CannonShootBehaviour>().CannonShoot(CheckActualColor(cannonPosition));
            

        }


    }


    private string CheckActualColor(int pos)
    {
        switch (pos)
        {
            case 0:
                return "Blue";
            case 1:
                return "Green";
            case 2:
                return "Yellow";
            case 3:
                return "Red";
            case 4:
                return "Pink";
            default:
                return null;

        }
            
    }

}
