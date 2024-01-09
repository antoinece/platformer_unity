using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallRight : MonoBehaviour
{
    public bool toutchingWall;
    
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Ground")||other.gameObject.CompareTag("enemy"))
        {
            toutchingWall = true;
        }
    }
    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Ground")||other.gameObject.CompareTag("enemy"))
        {
            toutchingWall = false;
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
