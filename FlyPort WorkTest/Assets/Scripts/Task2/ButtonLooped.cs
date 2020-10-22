/// <summary>
/// A variation of the Button class where color swapping is looped.
/// </summary>
public class ButtonLooped : Button
{
    protected override void SwapColor()
    {
        CurrentColorIndex = CurrentColorIndex < (colors.Count - 1) ? CurrentColorIndex + 1 : 0;
        MeshRenderer.material.color = colors[CurrentColorIndex];
    }
}
