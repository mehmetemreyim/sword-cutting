using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SesKontrol : MonoBehaviour
{
    AudioSource ses_kontroll;
    void Start()
    {
        ses_kontroll = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (PlayerPrefs.GetInt("sesDurum") == 1)
        {
            ses_kontroll.mute = false;
        }
        else
        {
            ses_kontroll.mute = true;
        }
    }
}
