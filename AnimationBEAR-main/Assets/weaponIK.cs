using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class weaponIK : MonoBehaviour
{
    public Transform targetTransform;
    public Transform aimTransform;
    public Transform bone;
    public int iterations = 10;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        Vector3 targetPostion = targetTransform.position;
        for(int i=0; i<iterations;i++)
        {
            AimAtTarget(bone, targetPostion);
        }
        
    }
    private void AimAtTarget(Transform bone ,Vector3 targetPostion)
    {
        Vector3 aimDirection = aimTransform.forward;
        Vector3 targetDirection = targetPostion - aimTransform.position;
        Quaternion aimTowards = Quaternion.FromToRotation(aimDirection, targetDirection);
        bone.rotation = aimTowards*bone.rotation;
    }
}
