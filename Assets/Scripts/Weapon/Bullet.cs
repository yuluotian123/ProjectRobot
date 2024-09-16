using UnityEngine;

public class Bullet:MonoBehaviour
{
    public Vector2 m_dir = Vector2.up;

    public void FixedUpdate()
    {
        Vector3 offset = new Vector3(m_dir.x * 15f * Time.fixedDeltaTime, m_dir.y * 15f * Time.fixedDeltaTime, 0);
        transform.position += offset;
    }

}
