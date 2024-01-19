using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private Movement _movement;
    [SerializeField] private Looking _looking;

    private void FixedUpdate()
    {
        _movement.Move();
        _looking.Look();
    }
}
