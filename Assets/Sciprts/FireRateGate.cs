using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class FireRateGate : MonoBehaviour
{
    public Bullet bulletScrpit;
    public TextMeshPro ›ncreasedText;
    private int ›ncraesedTextSwap = 1;


    public void OnTriggerEnter(Collider hit)
    {
        if(hit.CompareTag("Bullet"))
        {
            bulletScrpit.FireRate›ncrase();
            GateTextUpdate();
        }
    }

    public void GateTextUpdate()
    {
        ›ncraesedTextSwap += 1;
        ›ncreasedText.text = ›ncraesedTextSwap.ToString();
        
    }






}//class
