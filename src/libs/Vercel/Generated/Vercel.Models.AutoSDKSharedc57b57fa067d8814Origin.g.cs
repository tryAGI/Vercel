
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKSharedc57b57fa067d8814Origin
    {
        /// <summary>
        ///
        /// </summary>
        External,
        /// <summary>
        ///
        /// </summary>
        Vercel,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKSharedc57b57fa067d8814OriginExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharedc57b57fa067d8814Origin value)
        {
            return value switch
            {
                AutoSDKSharedc57b57fa067d8814Origin.External => "external",
                AutoSDKSharedc57b57fa067d8814Origin.Vercel => "vercel",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharedc57b57fa067d8814Origin? ToEnum(string value)
        {
            return value switch
            {
                "external" => AutoSDKSharedc57b57fa067d8814Origin.External,
                "vercel" => AutoSDKSharedc57b57fa067d8814Origin.Vercel,
                _ => null,
            };
        }
    }
}