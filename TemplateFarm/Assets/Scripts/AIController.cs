using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIController : MonoBehaviour
{
    private ICollection<AnimalsAI> animals;

    private void Awake()
    {
        animals = new List<AnimalsAI> {
            new SheepAI(),
            new WolvesAI()
        };
    }

    private void Start()
    {
        StartCoroutine(PerformAnimalTurns());        
    }

    private IEnumerator PerformAnimalTurns()
    {
        YieldInstruction wfs = new WaitForSeconds(2);

        while (true)
        {
            foreach (AnimalsAI animal in animals)
            {
                animal.TakeTurn();
            }
            yield return wfs;
        }
    }
}
