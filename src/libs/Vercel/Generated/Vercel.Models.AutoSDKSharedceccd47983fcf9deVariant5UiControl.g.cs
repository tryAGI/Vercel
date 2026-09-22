
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKSharedceccd47983fcf9deVariant5UiControl
    {
        /// <summary>
        ///
        /// </summary>
        Select,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKSharedceccd47983fcf9deVariant5UiControlExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharedceccd47983fcf9deVariant5UiControl value)
        {
            return value switch
            {
                AutoSDKSharedceccd47983fcf9deVariant5UiControl.Select => "select",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharedceccd47983fcf9deVariant5UiControl? ToEnum(string value)
        {
            return value switch
            {
                "select" => AutoSDKSharedceccd47983fcf9deVariant5UiControl.Select,
                _ => null,
            };
        }
    }
}