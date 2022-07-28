using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    [SerializeField] GameObject[] rectangles;
    private string[] colors = new[] { "Blue", "Green", "Pink", "Red", "Yellow" }; 

    public static GameManager instance;

    

    private void Awake()
    {
        if (instance == null)
        { //se a variável estática estiver nula
            instance = this; //atribui o objeto GameManager a variável estática
            DontDestroyOnLoad(gameObject); //define que o objeto não deve ser destruído
        }
        else if (instance != this) // se a variável for diferente de this quer dizer que já foi criada previamente
        {
            Destroy(gameObject); //desetrói esse "segundo" objeto
        }
    }

    private void Start()
    {

        InvokeRepeating("rectangleCreator",2f,1.5f);       

    }
    public void gameOver(GameObject retangulo)
    {
        Destroy(retangulo);
        Debug.Log("Não destruiu a tempo");
    }
    private void Update()
    {
        
    }



    public void rectangleCreator()
    {
        string color = colors[UnityEngine.Random.Range(0, 4)];
        int destroyHits = UnityEngine.Random.Range(1, 6);

        if (color == "Blue")
        {
            GameObject rectangle = Instantiate(rectangles[0]);
            rectangle.GetComponent<RectangleHitBehaviour>().maxHit = destroyHits;
            Debug.Log("Estou passando por aqui!");
        }

        if (color == "Green")
        {
            GameObject rectangle = Instantiate(rectangles[1]);
            rectangle.GetComponent<RectangleHitBehaviour>().maxHit = destroyHits;
        }

        if (color == "Pink")
        {
            GameObject rectangle = Instantiate(rectangles[2]);
            rectangle.GetComponent<RectangleHitBehaviour>().maxHit = destroyHits;
        }

        if (color == "Red")
        {
            GameObject rectangle = Instantiate(rectangles[3]);
            rectangle.GetComponent<RectangleHitBehaviour>().maxHit = destroyHits;
        }

        if (color == "Yellow")
        {
            GameObject rectangle = Instantiate(rectangles[4]);
            rectangle.GetComponent<RectangleHitBehaviour>().maxHit = destroyHits;
        }

        
    }


}
