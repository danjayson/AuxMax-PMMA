using UnityEngine;
using System.Collections.Generic;
using UnityEngine.UI;


public class GlowObjectCmd : MonoBehaviour
{
	public Color GlowColor;
	public string partName;
	public string objectDescription;
	public Color PressedColor;
	public float LerpFactor = 10;
	bool _innerObject;
	public Text _Text;
	public Renderer[] Renderers
	{
		get;
		private set;
	}

	public Color CurrentColor
	{
		get { return _currentColor; }
	}

	private Color _currentColor;
	private Color _targetColor;

	void Start()
	{
		Renderers = GetComponentsInChildren<Renderer>();
		GlowController.RegisterObject(this);
	}

	private void OnMouseEnter()
	{
		_targetColor = GlowColor;
		enabled = true;
		//Debug.Log ("Mouse Entered");
	}

	private void OnMouseDown()
	{
		_targetColor = PressedColor;
		enabled = true;
		_Text.text = partName;
	}

	private void OnMouseExit()
	{
		_targetColor = Color.black;
		enabled = true;
	}

	private void Update()
	{
		_currentColor = Color.Lerp(_currentColor, _targetColor, Time.deltaTime * LerpFactor);

		if (_currentColor.Equals(_targetColor))
		{
			enabled = false;
		}


		if(_innerObject == true){

		}
	}
}
