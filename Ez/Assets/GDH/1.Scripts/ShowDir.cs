using UnityEngine;
using UnityEngine.InputSystem;

public class ShowDir : MonoBehaviour
{
    private LineRenderer _lineRenderer;
    private Electron _culong;

    private Vector3 _targetPos;

    private void Awake()
    {
        _lineRenderer = GetComponent<LineRenderer>();
        _culong = GetComponent<Electron>();
    }

    private void Update()
    {
        _targetPos = gameObject.transform.position + new Vector3(_culong.rb.linearVelocity.x, _culong.rb.linearVelocity.y, 0);
        _lineRenderer.SetPosition(0, gameObject.transform.position);
        _lineRenderer.SetPosition(1, _targetPos);
    }
}
