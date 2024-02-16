using UnityEngine;

public class MagazineAnim : MonoBehaviour
{
    public float animationSpeed1 = 1.0f;
    public float animationSpeed2 = 1.0f;
    public float targetX = -1.5f;
    public float targetZ = 22.70f;

    private Vector3 initialPosition; 
    private Vector3 targetXPos;
    private Vector3 targetZPos;
    public bool isAnimatingX = false;
    private bool isAnimatingZ = false;

    private void Start()
    {
        initialPosition = new Vector3(transform.position.x, transform.position.y, transform.position.z); 
        targetXPos = new Vector3(targetX, initialPosition.y, initialPosition.z);
        targetZPos = new Vector3(targetX, initialPosition.y, targetZ);
    }

    private void Update()
    {
        if (isAnimatingX)
        {
            float step = animationSpeed1 * Time.deltaTime;
            transform.position = Vector3.MoveTowards(transform.position, targetXPos, step);

            if (transform.position == targetXPos)
            {
                isAnimatingX = false;
                isAnimatingZ = true; 
            }
        }

        if (isAnimatingZ)
        {
            float step2 = animationSpeed2 * Time.deltaTime;
            transform.position = Vector3.MoveTowards(transform.position, targetZPos, step2);

            if (transform.position == targetZPos)
            {
                isAnimatingZ = false;
                Debug.Log("Animasyon tamamlandý.");
                gameObject.SetActive(false);
            }
        }
    }

    public void StartAnimation()
    {
        isAnimatingX = true;
        Debug.Log("X ekseninde animasyon baþladý.");
    }
}
