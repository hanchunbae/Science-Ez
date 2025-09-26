using UnityEngine;
using UnityEngine.InputSystem;

public class ShowDir : MonoBehaviour
{
    private LineRenderer _lineRenderer;
    private Rigidbody2D _rbCompo;

    private Vector3 _targetPos;

    private void Awake()
    {
        _lineRenderer = GetComponent<LineRenderer>();
        _rbCompo = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        if(Keyboard.current.wKey.wasPressedThisFrame)
        {
            _rbCompo.AddForce(Vector2.up * 3, ForceMode2D.Impulse);
        }
        if (Keyboard.current.aKey.wasPressedThisFrame)
        {
            _rbCompo.AddForce(Vector2.left * 3, ForceMode2D.Impulse);
        }
        if (Keyboard.current.sKey.wasPressedThisFrame)
        {
            _rbCompo.AddForce(Vector2.down * 3, ForceMode2D.Impulse);
        }
        if (Keyboard.current.dKey.wasPressedThisFrame)
        {
            _rbCompo.AddForce(Vector2.right * 3, ForceMode2D.Impulse);
        }

        _targetPos = gameObject.transform.position + new Vector3(_rbCompo.linearVelocity.x, _rbCompo.linearVelocity.y, 0);
        _lineRenderer.SetPosition(0, gameObject.transform.position);
        _lineRenderer.SetPosition(1, _targetPos);
    }
}
