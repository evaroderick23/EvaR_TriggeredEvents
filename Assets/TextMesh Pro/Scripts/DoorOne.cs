using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class DoorOne : MonoBehaviour
{
    public PlayableDirector timeline;
    private bool hasPlayed = false;
    private void OnTriggerEnter(Collider other)
    {
        if (!hasPlayed)
        {
            timeline.Play();
            hasPlayed = true;
            GetComponent<Collider>().enabled = false;
        }
    }
}