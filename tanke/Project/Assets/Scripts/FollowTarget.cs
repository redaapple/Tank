using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowTarget : MonoBehaviour
{
    public Transform player1;
    public Transform player2;
    private new Camera camera;
    private Vector3 offset;
    // Start is called before the first frame update
    void Start()
    {
        offset = transform.position - (player1.position + player2.position) / 2;
        camera = GetComponent<Camera>();
    }

    // Update is called once per frame
    void Update()
    {if (player1 == null || player2 == null) { return; }
        transform.position=offset+ (player1.position + player2.position) / 2;
        float distance = Vector3.Distance(player1.position, player2.position);
        camera.orthographicSize = Mathf.Clamp(distance * 0.75f,10f,34f);
    }
}
