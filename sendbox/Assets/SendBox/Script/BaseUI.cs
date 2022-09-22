using UnityEngine;

public class BaseUI : MonoBehaviour
{
    static BaseUI instance;

    public static BaseUI Instance
    {
        get
        {
            if (instance == null)
            {
                var go = new GameObject("BaseUI");
                go.transform.localScale = Vector3.one;
                go.transform.localPosition = Vector3.zero;
                instance = go.GetComponent<BaseUI>();
            }

            return instance;
        }
    }

    public void Display()
    {
        gameObject.SetActive(true);
    }
}
