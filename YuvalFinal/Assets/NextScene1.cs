using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class NextScene1 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        {
            Invoke("nextscene", 43.0f);
        }
    }
    
    void nextscene()
    { 
        SceneManager.LoadScene(2);
    }
}
