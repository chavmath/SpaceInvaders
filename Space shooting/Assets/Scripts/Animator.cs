using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class ButtonColorChange : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
	private Button button;
	private Text buttonText;
	private Color normalColor;
	public Color highlightedColor;

	void Start()
	{
		// Obtén el componente Button y Text del GameObject
		button = GetComponent<Button>();
		buttonText = GetComponentInChildren<Text>();

		// Guarda el color normal del botón
		normalColor = button.image.color;
	}

	
	public void OnPointerEnter(PointerEventData eventData)
	{
		// Cambia el color del botón y el texto al color resaltado
		button.image.color = highlightedColor;
		buttonText.color = highlightedColor;
	}

	public void OnPointerExit(PointerEventData eventData)
	{
		// Regresa el color del botón y el texto al color normal
		button.image.color = normalColor;
		buttonText.color = normalColor;
	}
}
