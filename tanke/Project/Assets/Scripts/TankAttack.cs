using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class TankAttack : MonoBehaviour
{
    public KeyCode attackKeyCode = KeyCode.Space;
    public GameObject shell;
    public Slider preSlider;
    private Transform firePosition;
    public AudioClip shoutFiringAudio;
    float Pressure = 10f;  //蓄力
    float MinPressure = 5f;
    bool shellflag=false;
    public float MaxPressure = 35f;  // 蓄力最大值
    // Start is called before the first frame update
    void Start()
    {
        firePosition = transform.Find("FirePosition");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(attackKeyCode))
        {
            Pressure = MinPressure;
            shellflag = false;
        }
        else if(Input.GetKey(attackKeyCode)&&shellflag==false)
        {
            if (Pressure < MaxPressure)
            {
                Pressure += Time.deltaTime * 18f;
                preSlider.value = Pressure / MaxPressure;
            }
            else
            {
                Pressure = MaxPressure;
                preSlider.value = 1;
            }
        }
        else if(shellflag==false&&Input.GetKeyUp(attackKeyCode))
        {
            Attack();
        }
    }
    void Attack()
    {
        AudioSource.PlayClipAtPoint(shoutFiringAudio, transform.position);
        GameObject go = GameObject.Instantiate(shell, firePosition.position, firePosition.rotation) as GameObject;
        go.GetComponent<Rigidbody>().velocity = go.transform.forward * Pressure;
        shellflag = true;

    }
}
