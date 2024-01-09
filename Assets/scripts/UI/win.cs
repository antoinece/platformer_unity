using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class win : MonoBehaviour
{
    private arivee _arivee;
    private PlayerController _player;
    public Transform transforme;
    public GameObject button;
    // Start is called before the first frame update
    void Start()
    {
        _arivee = FindFirstObjectByType<arivee>();
        _player = FindFirstObjectByType<PlayerController>();
        transforme = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        if (_arivee.youWin)
        {
            transforme.position = _player.transform.position +new Vector3(0,-_player.transform.position.y,-4);
            button.gameObject.SetActive(true);
        }
    }
}
