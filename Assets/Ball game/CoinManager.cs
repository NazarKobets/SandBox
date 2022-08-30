using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinManager : MonoBehaviour
{
    //public GameObject[] objectsArray;
    public List<myCoin> coinsList = new List<myCoin>();
    public GameObject coinPrefab;
    void Start()
    {
        for (int i = 0; i < 50; i++)
        {
            Vector3 position = new Vector3(
                Random.Range(-20f, 20f),
                0.5f,
                Random.Range(-20f, 20f)
            );

            GameObject newCoin = Instantiate(coinPrefab, position, Quaternion.identity);
            coinsList.Add(newCoin.GetComponent<myCoin>());
        }
    }

    public void CollectCoin(myCoin coin)
    {
        coinsList.Remove(coin);
    }
}