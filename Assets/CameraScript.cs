using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{
    public GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        Screen.SetResolution(1920, 1080, false);
    }

    // Update is called once per frame
    void Update()
    {
        var playerPostiton = player.transform.position;
        var postion = transform.position;
        postion.x = playerPostiton.x;
        postion.y = +2;
        postion.z = playerPostiton.z-8;
        transform.position = postion;
    }
}
