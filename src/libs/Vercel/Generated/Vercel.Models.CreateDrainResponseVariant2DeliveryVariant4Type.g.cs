
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateDrainResponseVariant2DeliveryVariant4Type
    {
        /// <summary>
        /// 
        /// </summary>
        Internal,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateDrainResponseVariant2DeliveryVariant4TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateDrainResponseVariant2DeliveryVariant4Type value)
        {
            return value switch
            {
                CreateDrainResponseVariant2DeliveryVariant4Type.Internal => "internal",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateDrainResponseVariant2DeliveryVariant4Type? ToEnum(string value)
        {
            return value switch
            {
                "internal" => CreateDrainResponseVariant2DeliveryVariant4Type.Internal,
                _ => null,
            };
        }
    }
}