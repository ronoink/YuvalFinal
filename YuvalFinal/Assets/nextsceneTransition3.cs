using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class nextsceneTransition3 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        {
            Invoke("nextscene", 6f);
        }
    }
    
    void nextscene()
    { 
        SceneManager.LoadScene(7);
    }
}