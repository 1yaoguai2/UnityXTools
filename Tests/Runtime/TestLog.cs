using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestLog : MonoBehaviour
{
    void Start()
    {
        LogManager.Log("��ʼ��Ϸ");
    }

    void Update()
    {
        LogManager.LogError("��Ϸ����");
    }
}
