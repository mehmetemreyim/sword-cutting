using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mekanik : MonoBehaviour
{

    public GameObject Kilic, Hedef;
    public float hiz,geriCekmeHizi;
    private Vector3 baslangic;
    public AudioSource audioS;
    
    // Start is called before the first frame update
    void Start()
    {
        baslangic = Kilic.transform.position;
    }

    bool tusaBasildi;
    bool hedefeVarildi;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            audioS.Play();
            tusaBasildi = true;
        }

        if (tusaBasildi == true)
        {
            
            Kilic.transform.position = Vector3.MoveTowards(Kilic.transform.position, Hedef.transform.position, hiz * Time.deltaTime);
        }

        if (Kilic.transform.position == Hedef.transform.position)
        {
            hedefeVarildi = true;
        }

        if (hedefeVarildi == true)
        {
            Kilic.transform.position = Vector3.MoveTowards(Kilic.transform.position, baslangic , geriCekmeHizi * Time.deltaTime);
        }

        if (Kilic.transform.position == baslangic)
        {
            hedefeVarildi = false;
            tusaBasildi = false;
        }

    }
}
