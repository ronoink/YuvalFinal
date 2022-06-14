using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class nextsceneTransition2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        {
            Invoke("nextscene", 8.5f);
        }
    }
    
    void nextscene()
    { 
        SceneManager.LoadScene(6);
    }
}