
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKSharede870b907cc1fb37eTier
    {
        /// <summary>
        ///
        /// </summary>
        Priority,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKSharede870b907cc1fb37eTierExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharede870b907cc1fb37eTier value)
        {
            return value switch
            {
                AutoSDKSharede870b907cc1fb37eTier.Priority => "priority",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharede870b907cc1fb37eTier? ToEnum(string value)
        {
            return value switch
            {
                "priority" => AutoSDKSharede870b907cc1fb37eTier.Priority,
                _ => null,
            };
        }
    }
}