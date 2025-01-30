using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UIscore : MonoBehaviour
{
    private int score = 0;
    public void addScore() 
    { 
       score++;
    }
    private TextMeshProUGUI _textMeshPro;
    // Start is called before the first frame update
    void Start()
    {
        _textMeshPro = GetComponent<TextMeshProUGUI>(); 
    }

    // Update is called once per frame
    void Update()
    {
        _textMeshPro.text = "Score: "+score.ToString();
    }
}
