using UnityEngine;

public class Obstacle : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.TryGetComponent<Culong>(out Culong culong))
        {
            culong.DieOfDeath();
        }
    }
}
