using UnityEngine;

public class SheepAI : AnimalsAI
{
    protected override void Move()
    {
        Debug.Log("Sheep moved");
    }

    protected override void TryEat()
    {
        Debug.Log("Sheep tried to eat some grass");
    }

    protected override void TryReproduce()
    {
        Debug.Log("Sheep tried to mate");
    }
}
