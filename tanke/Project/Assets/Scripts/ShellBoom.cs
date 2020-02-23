using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShellBoom : MonoBehaviour
{
    public GameObject shellExplosion;
    public AudioClip shellBoomAudio;
    // Start is called before the first frame update
    public void OnTriggerEnter(Collider collider)
    {
        AudioSource.PlayClipAtPoint(shellBoomAudio, transform.position);
        GameObject.Instantiate(shellExplosion, transform.position, transform.rotation);
        Destroy(this.gameObject);

        if(collider.tag=="Tank")
        {

            collider.SendMessage("TakeDamage");
        }
    }
}
