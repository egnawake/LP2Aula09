using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private IEnumerable<Superpower> powers;

    private void Start()
    {
        powers = GetComponents<Superpower>();
        StartCoroutine(UsePowers());
    }

    private IEnumerator UsePowers()
    {
        YieldInstruction wfs = new WaitForSeconds(3f);

        while (true)
        {
            foreach (Superpower p in powers)
            {
                p.Activate();
            }
            yield return wfs;
        }
    }
}
