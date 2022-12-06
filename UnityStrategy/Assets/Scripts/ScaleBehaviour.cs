using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScaleBehaviour : MonoBehaviour, IAnimateBehaviour
{
    public void Animate()
    {
        transform.localScale = (((Mathf.Sin(Time.time) + 1f) * 0.5f) + 0.5f)
            * Vector3.one;
    }
}
