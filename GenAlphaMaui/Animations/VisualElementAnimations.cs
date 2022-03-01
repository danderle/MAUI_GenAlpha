namespace GenAlphaMaui.Animations;

/// <summary>
/// Helpers to animate framework elements in specific ways
/// </summary>
public static class VisualElementAnimations
{
    /// <summary>
    /// Slides a control in from the right
    /// </summary>
    /// <param name="element"></param>
    /// <param name="seconds"></param>
    /// <param name="keepMargin">Wether toi keep the element at the same width during animation</param>
    /// <returns></returns>
    public static async Task SlideInFromRightAsync(this VisualElement element, uint seconds = 300, bool keepMargin = true)
    {
        //Offest the element by its width
        element.TranslationX = element.Width;

        //Make element visible
        element.IsVisible = true;

        //slide from right animation
        await element.TranslateTo(0, 0, seconds);
    }

    /// <summary>
    /// Slides a control out to the right
    /// </summary>
    /// <param name="element"></param>
    /// <param name="seconds"></param>
    /// <param name="keepMargin">Wether toi keep the element at the same width during animation</param>
    /// <returns></returns>
    public static async Task SlideOutToRightAsync(this VisualElement element, uint seconds = 300, bool keepMargin = true)
    {
        //slide out to right animation
        await element.TranslateTo(element.Width, 0, seconds);
        
        //Make element visible
        element.IsVisible = false;
    }
}
