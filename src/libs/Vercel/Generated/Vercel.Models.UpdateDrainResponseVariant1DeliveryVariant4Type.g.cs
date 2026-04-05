
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UpdateDrainResponseVariant1DeliveryVariant4Type
    {
        /// <summary>
        /// 
        /// </summary>
        Internal,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UpdateDrainResponseVariant1DeliveryVariant4TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateDrainResponseVariant1DeliveryVariant4Type value)
        {
            return value switch
            {
                UpdateDrainResponseVariant1DeliveryVariant4Type.Internal => "internal",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateDrainResponseVariant1DeliveryVariant4Type? ToEnum(string value)
        {
            return value switch
            {
                "internal" => UpdateDrainResponseVariant1DeliveryVariant4Type.Internal,
                _ => null,
            };
        }
    }
}