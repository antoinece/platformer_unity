using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathDetector: MonoBehaviour
{
    public bool isDead;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("death")||other.gameObject.CompareTag("enemy"))
        {
            isDead = true;
        }
    }
}
