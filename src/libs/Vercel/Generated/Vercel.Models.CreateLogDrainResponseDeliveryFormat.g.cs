
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The delivery log format<br/>
    /// Example: json
    /// </summary>
    public enum CreateLogDrainResponseDeliveryFormat
    {
        /// <summary>
        /// 
        /// </summary>
        Json,
        /// <summary>
        /// 
        /// </summary>
        Ndjson,
        /// <summary>
        /// 
        /// </summary>
        Protobuf,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateLogDrainResponseDeliveryFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateLogDrainResponseDeliveryFormat value)
        {
            return value switch
            {
                CreateLogDrainResponseDeliveryFormat.Json => "json",
                CreateLogDrainResponseDeliveryFormat.Ndjson => "ndjson",
                CreateLogDrainResponseDeliveryFormat.Protobuf => "protobuf",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateLogDrainResponseDeliveryFormat? ToEnum(string value)
        {
            return value switch
            {
                "json" => CreateLogDrainResponseDeliveryFormat.Json,
                "ndjson" => CreateLogDrainResponseDeliveryFormat.Ndjson,
                "protobuf" => CreateLogDrainResponseDeliveryFormat.Protobuf,
                _ => null,
            };
        }
    }
}