using UnityEngine;
/// <summary>
/// A variation of the Button class where color swapping is random.
/// </summary>
public class ButtonRandomized : Button
{
    protected override void SwapColor()
    {
        MeshRenderer.material.color = colors[Random.Range(0, colors.Count)];
    }
}
