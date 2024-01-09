using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lose : MonoBehaviour
{
    public GameObject button;
    private DeathDetector _deathDetector;
    private PlayerController _player;
    private Transform _transform;
    // Start is called before the first frame update
    void Start()
    {
        _deathDetector = FindFirstObjectByType<DeathDetector>();
        _player = FindFirstObjectByType<PlayerController>();
        _transform = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        if (_deathDetector.isDead)
        {
            _transform.position = _player.transform.position +new Vector3(0,-_player.transform.position.y-1,-3);
            button.gameObject.SetActive(true);
        }
    }
}
