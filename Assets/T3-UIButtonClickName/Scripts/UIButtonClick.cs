using UnityEngine;
using UnityEngine.EventSystems;

public class UIButtonClick : MonoBehaviour
{
    public void CreateShape()
    {
        string ClickedButtonName = EventSystem.current.currentSelectedGameObject.name;
        Debug.Log(ClickedButtonName + " is created !");
    }
}
