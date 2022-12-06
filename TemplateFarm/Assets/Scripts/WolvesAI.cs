using UnityEngine;

public class WolvesAI : AnimalsAI
{
    protected override void SelectTarget()
    {
        Debug.Log("Wolf found a sheep");
    }

    protected override void Move()
    {
        Debug.Log("Wolf went after sheep");
    }

    protected override void TryEat()
    {
        Debug.Log("Wolf tried to bite sheep");
    }

    protected override void TryReproduce()
    {
        Debug.Log("Wolf tried to mate");
    }
}
