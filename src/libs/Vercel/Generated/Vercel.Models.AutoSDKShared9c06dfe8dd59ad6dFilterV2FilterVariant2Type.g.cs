
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared9c06dfe8dd59ad6dFilterV2FilterVariant2Type
    {
        /// <summary>
        ///
        /// </summary>
        Odata,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKShared9c06dfe8dd59ad6dFilterV2FilterVariant2TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared9c06dfe8dd59ad6dFilterV2FilterVariant2Type value)
        {
            return value switch
            {
                AutoSDKShared9c06dfe8dd59ad6dFilterV2FilterVariant2Type.Odata => "odata",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared9c06dfe8dd59ad6dFilterV2FilterVariant2Type? ToEnum(string value)
        {
            return value switch
            {
                "odata" => AutoSDKShared9c06dfe8dd59ad6dFilterV2FilterVariant2Type.Odata,
                _ => null,
            };
        }
    }
}