using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// The Button class allows an object to change color through interaction, either on trigger enter or exit.
/// </summary>
public class Button : MonoBehaviour
{
    [SerializeField]
    protected bool onTriggerEnter = true;
    [SerializeField]
    protected List<Color> colors = new List<Color>() { Color.red, Color.blue };

    private MeshRenderer meshRenderer = null;

    private int currentColorIndex = 0;
    /// <summary>
    /// Allows inheriting classes to acces meshRenderer while preventing exceptions and unwanted results.
    /// </summary>
    public MeshRenderer MeshRenderer
    {
        get => meshRenderer;
        set
        {
            if (value != null)
            {
                meshRenderer = value;
            }
        }
    }
    /// <summary>
    /// Allows inheriting classes to acces currentColorIndex while preventing exceptions and unwanted results.
    /// </summary>
    public int CurrentColorIndex
    {
        get => currentColorIndex;

        set
        {
            if (value >= 0 && value < colors.Count)
            {
                currentColorIndex = value;
            }
            else
            {
                Debug.LogWarning("Cannot set currentColorIndex to a number lower than 0 or higher than the colors list count.");
            }
        }
    }

    private void Start()
    {
        MeshRenderer = GetComponent<MeshRenderer>();
        if (colors.Count > 0)
        {
            MeshRenderer.material.color = colors[0];
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (onTriggerEnter)
        {
            SwapColor();
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (!onTriggerEnter)
        {
            SwapColor();
        }
    }

    protected virtual void SwapColor()
    {
        MeshRenderer.material.color = MeshRenderer.material.color == colors[0] ? colors[1] : colors[0];
    }
}
