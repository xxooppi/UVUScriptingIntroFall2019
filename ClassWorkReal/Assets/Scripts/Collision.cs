
using UnityEngine;
using UnityEngine.Events;

public class Collision : MonoBehaviour
{

	public UnityEvent triggerEvents;
	private void OnTriggerEnter(Collider other)
	{
		triggerEvents.Invoke();
	}
}
