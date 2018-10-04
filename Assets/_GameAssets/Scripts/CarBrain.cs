using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarBrain : MonoBehaviour {
    [SerializeField] int speed = 5;
    [SerializeField] int speedRotation = 5;
    int marcha = 1;
	
	void Update () {
        transform.Translate(Vector3.forward * Time.deltaTime * speed * marcha);
        if (marcha == -1)
        {
            transform.Rotate(Vector3.up * Time.deltaTime * speedRotation);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Pared")
        {
            //He colisionado contra la pared
            marcha = marcha * -1;
        }
        if (collision.gameObject.tag == "Target")
        {
            //He encontrado el objetivo, me detengo
            Debug.Log("FERNANDO HA ENCONTRADO EL OBJETIVO");
            marcha = 0;
        }
    }
}
