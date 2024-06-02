using UnityEngine;
using TMPro;
using UnityEngine.Events;
using System;

public class ScoreManager : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI inputScore;
    [SerializeField]
    private TMP_InputField inputName;

    public UnityEvent<string, int> submitScoreEvent;

    public void SubmitScore()
    {
        submitScoreEvent.Invoke(inputName.text, int.Parse(inputScore.text));
    }

    internal static void LoadScene(int respawn)
    {
        throw new NotImplementedException();
    }
}
