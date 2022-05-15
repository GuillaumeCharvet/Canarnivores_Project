using UnityEngine;
using UnityEngine.Events;

[RequireComponent(typeof(Collider))]



public class OnClickPointEvent : MonoBehaviour
{
    public UnityEvent _onClick;

    public void OnMouseDown()
    {
        _onClick.Invoke();
    }
}
