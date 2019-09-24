using UnityEngine;
using UnityEngine.Events;

public class StartScreen : MonoBehaviour
{

	public UnityEvent start;
	void Start () 
	{
		start.Invoke();
	}
	
	void Update () {
		
	}
}
