
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKSharedceccd47983fcf9deVariant4UiControl
    {
        /// <summary>
        ///
        /// </summary>
        Slider,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKSharedceccd47983fcf9deVariant4UiControlExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharedceccd47983fcf9deVariant4UiControl value)
        {
            return value switch
            {
                AutoSDKSharedceccd47983fcf9deVariant4UiControl.Slider => "slider",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharedceccd47983fcf9deVariant4UiControl? ToEnum(string value)
        {
            return value switch
            {
                "slider" => AutoSDKSharedceccd47983fcf9deVariant4UiControl.Slider,
                _ => null,
            };
        }
    }
}