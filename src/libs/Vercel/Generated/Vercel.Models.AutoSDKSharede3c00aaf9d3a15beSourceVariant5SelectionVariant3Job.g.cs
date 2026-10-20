
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKSharede3c00aaf9d3a15beSourceVariant5SelectionVariant3Job
    {
        /// <summary>
        ///
        /// </summary>
        Turborepo,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKSharede3c00aaf9d3a15beSourceVariant5SelectionVariant3JobExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharede3c00aaf9d3a15beSourceVariant5SelectionVariant3Job value)
        {
            return value switch
            {
                AutoSDKSharede3c00aaf9d3a15beSourceVariant5SelectionVariant3Job.Turborepo => "Turborepo",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharede3c00aaf9d3a15beSourceVariant5SelectionVariant3Job? ToEnum(string value)
        {
            return value switch
            {
                "Turborepo" => AutoSDKSharede3c00aaf9d3a15beSourceVariant5SelectionVariant3Job.Turborepo,
                _ => null,
            };
        }
    }
}