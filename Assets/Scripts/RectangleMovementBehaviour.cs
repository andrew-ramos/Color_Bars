using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RectangleMovementBehaviour : MonoBehaviour
{
    [SerializeField] private float movementSpeed;
    private Vector3 currentPosition = Vector3.one;

    // Start is called before the first frame update
    void Start()
    {
        
        currentPosition = transform.position;
                
    }

    

    // Update is called once per frame
    void Update()
    {
           
        currentPosition.y -= movementSpeed;
        if(currentPosition.y > -2.5)
        {
            transform.position = currentPosition;

        }
        else
        {
            GameManager.instance.gameOver(gameObject);
        }
       
            

    }
}
