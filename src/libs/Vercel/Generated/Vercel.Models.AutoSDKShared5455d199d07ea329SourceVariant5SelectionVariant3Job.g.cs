
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared5455d199d07ea329SourceVariant5SelectionVariant3Job
    {
        /// <summary>
        ///
        /// </summary>
        Turborepo,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKShared5455d199d07ea329SourceVariant5SelectionVariant3JobExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared5455d199d07ea329SourceVariant5SelectionVariant3Job value)
        {
            return value switch
            {
                AutoSDKShared5455d199d07ea329SourceVariant5SelectionVariant3Job.Turborepo => "Turborepo",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared5455d199d07ea329SourceVariant5SelectionVariant3Job? ToEnum(string value)
        {
            return value switch
            {
                "Turborepo" => AutoSDKShared5455d199d07ea329SourceVariant5SelectionVariant3Job.Turborepo,
                _ => null,
            };
        }
    }
}