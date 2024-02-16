using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slider : MonoBehaviour
{
    public GameObject Magazine;
    private Animator anim;
    public Magazine magazinescript;

    [Header("Levels")]
    public GameObject Level1;
    public GameObject Level2;
    public GameObject Level3;

    private void Awake()
    {
        anim = Magazine.GetComponent<Animator>();
    }

    private void Update()
    {
        if(magazinescript.magazine›ncrese›nt == 6)
        {
            anim.SetTrigger("MagazineGo");
        }
        if(magazinescript.sliderGreenBool == 2)
        {
            Level1.GetComponent<MeshRenderer>().material.color = Color.green;
        }
    }


}//class
