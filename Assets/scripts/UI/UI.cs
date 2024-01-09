using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;


public class UI : MonoBehaviour
{
    public TextMeshProUGUI score;
    public TextMeshProUGUI button;
    private arivee _arivee;
    
    private int _coins = 0;
    
    // Start is called before the first frame update
    void Start()
    {
        _arivee = FindFirstObjectByType<arivee>();
    }

    public void AddCoin()
    {
        _coins++;
    }
    // Update is called once per frame
    void Update()
    {
        score.text = _coins.ToString();
        if (_arivee.youWin)
        {
            button.text = "restart";
        }
    }
}
