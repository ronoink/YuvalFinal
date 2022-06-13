using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Solution : MonoBehaviour
{

    public int solution = 0;
    public GameObject TextPopUp;

    private void Update()
    {
        SolutionFun();
    }

    public void SolutionFun1()
    {
       
        SceneManager.LoadScene(18);
        
    }
    
    public void SolutionFun()
    {
        if (solution == 8)
        {
            TextPopUp.SetActive(true);
            Invoke("SolutionFun1" , 1f);
        }
    }



}
