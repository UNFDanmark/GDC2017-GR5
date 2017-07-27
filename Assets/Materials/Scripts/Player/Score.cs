using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class Score : MonoBehaviour
{

    public float points = 0;
    public Text pointsText;

    // Use this for initialization
    void Start()
    {
        
    }

   // Update is called once per frame
   void Update()
   {
        pointsText.text = "Time: " + points;
        points += Time.deltaTime;
   }
}
