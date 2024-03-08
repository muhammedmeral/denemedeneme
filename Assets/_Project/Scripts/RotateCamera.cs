using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class RotateCamera : MonoBehaviour
{
    [SerializeField] private float rotationSpeed;
    [SerializeField] private Transform targetPlayer;
    [SerializeField] private bool isReversed;

    private Quaternion normalToReverse=new Quaternion(0,0,180,0);
    private Quaternion reverseToNormal=new Quaternion(0,0,0,0);

    

    [SerializeField] private Vector3 cameraOffset;

    private void LateUpdate()
    {
        FallowThePlayer(targetPlayer);
    }

    void FallowThePlayer(Transform target)
    {
        this.gameObject.transform.position = target.position+cameraOffset;
    }

    public void CameraRotation()
    {
        // if (isReversed)
        // {
        //     // this.transform.rotation = Quaternion.Lerp(this.transform.rotation, normalToReverse, 0.5f);
        //     isReversed = !isReversed;
        // }
        // else
        // {
        //     this.transform.rotation = Quaternion.Lerp(this.transform.rotation, reverseToNormal, 0.5f);
        //     isReversed = !isReversed;
        // }

        this.transform.DORotate(
            new Vector3(this.transform.rotation.x, this.transform.rotation.y , this.transform.rotation.z+ 180),
            rotationSpeed);

        Debug.Log("Camera Reversed");
    }
}
