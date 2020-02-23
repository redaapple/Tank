using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Word : MonoBehaviour
{
    string a1 = "PLAYER1";
    string b1 = "w,s,a,d移动；空格发射子弹";

    // Start is called before the first frame update
    void Start()
    {
        this.gameObject.GetComponent<Text>().text = "<color=green>" + a1 + "</color>" + b1;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
