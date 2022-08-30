using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForTest : MonoBehaviour
{
    public GameObject boxPrefab;
    public Material materialA;
    public Material materialB;

    void Start()
    {
        //for (int i = 0; i < 50; i++)
        //{
        //    Instantiate(boxPrefab, new Vector3(i, 0, 0), Quaternion.identity);
        //}
        StartCoroutine(CreateCube());
    }

    IEnumerator CreateCube()
    {
        for (int i = 0; i < 10; i++)
        {
            for (int k = 0; k < 10; k++)  
            {

            
                for (int j = 0; j < 10; j++)
                {
                    yield return new WaitForSeconds(0.001f);
                    GameObject newBox = Instantiate(boxPrefab, new Vector3(i, k, j), Quaternion.identity);

                    if (Random.Range(0, 2) == 0)
                    {
                        newBox.GetComponent<Renderer>().material = materialA;
                    }
                    else
                    {
                        newBox.GetComponent<Renderer>().material = materialB;

                    }
                }
            }
        }
    }
}
