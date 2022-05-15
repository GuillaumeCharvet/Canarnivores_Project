using UnityEngine;
using UnityEngine.Events;


[RequireComponent(typeof(Collider2D))]



public class OnClickBoutonChoix : MonoBehaviour
{
    public UnityEvent _onClick;

    public void OnMouseDown()
    {
        _onClick.Invoke();
    }

    
}
