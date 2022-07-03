using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Intro: MonoBehaviour {
    float fade;
    SpriteRenderer sp;
    Color color;
    bool bFadeIn = false;

    GameObject SceneManager;

    // Start is called before the first frame update
    void Start() {
        fade = 0f;
        sp = GetComponent<SpriteRenderer>();
        color = new Color(1f, 1f, 1f, 0f);
        SceneManager = GameObject.Find("SceneManager");
    }

    // Update is called once per frame
    void Update() {
        color.a = fade;
        sp.color = color;// new Color(1f, 1f, 1f, fade);
        if (!bFadeIn) { 
             fade += (0.45f * Time.deltaTime);
 
            if (fade > 1f) { fade = 1f; bFadeIn = true; }
        }
        else {
            fade -= (0.45f * Time.deltaTime);
            if (fade < 0f) { fade = 0f;  SceneManager.GetComponent<SceneManager>().introisover(); }
        }
    }
}
