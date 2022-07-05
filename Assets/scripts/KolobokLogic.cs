using UnityEngine;
using System;

public class KolobokLogic : MonoBehaviour {
    double param = 0.0;
    double coeff = 0.1;
    double coeff2 = 3.0;

    Transform myTransformRef;
    // Start is called before the first frame update
    void Start() {
        myTransformRef = gameObject.GetComponent<Transform>();
        myTransformRef.Translate(-7.0f, 0.0f, 0.0f);
    }

    // Update is called once per frame
    void Update() {
        param += coeff2 * Time.deltaTime;

        float coordX = (float)(coeff*Math.Sin(param));
        float coordY = (float)(coeff*Math.Cos(param));

        myTransformRef.Translate(coordX, coordY, 0.0f);
    }
}
