using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCtr : MonoBehaviour
{
    [SerializeField] float m_speed = 0.5f;
    [SerializeField] float m_accel = 0.1f;
  
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        AccelUpdate();

        float LStickH = Input.GetAxis("LStick_H");
        float LStickV = Input.GetAxis("LStick_V");
        //  左右移動
        if(LStickH >= 0.1f)
        {
            this.transform.Translate(LStickH * m_accel, 0.0f, 0.0f);
        }
        else if (LStickH <= -0.1f)
        {
            this.transform.Translate(LStickH * m_accel, 0.0f, 0.0f);
        }
        // 上下移動
        if (LStickV >= 0.1f)
        {
            this.transform.Translate(0.0f, 0.0f, m_speed * m_accel);
        }
        else if (LStickV <= -0.1f)
        {
            this.transform.Translate(0.0f, 0.0f, -m_speed * m_accel);
        }
    }

    private void AccelUpdate()
    {
        if(m_accel >= 0.300f)
        {
            m_accel = 0.3f;
        }
        if (m_accel <= 0.100f)
        {
            m_accel = 0.1f;
        }

        if (Input.GetButton("Accel") == true)
        {
            m_accel += 0.001f;
        }
        if (Input.GetButton("Accel") == false)
        {
            m_accel -= 0.001f;
        }
    }
}
