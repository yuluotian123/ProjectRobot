using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class WeaponBase: MonoBehaviour
{
    public Bullet m_bullet = null;
    public Transform m_shootpoint = null;

    public abstract void Shoot(Vector2 dir);
}
