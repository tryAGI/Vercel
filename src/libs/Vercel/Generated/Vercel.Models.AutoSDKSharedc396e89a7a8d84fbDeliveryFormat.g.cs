
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The delivery log format<br/>
    /// Example: json
    /// </summary>
    public enum AutoSDKSharedc396e89a7a8d84fbDeliveryFormat
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
    public static class AutoSDKSharedc396e89a7a8d84fbDeliveryFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharedc396e89a7a8d84fbDeliveryFormat value)
        {
            return value switch
            {
                AutoSDKSharedc396e89a7a8d84fbDeliveryFormat.Json => "json",
                AutoSDKSharedc396e89a7a8d84fbDeliveryFormat.Ndjson => "ndjson",
                AutoSDKSharedc396e89a7a8d84fbDeliveryFormat.Protobuf => "protobuf",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharedc396e89a7a8d84fbDeliveryFormat? ToEnum(string value)
        {
            return value switch
            {
                "json" => AutoSDKSharedc396e89a7a8d84fbDeliveryFormat.Json,
                "ndjson" => AutoSDKSharedc396e89a7a8d84fbDeliveryFormat.Ndjson,
                "protobuf" => AutoSDKSharedc396e89a7a8d84fbDeliveryFormat.Protobuf,
                _ => null,
            };
        }
    }
}