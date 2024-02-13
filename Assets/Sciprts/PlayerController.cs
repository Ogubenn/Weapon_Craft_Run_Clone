using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [Range(0f,100f)]
    public float forwordSpeed = 10f;

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
    }


}//class
