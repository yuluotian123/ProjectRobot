using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// CharacterBuilder用于根据预设生成角色数据
/// 目前角色拥有一个头，一个身体，两只手和一双脚
/// 在初始化时会根据表格或者什么的（反正都没有现在）来生成角色数据，再发配到各个其他脚本进行调用
/// </summary>
public class CharacterBuilder : MonoBehaviour
{
    [SerializeField]
    public Transform m_head_slot;
    [SerializeField]
    public Transform m_body_slot;

    //注意，实际上左手和右手在生成对应预制体时需要采用翻转逻辑，即调整x为负，但目前demo没弄
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
