using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coche : MonoBehaviour {

    [SerializeField] int speed = 20;
    [SerializeField] int speedRotation = 12;
    float marcha = 1;
    int ranRot;
	
	void Update () {
        transform.Translate (Vector3.forward * Time.deltaTime * speed * marcha);
        if (marcha == -1)
        {
            transform.Rotate(Vector3.up * Time.deltaTime * speedRotation);
        }
	}

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag ("Pared"))
        {
            marcha = marcha * -1;
            ranRot = Mathf.RoundToInt (Random.Range(-12, 12));
            speedRotation = Random.Range (speedRotation, speedRotation + 5 * ranRot);
        }
        if (collision.gameObject.CompareTag("Target"))
        {
            speed= 0;
            Debug.Log("JORGE HA ENCONTRADO EL OBJETIVO");
        }
    }
}
