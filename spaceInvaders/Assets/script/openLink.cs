using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;


public class openLink : MonoBehaviour, IPointerClickHandler
{
    public string link;
    public void OnPointerClick(PointerEventData eventData)
    {
        Application.OpenURL(link);
    }
}
