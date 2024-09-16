using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// CharacterBuilder���ڸ���Ԥ�����ɽ�ɫ����
/// Ŀǰ��ɫӵ��һ��ͷ��һ�����壬��ֻ�ֺ�һ˫��
/// �ڳ�ʼ��ʱ����ݱ�����ʲô�ģ�������û�����ڣ������ɽ�ɫ���ݣ��ٷ��䵽���������ű����е���
/// </summary>
public class CharacterBuilder : MonoBehaviour
{
    [SerializeField]
    public Transform m_head_slot;
    [SerializeField]
    public Transform m_body_slot;

    //ע�⣬ʵ�������ֺ����������ɶ�ӦԤ����ʱ��Ҫ���÷�ת�߼���������xΪ������ĿǰdemoûŪ
    [SerializeField]
    public Transform m_lefthand_slot;
    [SerializeField]
    public Transform m_righthand_slot;

    [SerializeField]
    public Transform m_foot_slot;


    private void Awake()
    {
        var head = Instantiate(Resources.Load("Prefabs/TestCharacter/Head-Obj"), m_head_slot);

        //to do:flip
        var lefthand = Instantiate(Resources.Load("Prefabs/TestCharacter/LeftHand-Obj"), m_lefthand_slot);
        var righthand = Instantiate(Resources.Load("Prefabs/TestCharacter/RightHand-Obj"), m_righthand_slot);

        var body = Instantiate(Resources.Load("Prefabs/TestCharacter/Body-Obj"), m_body_slot);

        var foot = Instantiate(Resources.Load("Prefabs/TestCharacter/Foot-Obj"), m_foot_slot);
    }
}
