using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movimiento : MonoBehaviour
{
    public int speedx;
    public int direccionx;
    public GameObject balaprefab;
    public float horizontal;
    public float vertical;
    private Rigidbody2D _compRigidbody;
    
    // Start is called before the first frame update
    private void Awake()
    {
        _compRigidbody = GetComponent<Rigidbody2D>();
    }
    
    // Update is called once per frame
    void Update()
    {
        horizontal = Input.GetAxis("Horizontal");
        vertical = Input.GetAxis("Vertical");
        if (Input.GetKeyDown(KeyCode.Space) == true)
        {
            Instantiate(balaprefab, transform.position, transform.rotation);
        }
        

    }
    private void FixedUpdate()
    {
        _compRigidbody.velocity = new Vector2(horizontal * speedx, vertical * speedx);
    }
}
