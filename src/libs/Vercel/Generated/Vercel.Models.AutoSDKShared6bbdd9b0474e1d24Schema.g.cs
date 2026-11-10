
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared6bbdd9b0474e1d24Schema
    {
        /// <summary>
        ///
        /// </summary>
        ExperimentalServices,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKShared6bbdd9b0474e1d24SchemaExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared6bbdd9b0474e1d24Schema value)
        {
            return value switch
            {
                AutoSDKShared6bbdd9b0474e1d24Schema.ExperimentalServices => "experimentalServices",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared6bbdd9b0474e1d24Schema? ToEnum(string value)
        {
            return value switch
            {
                "experimentalServices" => AutoSDKShared6bbdd9b0474e1d24Schema.ExperimentalServices,
                _ => null,
            };
        }
    }
}