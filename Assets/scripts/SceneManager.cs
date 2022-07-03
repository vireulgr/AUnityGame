using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneManager : MonoBehaviour
{

    GameObject Intro;
    GameObject Menu;
    // Start is called before the first frame update
    void Start()
    {
        Intro = GameObject.Find("zast");
        Menu = GameObject.Find("Menu");
    }

    // Update is called once per frame
    void Update()
    {
       
    }

   public  void introisover() {
        Menu.transform.position = new Vector3(0f, 0f, 0f);
    }
}
