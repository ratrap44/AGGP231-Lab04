using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetScript : MonoBehaviour
{
    Vector3 OriginalPos;
    public GameObject player;
    public JoystickPlayerExample playercon;
    // Start is called before the first frame update
    void Start()
    {
        OriginalPos = player.gameObject.transform.position;
    }

    void Update()
    {
        playercon.speed = 1;
    }

    public void ResBut()
    {
        player.gameObject.transform.position = OriginalPos;
        playercon.speed = 0;
        
    }
}
