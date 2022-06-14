using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class NextsceneTransitionLast : MonoBehaviour
{
    public void nextscene()
    { 
        SceneManager.LoadScene(0);
    }
}