
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The delivery log format<br/>
    /// Example: json
    /// </summary>
    public enum CreateConfigurableLogDrainRequestDeliveryFormat
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
    public static class CreateConfigurableLogDrainRequestDeliveryFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateConfigurableLogDrainRequestDeliveryFormat value)
        {
            return value switch
            {
                CreateConfigurableLogDrainRequestDeliveryFormat.Json => "json",
                CreateConfigurableLogDrainRequestDeliveryFormat.Ndjson => "ndjson",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateConfigurableLogDrainRequestDeliveryFormat? ToEnum(string value)
        {
            return value switch
            {
                "json" => CreateConfigurableLogDrainRequestDeliveryFormat.Json,
                "ndjson" => CreateConfigurableLogDrainRequestDeliveryFormat.Ndjson,
                _ => null,
            };
        }
    }
}