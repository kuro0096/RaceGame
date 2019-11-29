using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCtr : MonoBehaviour
{
    float m_accel = 0.1f;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        float LStickH = Input.GetAxis("LStick_H");
        float LStickV = Input.GetAxis("LStick_V");
        this.transform.Translate(LStickH * m_accel, 0.0f,LStickV * m_accel);
    }
}
