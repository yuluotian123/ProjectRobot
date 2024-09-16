using UnityEngine;


public class TestWeapon : WeaponBase
{
    public override void Shoot(Vector2 dir)
    {
        var bo = GameObject.Instantiate(m_bullet,m_shootpoint.position,m_shootpoint.rotation) as Bullet;
        bo.m_dir = dir;
    }

}