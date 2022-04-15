using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cammmm : MonoBehaviour
{

    public GameObject player = GameObject.FindWithTag("Player");
    public GameObject cam = GameObject.FindWithTag("MainCamera");

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        cam.transform.position = new Vector3(player.transform.position.x, 4.50f, player.transform.position.z - 3.30f);
    }
}
