using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Magazine : MonoBehaviour
{
    public GameObject[] magazine;
    private int currentMagazineIndex = 0;
    public int magazineÝncreseÝnt;
    public  int sliderGreenBool;

    private void OnTriggerEnter(Collider hit)
    {
        magazineÝncreseÝnt += 1;
        if (hit.CompareTag("Bullet"))
        {
            // Þu anki endeks ile eþleþen Magazine fonksiyonunu çalýþtýr.
            switch (currentMagazineIndex)
            {
                case 0:
                    MagazineFirst();
                    break;
                case 1:
                    MagazineTwo();
                    break;
                case 2:
                    MagazineThree();
                    break;
                case 3:
                    MagazineFour();
                    break;
                case 4:
                    MagazineFive();
                    break;
                case 5:
                    MagazineSix();
                    break;
                default:
                    break;
            }

            // Diziyi bir sonraki endekse taþý.
            currentMagazineIndex++;
        }
    }

    public void DestroyMagazine()
    {
        gameObject.SetActive(false);
        sliderGreenBool += 1;
    }


    #region Magazine Fonk.
    public int MagazineFirst()
    {
        magazine[0].SetActive(false);
        magazine[1].SetActive(true);
        magazine[2].SetActive(false);
        magazine[3].SetActive(false);
        magazine[4].SetActive(false);
        magazine[5].SetActive(false);
        magazine[6].SetActive(false);
        return 1;
    }


    
    public void MagazineTwo()
    {
        magazine[0].SetActive(false);
        magazine[1].SetActive(false);
        magazine[2].SetActive(true);
        magazine[3].SetActive(false);
        magazine[4].SetActive(false);
        magazine[5].SetActive(false);
        magazine[6].SetActive(false);
    }
    public void MagazineThree()
    {
        magazine[0].SetActive(false);
        magazine[1].SetActive(false);
        magazine[2].SetActive(false);
        magazine[3].SetActive(true);
        magazine[4].SetActive(false);
        magazine[5].SetActive(false);
        magazine[6].SetActive(false);
    }
    public void MagazineFour()
    {
        magazine[0].SetActive(false);
        magazine[1].SetActive(false);
        magazine[2].SetActive(false);
        magazine[3].SetActive(false);
        magazine[4].SetActive(true);
        magazine[5].SetActive(false);
        magazine[6].SetActive(false);
    }

    public void MagazineFive()
    {
        magazine[0].SetActive(false);
        magazine[1].SetActive(false);
        magazine[2].SetActive(false);
        magazine[3].SetActive(false);
        magazine[4].SetActive(false);
        magazine[5].SetActive(true);
        magazine[6].SetActive(false);
    }

    public void MagazineSix()
    {
        magazine[0].SetActive(false);
        magazine[1].SetActive(false);
        magazine[2].SetActive(false);
        magazine[3].SetActive(false);
        magazine[4].SetActive(false);
        magazine[5].SetActive(false);
        magazine[6].SetActive(true);
    }
    #endregion


}//class
