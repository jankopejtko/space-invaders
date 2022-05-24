using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class skoreCounter : MonoBehaviour
{
    public Text text;
    public static int skore;
    private void Start()
    {
        skore = 0;
    }
    public static void addScore(int value) 
    {
        skore = skore + value;
    }
    private void Update()
    {
        text.text = "Score: " + skore;
    }
}