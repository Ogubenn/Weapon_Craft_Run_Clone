using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [Range(0f,100f)]
    public float forwordSpeed = 10f;
    [Range(0f,20f)]
    public float sliderSpeed = 1f;

    public Touch touch;
    private Animator anim;
    public GameObject player;
    private Vector3 yon = Vector3.forward;

    private void Start()
    {
        anim.SetBool("Fist", true);
    }

    private void Awake()
    {
        anim = GetComponent<Animator>();
    }


    private void Update()
    {
        Vector3 Movement = yon * forwordSpeed * Time.deltaTime;
        transform.position += Movement;

        if(Input.touchCount > 0)
        {
            touch = Input.GetTouch(0);

            if(touch.phase == TouchPhase.Moved)
            {
                transform.position = new Vector3(transform.position.x + touch.deltaPosition.x * sliderSpeed*Time.deltaTime,
                                                 transform.position.y,
                                                 transform.position.z);
            }
        }
    }


}//class
