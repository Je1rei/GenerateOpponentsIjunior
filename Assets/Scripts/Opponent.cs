
using UnityEngine;

public class Opponent : MonoBehaviour
{
    [SerializeField] private float _speed;
    private Vector3 _direction;

    public Vector3 Direction { get { return _direction; } private set {  _direction = value.normalized; } }

    private void FixedUpdate()
    {
        Move();
    }

    public void SetDirection(Vector3 newDirection)
    {
        Direction = newDirection;
    }

    public void Move()
    {
        transform.Translate(_direction * _speed  * Time.deltaTime);
    }
}
