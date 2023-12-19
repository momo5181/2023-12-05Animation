using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collision : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Target"))
        {
            // Toggle "isHit" on target object
            TargetScript targetScript = other.GetComponent<TargetScript>();
            if (targetScript != null)
            {
                targetScript.isHit = true;
            }
        }
    }
}
