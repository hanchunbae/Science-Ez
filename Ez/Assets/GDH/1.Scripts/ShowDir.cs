using UnityEngine;
using UnityEngine.InputSystem;

public class ShowDir : MonoBehaviour
{
    private LineRenderer _lineRenderer;
    private Culong _culong;

    private Vector3 _targetPos;

    private void Awake()
    {
        _lineRenderer = GetComponent<LineRenderer>();
        _culong = GetComponent<Culong>();
    }

    private void Update()
    {
        _targetPos = gameObject.transform.position + new Vector3(_culong.RbCompo.linearVelocity.x, _culong.RbCompo.linearVelocity.y, 0);
        _lineRenderer.SetPosition(0, gameObject.transform.position);
        _lineRenderer.SetPosition(1, _targetPos);
    }
}
