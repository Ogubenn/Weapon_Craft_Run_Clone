using UnityEngine;

public class MagazineAnim : MonoBehaviour
{
    [Header("Anim Variables")]
    public float animationSpeed1 = 1.0f;
    public float animationSpeed2 = 1.0f;
    public float targetX = -1.5f;
    public float targetZ = 22.70f;

    private Vector3 initialPosition;
    private Vector3 targetXPos;
    private Vector3 targetZPos;
    private static int BucketSize;
    private bool isAnimatingX = false;
    private bool isAnimatingZ = false;

    public Slider sliderScript;

    [Header("Gun Bools")]
    public bool SawedOffBool = false;

    private void Start()
    {
        initialPosition = transform.position;
        targetXPos = new Vector3(targetX, initialPosition.y, initialPosition.z);
        targetZPos = new Vector3(targetX, initialPosition.y, targetZ);
    }

    public void StartAnimation()
    {
        isAnimatingX = true;
    }

    private void Update()
    {
        MagazineAnimFonk();
    }

    public void MagazineAnimFonk()
    {
        if (isAnimatingX)
        {
            float step = animationSpeed1 * Time.deltaTime;
            transform.position = Vector3.MoveTowards(transform.position, targetXPos, step);

            if (Vector3.Distance(transform.position, targetXPos) < 0.01f)
            {
                isAnimatingX = false;
                isAnimatingZ = true;
            }
        }

        if (isAnimatingZ)
        {
            float step2 = animationSpeed2 * Time.deltaTime;
            transform.position = Vector3.MoveTowards(transform.position, targetZPos, step2);

            if (Vector3.Distance(transform.position, targetZPos) < 0.01f)
            {
                isAnimatingZ = false;
               
                gameObject.SetActive(false);
                BucketSize++;
                if (BucketSize == 2)
                {
                    SawedOffBool = true;
                    sliderScript.Level1.GetComponent<MeshRenderer>().material.color = Color.green;
                }
                if (BucketSize == 4)
                {
                    sliderScript.Level2.GetComponent<MeshRenderer>().material.color = Color.green;
                }
                if (BucketSize == 6)
                {
                    sliderScript.Level3.GetComponent<MeshRenderer>().material.color = Color.green;
                }
            }
        }
    }
}
