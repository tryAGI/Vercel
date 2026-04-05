
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateDrainResponseVariant2FilterV2Variant2Version
    {
        /// <summary>
        /// 
        /// </summary>
        V2,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateDrainResponseVariant2FilterV2Variant2VersionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateDrainResponseVariant2FilterV2Variant2Version value)
        {
            return value switch
            {
                CreateDrainResponseVariant2FilterV2Variant2Version.V2 => "v2",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateDrainResponseVariant2FilterV2Variant2Version? ToEnum(string value)
        {
            return value switch
            {
                "v2" => CreateDrainResponseVariant2FilterV2Variant2Version.V2,
                _ => null,
            };
        }
    }
}