using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEditor;
using UnityEngine.SceneManagement;

public class Loadinglndicator : MonoBehaviour
{
    public static Loadinglndicator Instance;

    [SerializeField] private TextMeshProUGUI m_text;

    private void Awake()
    {
        Instance = this;
        DontDestroyOnLoad(gameObject);
        gameObject.SetActive(false);
    }

    public void LoadScene(string name)
    {
        gameObject.SetActive(true);

        AsyncOperation op = SceneManager.LoadSceneAsync("name");
        StartCoroutine(WaitLoading(op));
    }

    private IEnumerator WaitLoading(AsyncOperation op)
    {
        while (!op.isDone)
        {
            m_text.text = op.progress.ToString();
            yield return null;
        }

        gameObject.SetActive(false);

    }
}
