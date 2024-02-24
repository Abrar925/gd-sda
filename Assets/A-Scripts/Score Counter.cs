using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoreCounter : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI m_text;

    private int m_counter;

    public void IncreaseCounter()
    {
        ++m_counter;
        m_text.text = m_counter.ToString();
    }


}
