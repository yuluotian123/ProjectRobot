using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//�����ɫ��һ����Ϊ��Ŀǰ��û������״̬��ʲô����ֲ��������������ʱ��
//ÿ����ɫ���������ɫ����Ϊ һ��ͷ��һ�����壬������ֻ�֣�һ˫��
public class CharacterContoller : MonoBehaviour
{
    private CharacterBuilder m_builder;


    private Vector3 m_mousePosition = Vector3.zero;
    private Vector2 m_input = Vector2.zero;

    public float m_speed = 5;

    private void Start()
    {
        m_builder = GetComponent<CharacterBuilder>();
    }

    private void Update()
    {
        SetBodyRotation();
    }

    private void FixedUpdate()
    {
        CharacterMove();
        CharacterShoot();
    }


    private void SetBodyRotation()
    {
        //�����ϰ�������귽��
        m_mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        m_mousePosition.z = 0;

        var m_angle = Vector2.Angle(m_mousePosition - transform.position, Vector2.up);
        if (transform.position.x < m_mousePosition.x)
        {
            m_angle = -m_angle;
        }

        m_builder.m_body_slot.rotation = Quaternion.Euler(new Vector3(0, 0, m_angle));
    }

    private void CharacterMove()
    {
        m_input.x = Input.GetAxis("Horizontal");
        m_input.y = Input.GetAxis("Vertical");

        var real_speed = m_speed * Time.fixedDeltaTime;
        var offset = new Vector2(m_input.x * real_speed, m_input.y * real_speed);

        transform.position = transform.position + new Vector3(offset.x,offset.y);
    }

    private void CharacterShoot()
    {
        var left_fire = Input.GetButtonDown("Fire1");
        var right_fire = Input.GetButtonDown("Fire2");
    }
}
