using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Solution : MonoBehaviour
{

    public int solution = 0;
    public GameObject TextPopUp;

    private void Update()
    {
        SolutionFun();
    }

    public void SolutionFun()
    {
        if (solution == 8)
        {
            TextPopUp.SetActive(true);
        }
    }

}
