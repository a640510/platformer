using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIManager : MonoBehaviour
{
    public TMP_Text textMoveSpeed, textJumpSpeed;
    public PlayerController playerController;

    void Start()
    {
        // playerController = GameObject.Find("�÷��̾�(Player)").GetComponent<PlayerController>();
    }

    void Update()
    {
        textMoveSpeed.text = "�̵��ӵ�: " + playerController.moveSpeed;
        textJumpSpeed.text = "������: " + playerController.jumpSpeed;
    }
}
