using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Rendering;

public class Culong : MonoBehaviour
{
    [field: SerializeField] public Rigidbody2D RbCompo;
    public float CulongPower { get; private set; }

    private void Awake()
    {
        RbCompo = GetComponent<Rigidbody2D>();
        CulongPower = GetComponent<Electron>().charge;
    }
    public void DieOfDeath()
    {
        gameObject.SetActive(false);
    }
}
