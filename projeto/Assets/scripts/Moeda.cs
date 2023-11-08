using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moeda : MonoBehaviour
{
    public int velocidadeGiro = 150;
   
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            FindObjectOfType<GameManager>().SubtrairMoedas(valor:1);
            Destroy(gameObject);
        }
    }
    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.forward* velocidadeGiro* Time.deltaTime);
    }
}
