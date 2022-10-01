using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public void Startgame()
    {
        oyunBasladiMi = true;
    }

    public void EndGame()
    {
        Application.Quit();
    }

    public bool oyunBasladiMi;
    public float minSure, maxSure;
    
    int sayac;
    // Update is called once per frame

    public GameObject[] objelerListesi;
    void Update()
    {

        if (oyunBasladiMi == true && objeSpawnCoroutine==null)
        {
          
            objeSpawnCoroutine = StartCoroutine(objeSpawn(Random.Range(minSure, maxSure)));
            sayac++;
        }
        
    }

    Coroutine objeSpawnCoroutine = null;

    IEnumerator objeSpawn(float zaman)
    {
        int rastgeleSayi = Random.Range(0, objelerListesi.Length);
        GameObject objeler = Instantiate(objelerListesi[rastgeleSayi],gameObject.transform.position+new Vector3(Random.Range(0,3.5f),0,0),Quaternion.identity);
        yield return new WaitForSeconds(zaman);
        objeSpawnCoroutine = null;
    }


}
