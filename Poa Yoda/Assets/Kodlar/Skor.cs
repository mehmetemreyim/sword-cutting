using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Skor : MonoBehaviour
{
    public int skor;
    public Spawner spawner;
    public TMP_Text skorObject, skorYazi, YuksekSkor, buttonText;
    public GameObject oyunBittiMenu;
    public AudioSource audioPuanAl;
    public AudioSource audioBitir;

    public void skorKazan()
    {
        audioPuanAl.Play();
        skor += 1;
        skorObject.SetText(skor.ToString());
        
    }

    public void ResetScore()
    {
        skor = 0;
        skorObject.SetText("0");

    }


    public void Start()
    {

        skorYazi.SetText("a");
        YuksekSkor.SetText(PlayerPrefs.GetInt("skor").ToString());
    }


    public void oyunSonu()
    {
        
        if(PlayerPrefs.GetInt("skor") < skor)
        {
            PlayerPrefs.SetInt("skor", skor);
        }
        //YuksekSkor.SetText(PlayerPrefs.GetInt("skor").ToString());
        
        audioBitir.Play();
        buttonText.SetText("Tekrar Dene");
        skorYazi.SetText(skor.ToString());
        YuksekSkor.SetText(PlayerPrefs.GetInt("skor").ToString());

        oyunBittiMenu.SetActive(true);
        spawner.oyunBasladiMi = false;
        
    }



}
