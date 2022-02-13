using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rename : MonoBehaviour
{
    void Reset() // 在编辑器中点击Reset时调用
    {
        int len = transform.childCount;
        for (int i = 0; i < len; i++)
        {
            transform.GetChild(i).name = "Cube" + (i + 1).ToString();
        }
    }
}
