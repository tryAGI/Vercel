
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The delivery log format<br/>
    /// Example: json
    /// </summary>
    public enum CreateLogDrainRequestDeliveryFormat
    {
        /// <summary>
        /// 
        /// </summary>
        Json,
        /// <summary>
        /// 
        /// </summary>
        Ndjson,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateLogDrainRequestDeliveryFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateLogDrainRequestDeliveryFormat value)
        {
            return value switch
            {
                CreateLogDrainRequestDeliveryFormat.Json => "json",
                CreateLogDrainRequestDeliveryFormat.Ndjson => "ndjson",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateLogDrainRequestDeliveryFormat? ToEnum(string value)
        {
            return value switch
            {
                "json" => CreateLogDrainRequestDeliveryFormat.Json,
                "ndjson" => CreateLogDrainRequestDeliveryFormat.Ndjson,
                _ => null,
            };
        }
    }
}