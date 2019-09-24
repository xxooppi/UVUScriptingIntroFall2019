
using UnityEngine;
using UnityEngine.Events;

public class Collision : MonoBehaviour
{

	public UnityEvent collision;
	private void OnTriggerEnter(Collider other)
	{
		collision.Invoke();
	}
}
