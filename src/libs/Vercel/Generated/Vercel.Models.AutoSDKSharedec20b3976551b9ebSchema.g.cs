
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKSharedec20b3976551b9ebSchema
    {
        /// <summary>
        ///
        /// </summary>
        ExperimentalServicesV2,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKSharedec20b3976551b9ebSchemaExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharedec20b3976551b9ebSchema value)
        {
            return value switch
            {
                AutoSDKSharedec20b3976551b9ebSchema.ExperimentalServicesV2 => "experimentalServicesV2",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharedec20b3976551b9ebSchema? ToEnum(string value)
        {
            return value switch
            {
                "experimentalServicesV2" => AutoSDKSharedec20b3976551b9ebSchema.ExperimentalServicesV2,
                _ => null,
            };
        }
    }
}