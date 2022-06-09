using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class nextsceneTransition1 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        {
            Invoke("nextscene", 25.0f);
        }
    }
    
    void nextscene()
    { 
        SceneManager.LoadScene(5);
    }
}

