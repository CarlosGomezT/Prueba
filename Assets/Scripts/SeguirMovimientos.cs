using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeguirMovimientos : MonoBehaviour
{
    public GameObject[] targetObject1; 
    public GameObject[] targetObject2;

    public GameObject[] objectToMove;
    public static bool Izquierda;
    public GameObject[] side1;
    public GameObject[] side2;

    private bool isTarget1Active = true;

    private void Start()
    {
        Izquierda = true;
    }
    public void ChangeSide()
    {
        if (objectToMove != null && targetObject1 != null && targetObject2 != null)
        {
            if (isTarget1Active)
            {
                for (int i = 0; i < objectToMove.Length; i++)
                {
                    objectToMove[i].transform.position = targetObject1[i].transform.position;
                }

            }
            else
            {
                for (int i = 0; i < objectToMove.Length; i++)
                {
                    objectToMove[i].transform.position = targetObject2[i].transform.position;
                }
            }
        }
    }
    public void ChangeHand()
    {
        if (objectToMove != null && targetObject1 != null && targetObject2 != null)
        {
            if (isTarget1Active)
            {
                foreach (GameObject obj in side2)
                {
                    obj.SetActive(false);
                }
                foreach (GameObject obj in side1)
                {
                    obj.SetActive(true);
                }
            }
            else
            {
                foreach (GameObject obj in side1)
                {
                    obj.SetActive(false);
                }
                foreach (GameObject obj in side2)
                {
                    obj.SetActive(true);
                }
            }
        }
    }

    public void ToggleTargets(bool side)
    {
        Izquierda = side;  
        isTarget1Active = side;
        ChangeSide();
        ChangeHand();
    }
}
