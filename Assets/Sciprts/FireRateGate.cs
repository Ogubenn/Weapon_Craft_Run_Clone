using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class FireRateGate : MonoBehaviour
{
    public Bullet bulletScrpit;
    public TextMeshPro ÝncreasedText;
    private int ÝncraesedTextSwap = 1;


    public void OnTriggerEnter(Collider hit)
    {
        if(hit.CompareTag("Bullet"))
        {
            bulletScrpit.FireRateÝncrase();
            GateTextUpdate();
        }
        if (hit.gameObject.CompareTag("Gun"))
        {
            Debug.Log("FireRateUpdate gerçekleþti");
            bulletScrpit.FireRateUpdate();
            gameObject.SetActive(false);
        }
    }

    public void GateTextUpdate()
    {
        ÝncraesedTextSwap += 1;
        ÝncreasedText.text = ÝncraesedTextSwap.ToString();
        
    }






}//class
