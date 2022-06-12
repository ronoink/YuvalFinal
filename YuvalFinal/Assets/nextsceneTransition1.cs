using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class nextsceneTransition1 : MonoBehaviour
{
    public float timenextscene = 34.0f;
    // Start is called before the first frame update
    void Start()
    {
        {
            Invoke("nextscene", timenextscene);
        }
    }
    
    void nextscene()
    { 
        SceneManager.LoadScene(5);
    }
}

