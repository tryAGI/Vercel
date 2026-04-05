
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The delivery log format<br/>
    /// Example: json
    /// </summary>
    public enum GetIntegrationLogDrainsResponseItemDeliveryFormat
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
    public static class GetIntegrationLogDrainsResponseItemDeliveryFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetIntegrationLogDrainsResponseItemDeliveryFormat value)
        {
            return value switch
            {
                GetIntegrationLogDrainsResponseItemDeliveryFormat.Json => "json",
                GetIntegrationLogDrainsResponseItemDeliveryFormat.Ndjson => "ndjson",
                GetIntegrationLogDrainsResponseItemDeliveryFormat.Protobuf => "protobuf",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetIntegrationLogDrainsResponseItemDeliveryFormat? ToEnum(string value)
        {
            return value switch
            {
                "json" => GetIntegrationLogDrainsResponseItemDeliveryFormat.Json,
                "ndjson" => GetIntegrationLogDrainsResponseItemDeliveryFormat.Ndjson,
                "protobuf" => GetIntegrationLogDrainsResponseItemDeliveryFormat.Protobuf,
                _ => null,
            };
        }
    }
}