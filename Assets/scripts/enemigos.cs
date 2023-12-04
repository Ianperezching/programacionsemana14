using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemigos : MonoBehaviour
{
    private Animator _companimator;
    private void Awake()
    {
        _companimator = GetComponent<Animator>();
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("bala"))
        {
            _companimator.SetInteger("muerte", 1);
            Destroy(this.gameObject,5);
            
        }
    }
}
