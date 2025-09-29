using UnityEngine;
using UnityEngine.InputSystem;

public class Culong : MonoBehaviour
{
    [field: SerializeField] public Rigidbody2D RbCompo;

    private void Awake()
    {
        RbCompo = GetComponent<Rigidbody2D>();

    }
    private void Update()
    {
        if (Keyboard.current.wKey.wasPressedThisFrame)
        {
            RbCompo.AddForce(Vector2.up * 3, ForceMode2D.Impulse);
        }
        if (Keyboard.current.aKey.wasPressedThisFrame)
        {
            RbCompo.AddForce(Vector2.left * 3, ForceMode2D.Impulse);
        }
        if (Keyboard.current.sKey.wasPressedThisFrame)
        {
            RbCompo.AddForce(Vector2.down * 3, ForceMode2D.Impulse);
        }
        if (Keyboard.current.dKey.wasPressedThisFrame)
        {
            RbCompo.AddForce(Vector2.right * 3, ForceMode2D.Impulse);
        }
    }
    public void DieOfDeath()
    {
        gameObject.SetActive(false);
    }
}
