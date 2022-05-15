using UnityEngine;
using UnityEngine.Events;

[RequireComponent(typeof(Collider2D))]



public class OnClickBouton1 : MonoBehaviour
{
    public UnityEvent _onClick,_onEnterOver,_onExitOver;

    public void OnMouseDown()
    {
        _onClick.Invoke();
    }

    public void OnMouseEnter()
    {
        _onEnterOver.Invoke();
    }

    private void OnMouseExit()
    {
        _onExitOver.Invoke();
    }

}
