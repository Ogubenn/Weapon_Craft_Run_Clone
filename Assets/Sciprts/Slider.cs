using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slider : MonoBehaviour
{
    [Header("Levels")]
    public GameObject Level1;
    public GameObject Level2;
    public GameObject Level3;
    private BoxCollider bc;
    public GameObject playerSawedOff;
    public MagazineAnim magazineAnimScript;

    private void Awake()
    {
        bc = GetComponent<BoxCollider>();
    }

    private void OnTriggerEnter(Collider hit)
    {
        if(hit.CompareTag("Gun") && magazineAnimScript.SawedOffBool)
        {
            playerSawedOff.SetActive(true);
        }
    }


}//class
