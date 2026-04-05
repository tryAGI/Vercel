
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateDrainResponseVariant1FilterV2Variant2FilterVariant2Type
    {
        /// <summary>
        /// 
        /// </summary>
        Odata,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateDrainResponseVariant1FilterV2Variant2FilterVariant2TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateDrainResponseVariant1FilterV2Variant2FilterVariant2Type value)
        {
            return value switch
            {
                CreateDrainResponseVariant1FilterV2Variant2FilterVariant2Type.Odata => "odata",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateDrainResponseVariant1FilterV2Variant2FilterVariant2Type? ToEnum(string value)
        {
            return value switch
            {
                "odata" => CreateDrainResponseVariant1FilterV2Variant2FilterVariant2Type.Odata,
                _ => null,
            };
        }
    }
}