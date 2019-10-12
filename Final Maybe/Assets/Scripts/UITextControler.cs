
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

[RequireComponent(typeof(Text))]
public class UITextControler : MonoBehaviour
{
    private Text textLabel;
    public UnityEvent startEvent;
    public void UpdateText(IntDataObject data)
    {
        textLabel.text = data.value.ToString();
    }
    void Start()
    {
        textLabel = GetComponent<Text>();
        startEvent.Invoke();
    }
}
