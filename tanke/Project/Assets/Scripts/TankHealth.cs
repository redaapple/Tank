using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TankHealth : MonoBehaviour
{
    public int hp = 60;
    public GameObject TankExplotion;
    public AudioClip tankExplosionAudio;
    public Slider hpSlider;
    private int hptotal;
    // Start is called before the first frame update
    void Start()
    {
        hptotal = hp;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void TakeDamage()
    {
        if (hp < 0) return;
        hp -= Random.Range(10, 20);
        hpSlider.value = (float)hp / hptotal;
        if(hp<=0)
        {
            AudioSource.PlayClipAtPoint(tankExplosionAudio, transform.position);
            GameObject.Instantiate(TankExplotion, transform.position+Vector3.up,transform.rotation);
            GameObject.Destroy(this.gameObject);
        }
    }
}
