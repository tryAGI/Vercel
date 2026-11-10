
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared8df5bff0bb4332b8FilterV2FilterVariant2Type
    {
        /// <summary>
        ///
        /// </summary>
        Odata,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKShared8df5bff0bb4332b8FilterV2FilterVariant2TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared8df5bff0bb4332b8FilterV2FilterVariant2Type value)
        {
            return value switch
            {
                AutoSDKShared8df5bff0bb4332b8FilterV2FilterVariant2Type.Odata => "odata",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared8df5bff0bb4332b8FilterV2FilterVariant2Type? ToEnum(string value)
        {
            return value switch
            {
                "odata" => AutoSDKShared8df5bff0bb4332b8FilterV2FilterVariant2Type.Odata,
                _ => null,
            };
        }
    }
}