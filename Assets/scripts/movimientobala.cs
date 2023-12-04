using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movimientobala : MonoBehaviour
{
    public int speedx = 5;

    private Rigidbody2D _compRigidbody;


    // Start is called before the first frame update
    void Start()
    {
        _compRigidbody = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update()
    {
        _compRigidbody.rotation = 270;
        _compRigidbody.velocity = new Vector2(0, speedx);


    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("muro") == true)
        {
            Destroy(this.gameObject);
            
        }
    }
}
    
