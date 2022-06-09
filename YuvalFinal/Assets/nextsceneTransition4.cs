using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class nextsceneTransition4 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        {
            Invoke("nextscene", 3f);
        }
    }
    
    void nextscene()
    { 
        SceneManager.LoadScene(8);
    }
}