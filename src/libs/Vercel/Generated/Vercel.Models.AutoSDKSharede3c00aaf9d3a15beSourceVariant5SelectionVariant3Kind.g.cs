
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKSharede3c00aaf9d3a15beSourceVariant5SelectionVariant3Kind
    {
        /// <summary>
        ///
        /// </summary>
        Turborepo,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKSharede3c00aaf9d3a15beSourceVariant5SelectionVariant3KindExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharede3c00aaf9d3a15beSourceVariant5SelectionVariant3Kind value)
        {
            return value switch
            {
                AutoSDKSharede3c00aaf9d3a15beSourceVariant5SelectionVariant3Kind.Turborepo => "turborepo",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharede3c00aaf9d3a15beSourceVariant5SelectionVariant3Kind? ToEnum(string value)
        {
            return value switch
            {
                "turborepo" => AutoSDKSharede3c00aaf9d3a15beSourceVariant5SelectionVariant3Kind.Turborepo,
                _ => null,
            };
        }
    }
}