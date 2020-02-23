using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public float Speed = 5;
    public float AngleSpeed = 10;
    private Rigidbody rd;
    public int Number = 1;
    public AudioClip idleAudio;
    public AudioClip drivingAudio;
    private AudioSource maudio;
    // Start is called before the first frame update
    void Start()
    {
        rd = GetComponent<Rigidbody>();
        maudio = this.GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float h = Input.GetAxis("HorizontalPlayer"+Number);
        float v = Input.GetAxis("VerticalPlayer"+Number);
        rd.angularVelocity = transform.up * h * AngleSpeed; 
        rd.velocity = transform.forward * v * Speed;
        if(Mathf.Abs(h)>0.1||Mathf.Abs(v)>0.1)
        {
            maudio.clip = drivingAudio;
            if (maudio.isPlaying == false)
                maudio.Play();
        }
        else
        {
            maudio.clip = idleAudio;
            if (maudio.isPlaying == false)
                maudio.Play();
        }
    }
}
