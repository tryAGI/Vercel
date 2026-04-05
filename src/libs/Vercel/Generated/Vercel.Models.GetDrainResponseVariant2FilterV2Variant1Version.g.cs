
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetDrainResponseVariant2FilterV2Variant1Version
    {
        /// <summary>
        /// 
        /// </summary>
        V1,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetDrainResponseVariant2FilterV2Variant1VersionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetDrainResponseVariant2FilterV2Variant1Version value)
        {
            return value switch
            {
                GetDrainResponseVariant2FilterV2Variant1Version.V1 => "v1",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetDrainResponseVariant2FilterV2Variant1Version? ToEnum(string value)
        {
            return value switch
            {
                "v1" => GetDrainResponseVariant2FilterV2Variant1Version.V1,
                _ => null,
            };
        }
    }
}