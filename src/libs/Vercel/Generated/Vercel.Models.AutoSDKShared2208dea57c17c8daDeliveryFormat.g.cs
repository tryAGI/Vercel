
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The delivery log format<br/>
    /// Example: json
    /// </summary>
    public enum AutoSDKShared2208dea57c17c8daDeliveryFormat
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
    public static class AutoSDKShared2208dea57c17c8daDeliveryFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared2208dea57c17c8daDeliveryFormat value)
        {
            return value switch
            {
                AutoSDKShared2208dea57c17c8daDeliveryFormat.Json => "json",
                AutoSDKShared2208dea57c17c8daDeliveryFormat.Ndjson => "ndjson",
                AutoSDKShared2208dea57c17c8daDeliveryFormat.Protobuf => "protobuf",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared2208dea57c17c8daDeliveryFormat? ToEnum(string value)
        {
            return value switch
            {
                "json" => AutoSDKShared2208dea57c17c8daDeliveryFormat.Json,
                "ndjson" => AutoSDKShared2208dea57c17c8daDeliveryFormat.Ndjson,
                "protobuf" => AutoSDKShared2208dea57c17c8daDeliveryFormat.Protobuf,
                _ => null,
            };
        }
    }
}