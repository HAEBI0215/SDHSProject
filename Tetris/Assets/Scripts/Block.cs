using UnityEngine;

public class Block : MonoBehaviour
{
    public float fallTime = 1f;
    float previousTime;

    void Update()
    {
        Move();
        Rotate();
        Drop();
        AutoDrop();
    }

    void Move()
    {
        if (Input.GetKeyDown(KeyCode.A))
            TryMove(Vector3.left);
        else if (Input.GetKeyDown(KeyCode.D))
            TryMove(Vector3.right);
    }

    void Rotate()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            transform.Rotate(0, 0, 90);

            if (!GameManager.IsValidPosition(transform))
                transform.Rotate(0, 0, -90);
        }
    }

    public void Right_Move()
    {
        TryMove(Vector3.right);
    }
    public void Left_Move()
    {
        TryMove(Vector3.left);
    }
    public void Rot_Block()
    {
        transform.Rotate(0, 0, 90);

        if (!GameManager.IsValidPosition(transform))
            transform.Rotate(0, 0, -90);
    }
    public void Drop_Block()
    {
        TryMove(Vector3.down);
    }

    void Drop()
    {
        if (Input.GetKeyDown(KeyCode.S))
            TryMove(Vector3.down);
    }

    void AutoDrop()
    {
        if (Time.time - previousTime > fallTime)
        {
            if (!TryMove(Vector3.down))
            {
                GameManager.AddToGrid(transform);
                GameManager.DeleteFullLines();
                FindObjectOfType<Spawner>().Spawn();
                enabled = false;
            }
            previousTime = Time.time;
        }
    }

    bool TryMove(Vector3 dir)
    {
        transform.position += dir;

        if (!GameManager.IsValidPosition(transform))
        {
            transform.position -= dir;
            return false;
        }
        return true;
    }
}
