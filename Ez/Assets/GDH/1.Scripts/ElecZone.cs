using UnityEngine;

public class ElecZone : MonoBehaviour
{
    private Culong _culong;
    private float _power = 5f;
    private float _givePower;
    private void Awake()
    {
        _culong = GameObject.Find("Electron").GetComponent<Culong>();
    }

    private void Update()
    {
        _givePower = (_culong.CulongPower * _power)
            / Mathf.Pow((_culong.gameObject.transform.position.y - gameObject.transform.position.y), 2);
        _culong.RbCompo.AddForce(Vector2.down * Mathf.Abs(_givePower));
    }
}
