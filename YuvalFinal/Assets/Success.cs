using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Success : MonoBehaviour
{

    public void invoke()
    { 
        Invoke("nextscene", 2.0f);
    }
    
    public void nextscene()
    { 
        SceneManager.LoadScene(13);
    }

}
