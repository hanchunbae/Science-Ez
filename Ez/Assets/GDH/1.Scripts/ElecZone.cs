using UnityEngine;

public class ElecZone : MonoBehaviour
{
    private Electron _culong;
    private float _power = 5f;
    private float _givePower;
    private void Awake()
    {
        _culong = GameObject.Find("Electron").GetComponent<Electron>();
    }

    private void Update()
    {
        _givePower = (_culong.k)
            / Mathf.Pow((_culong.gameObject.transform.position.y - gameObject.transform.position.y), 2);
        _culong.rb.AddForce(Vector2.down * Mathf.Abs(_givePower));
    }
}
