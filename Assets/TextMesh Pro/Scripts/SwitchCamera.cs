using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchCamera : MonoBehaviour
{
    public GameObject camera_main;
    public GameObject camera_right;
    public GameObject doll;

    private void OnTriggerEnter(Collider other)
    {
        camera_main.SetActive(false);
        camera_right.SetActive(true);
        doll.SetActive(false);

    }
}
