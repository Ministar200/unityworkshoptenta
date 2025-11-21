using System;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Serialization;

public class TriggerEvent : MonoBehaviour
{
    public string otherTag;
    public UnityEvent onTriggerEnter;
    
    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag(otherTag) && !other.isTrigger) onTriggerEnter.Invoke();
    }
}
