using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cardZoom : MonoBehaviour
{
	public GameObject Canvas;
	private GameObject zoomCard;

	public void Awake()
	{
		Canvas = GameObject.Find("Main Canvas");
	}

	public void OnHoverEnter()
	{
		zoomCard = Instantiate(gameObject, new Vector2(Input.mousePosition.x, Input.mousePosition.y + 250), Quaternion.identity);
		zoomCard.transform.SetParent(Canvas.transform, false);

		RectTransform rect = zoomCard.GetComponent<RectTransform>();
		rect.sizeDelta = new Vector2(210, 285);
	}

	public void OnHoverExit()
	{
		Destroy(zoomCard);
	}
}
