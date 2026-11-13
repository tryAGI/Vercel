
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared0001bb8e789a120eFilterV2FilterVariant2Type
    {
        /// <summary>
        ///
        /// </summary>
        Odata,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKShared0001bb8e789a120eFilterV2FilterVariant2TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared0001bb8e789a120eFilterV2FilterVariant2Type value)
        {
            return value switch
            {
                AutoSDKShared0001bb8e789a120eFilterV2FilterVariant2Type.Odata => "odata",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared0001bb8e789a120eFilterV2FilterVariant2Type? ToEnum(string value)
        {
            return value switch
            {
                "odata" => AutoSDKShared0001bb8e789a120eFilterV2FilterVariant2Type.Odata,
                _ => null,
            };
        }
    }
}