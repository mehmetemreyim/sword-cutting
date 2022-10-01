using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Taban : MonoBehaviour
{
    public Skor skorObject;

    void OnTriggerEnter2D(Collider2D temasEdilen)
    {
        if (temasEdilen.gameObject.CompareTag("Kurabiye"))
        {
            skorObject.oyunSonu();
            Destroy(temasEdilen.gameObject);
        }

        else if (temasEdilen.gameObject.CompareTag("Darth"))
        {
            skorObject.oyunSonu();
            Destroy(temasEdilen.gameObject);
        }

        else if (temasEdilen.gameObject.CompareTag("Donut"))
        {
            skorObject.oyunSonu();
            Destroy(temasEdilen.gameObject);
        }

        else if (temasEdilen.gameObject.CompareTag("Trooper"))
        {
            skorObject.oyunSonu();
            Destroy(temasEdilen.gameObject);
        }

        else if (temasEdilen.gameObject.CompareTag("Bomba"))
        {
            skorObject.skorKazan();
            Destroy(temasEdilen.gameObject);
        }







    }
}
