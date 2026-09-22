
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKSharedceccd47983fcf9deVariant6UiControl
    {
        /// <summary>
        ///
        /// </summary>
        RadioButton,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKSharedceccd47983fcf9deVariant6UiControlExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharedceccd47983fcf9deVariant6UiControl value)
        {
            return value switch
            {
                AutoSDKSharedceccd47983fcf9deVariant6UiControl.RadioButton => "radio-button",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharedceccd47983fcf9deVariant6UiControl? ToEnum(string value)
        {
            return value switch
            {
                "radio-button" => AutoSDKSharedceccd47983fcf9deVariant6UiControl.RadioButton,
                _ => null,
            };
        }
    }
}