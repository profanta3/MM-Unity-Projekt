using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class verhalten : MonoBehaviour
{

    public Transform myPrefab;
    public int anzahl;

    // Start is called before the first frame update
    void Start()
    {
        int randX, randY;
        bool[,] arr = new bool[9,9];
        for (int i = 0; i < 9; i++)
        {
            for (int j = 0; j < 9; j++)
            {
                arr[i, j] = false;
            }
        }      

        for (int i = 0; i < anzahl; i++)
        {
            randX = Random.Range(0, 9);
            randY = Random.Range(0, 9);
            while (arr[randX, randY])
            {
                randX = Random.Range(0, 9);
                randY = Random.Range(0, 9);
            }
            Instantiate(myPrefab, new Vector3(randX-4, 0.5f, randY-4), Quaternion.identity);

            arr[randX, randY] = true;
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
