
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKSharedceccd47983fcf9deVariant11UiControl
    {
        /// <summary>
        ///
        /// </summary>
        Domain,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKSharedceccd47983fcf9deVariant11UiControlExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharedceccd47983fcf9deVariant11UiControl value)
        {
            return value switch
            {
                AutoSDKSharedceccd47983fcf9deVariant11UiControl.Domain => "domain",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharedceccd47983fcf9deVariant11UiControl? ToEnum(string value)
        {
            return value switch
            {
                "domain" => AutoSDKSharedceccd47983fcf9deVariant11UiControl.Domain,
                _ => null,
            };
        }
    }
}