using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BACK : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Invoke("Back", 4);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Back()
    {
        SceneManager.LoadScene(0);
    }
}
