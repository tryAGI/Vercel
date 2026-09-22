
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared758f1bb5042637ceSchema
    {
        /// <summary>
        ///
        /// </summary>
        ExperimentalServicesV2,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKShared758f1bb5042637ceSchemaExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared758f1bb5042637ceSchema value)
        {
            return value switch
            {
                AutoSDKShared758f1bb5042637ceSchema.ExperimentalServicesV2 => "experimentalServicesV2",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared758f1bb5042637ceSchema? ToEnum(string value)
        {
            return value switch
            {
                "experimentalServicesV2" => AutoSDKShared758f1bb5042637ceSchema.ExperimentalServicesV2,
                _ => null,
            };
        }
    }
}