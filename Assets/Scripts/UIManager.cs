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
        // playerController = GameObject.Find("플레이어(Player)").GetComponent<PlayerController>();
    }

    void Update()
    {
        textMoveSpeed.text = "이동속도: " + playerController.moveSpeed;
        textJumpSpeed.text = "점프력: " + playerController.jumpSpeed;
    }
}
