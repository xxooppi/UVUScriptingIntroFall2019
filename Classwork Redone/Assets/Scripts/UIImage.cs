using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Image))]
public class UIImage : MonoBehaviour
{
	private Image img;
	
	void Start ()
	{
		img = GetComponent<Image>();
	}

	public void UpdateImage(FloatData data)
	{
		img.fillAmount = data.value;
	}
}
