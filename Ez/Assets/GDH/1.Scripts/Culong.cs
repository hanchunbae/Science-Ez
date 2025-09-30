using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Rendering;

public class Culong : MonoBehaviour
{
    [field: SerializeField] public Rigidbody2D RbCompo;
    public int CulongPower { get; private set; } = 1;

    private void Awake()
    {
        RbCompo = GetComponent<Rigidbody2D>();
    }
    private void Update()
    {
        if (Keyboard.current.wKey.wasPressedThisFrame)
        {
            RbCompo.AddForce(Vector2.up * CulongPower, ForceMode2D.Impulse);
        }
        if (Keyboard.current.aKey.wasPressedThisFrame)
        {
            RbCompo.AddForce(Vector2.left * CulongPower, ForceMode2D.Impulse);
        }
        if (Keyboard.current.sKey.wasPressedThisFrame)
        {
            RbCompo.AddForce(Vector2.down * CulongPower, ForceMode2D.Impulse);
        }
        if (Keyboard.current.dKey.wasPressedThisFrame)
        {
            RbCompo.AddForce(Vector2.right * CulongPower, ForceMode2D.Impulse);
        }
    }
    public void DieOfDeath()
    {
        gameObject.SetActive(false);
    }
}
