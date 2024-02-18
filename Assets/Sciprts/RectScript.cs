using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class RectScript : MonoBehaviour
{
    public int DamageHitNumber = 30;
    public TextMeshPro barrelNumber;

    private void OnTriggerEnter(Collider hit)
    {
        if(hit.CompareTag("Bullet"))
        {
            DamageHitNumber--;
            TextUpdate();
            if(DamageHitNumber == 0)
            {
                gameObject.SetActive(false);
            }
        }
    }

    public void TextUpdate()
    {
        barrelNumber.text = DamageHitNumber.ToString();
    }


}//class
