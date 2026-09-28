
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKSharedb19b25d8dd67bda4BlockAction
    {
        /// <summary>
        ///
        /// </summary>
        Blocked,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKSharedb19b25d8dd67bda4BlockActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharedb19b25d8dd67bda4BlockAction value)
        {
            return value switch
            {
                AutoSDKSharedb19b25d8dd67bda4BlockAction.Blocked => "blocked",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharedb19b25d8dd67bda4BlockAction? ToEnum(string value)
        {
            return value switch
            {
                "blocked" => AutoSDKSharedb19b25d8dd67bda4BlockAction.Blocked,
                _ => null,
            };
        }
    }
}