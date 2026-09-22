
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The source used as the authoritative price for this intent.
    /// </summary>
    public enum AutoSDKShared7eafcec92f234b4aPricingSource
    {
        /// <summary>
        ///
        /// </summary>
        Copper,
        /// <summary>
        ///
        /// </summary>
        Orb,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKShared7eafcec92f234b4aPricingSourceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared7eafcec92f234b4aPricingSource value)
        {
            return value switch
            {
                AutoSDKShared7eafcec92f234b4aPricingSource.Copper => "copper",
                AutoSDKShared7eafcec92f234b4aPricingSource.Orb => "orb",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared7eafcec92f234b4aPricingSource? ToEnum(string value)
        {
            return value switch
            {
                "copper" => AutoSDKShared7eafcec92f234b4aPricingSource.Copper,
                "orb" => AutoSDKShared7eafcec92f234b4aPricingSource.Orb,
                _ => null,
            };
        }
    }
}