using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bolinha : MonoBehaviour
{
    private Rigidbody2D rb;
    public Vector2 direcao;
    public int velocidade = 10;
    // Start is called before the first frame update
    void Start()
    {
        TryGetComponent(out rb);
        direcao = Random.insideUnitCircle;
    }

    // Update is called once per frame

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("bloco")){
            Destroy(collision.gameObject);
            GameManagerB.instance.SubitrairTijolo();
        }
            Destroy(collision.gameObject);
            direcao = Vector2.Reflect(direcao, collision.contacts[0].normal);
    }
    void Update()
    {
        rb.velocity = direcao.normalized * velocidade;
    }
}
