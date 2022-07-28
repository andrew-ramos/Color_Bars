using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonShootBehaviour : MonoBehaviour
{
    [SerializeField] GameObject[] cannonBalls;

    [SerializeField] protected float projectileSpeed;

    public void CannonShoot(string color)
    {


        if (color == "Blue")
        {
            GameObject cannonball = Instantiate(cannonBalls[0]);
            cannonball.transform.position = transform.position;
            cannonball.GetComponent<ProjectileBehaviour>().Shoot(Vector2.up, projectileSpeed);

        }

        if (color == "Green")
        {
            GameObject cannonball = Instantiate(cannonBalls[1]);
            cannonball.transform.position = transform.position;
            cannonball.GetComponent<ProjectileBehaviour>().Shoot(Vector2.up, projectileSpeed);

        }
        if (color == "Pink")
        {
            GameObject cannonball = Instantiate(cannonBalls[2]);
            cannonball.transform.position = transform.position;
            cannonball.GetComponent<ProjectileBehaviour>().Shoot(Vector2.up, projectileSpeed);

        }

        if (color == "Red")
        {
            GameObject cannonball = Instantiate(cannonBalls[3]);
            cannonball.transform.position = transform.position;
            cannonball.GetComponent<ProjectileBehaviour>().Shoot(Vector2.up, projectileSpeed);

        }
        if (color == "Yellow")
        {
            GameObject cannonball = Instantiate(cannonBalls[4]);
            cannonball.transform.position = transform.position;
            cannonball.GetComponent<ProjectileBehaviour>().Shoot(Vector2.up, projectileSpeed);



            Debug.Log("Dando tiro da cor " + color);
        }




    }
}