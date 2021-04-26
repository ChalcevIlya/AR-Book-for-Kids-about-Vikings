using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;
public class sad : MonoBehaviour, IVirtualButtonEventHandler
{
    private GameObject sword;
    private GameObject VB;
    // Start is called before the first frame update
    void Start()
    {
        VB = GameObject.Find("VB");
        VB.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);
        sword= GameObject.Find("sword");
    }
    public void OnButtonPressed(VirtualButtonBehaviour vb) {
        sword.SetActive(false);

    }
    public void OnButtonReleased(VirtualButtonBehaviour vb) {
        sword.SetActive(true);

    }
}
