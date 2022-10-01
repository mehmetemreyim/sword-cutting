using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KiliclandiMi : MonoBehaviour
{

    public Skor skorObject;
    
    
    void OnTriggerEnter2D(Collider2D temasEdilen)
    {
        if (temasEdilen.gameObject.CompareTag("Kurabiye"))
        {
            skorObject.skorKazan();
            Destroy(temasEdilen.gameObject);
        }

        else if (temasEdilen.gameObject.CompareTag("Darth"))
        {
            skorObject.skorKazan();
            Destroy(temasEdilen.gameObject);
        }

        else if (temasEdilen.gameObject.CompareTag("Donut"))
        {
            skorObject.skorKazan();
            Destroy(temasEdilen.gameObject);
        }

        else if (temasEdilen.gameObject.CompareTag("Trooper"))
        {
            skorObject.skorKazan();
            Destroy(temasEdilen.gameObject);
        }

        else if (temasEdilen.gameObject.CompareTag("Bomba"))
        {
            skorObject.oyunSonu();
            Destroy(temasEdilen.gameObject);
        }





    }
}
