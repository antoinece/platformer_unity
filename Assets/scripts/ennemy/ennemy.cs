using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour
{
    [SerializeField]private bool _goingLeft;
    private Rigidbody2D _rb;
    private SpriteRenderer _sr;
    private GravityManager _gravityManager;
    private WallLeft _wallLeft;
    private WallRight _wallRight;
    private GroundLeft _groundLeft;
    private GroundRight _groundRight;
    // Start is called before the first frame update
    void Start()
    {
        _goingLeft = true;
        _rb = GetComponent<Rigidbody2D>(); 
        _sr = GetComponent<SpriteRenderer>();
        _gravityManager = FindFirstObjectByType<GravityManager>();
        _wallLeft = GetComponentInChildren<WallLeft>();
        _wallRight = GetComponentInChildren<WallRight>();
        _groundLeft = GetComponentInChildren<GroundLeft>();
        _groundRight = GetComponentInChildren<GroundRight>();
    }

    // Update is called once per frame
    void Update()
    {
        _rb.velocityX = _goingLeft ? -1 : 1;
        _sr.flipX = _goingLeft;
        _sr.flipY = _gravityManager.UpsideDown;
        if (_wallLeft.toutchingWall)
        {
            _goingLeft = false;
        }
        if (_wallRight.toutchingWall)
        {
            _goingLeft = true;
        }

        if (_groundLeft.notToutchingGround&&_groundRight.notToutchingGround)
        {
            
        }
        else
        {
            if (_groundLeft.notToutchingGround)
            {
                _goingLeft = false;
            }
            if (_groundRight.notToutchingGround)
            {
                _goingLeft = true;
            }
        }
        
    }
}
