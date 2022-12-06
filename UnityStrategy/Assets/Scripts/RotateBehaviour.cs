using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateBehaviour : MonoBehaviour, IAnimateBehaviour
{
    private Vector3 angleDelta = new Vector3(0, 10f, 0);

    public void Animate()
    {
        transform.Rotate(angleDelta * Time.deltaTime);
    }
}
