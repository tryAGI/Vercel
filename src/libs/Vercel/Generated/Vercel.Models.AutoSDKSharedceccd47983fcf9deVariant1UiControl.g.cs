
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKSharedceccd47983fcf9deVariant1UiControl
    {
        /// <summary>
        ///
        /// </summary>
        Input,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKSharedceccd47983fcf9deVariant1UiControlExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharedceccd47983fcf9deVariant1UiControl value)
        {
            return value switch
            {
                AutoSDKSharedceccd47983fcf9deVariant1UiControl.Input => "input",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharedceccd47983fcf9deVariant1UiControl? ToEnum(string value)
        {
            return value switch
            {
                "input" => AutoSDKSharedceccd47983fcf9deVariant1UiControl.Input,
                _ => null,
            };
        }
    }
}