
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared171aaf52dacf0e58Schema
    {
        /// <summary>
        ///
        /// </summary>
        ExperimentalServicesV2,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKShared171aaf52dacf0e58SchemaExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared171aaf52dacf0e58Schema value)
        {
            return value switch
            {
                AutoSDKShared171aaf52dacf0e58Schema.ExperimentalServicesV2 => "experimentalServicesV2",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared171aaf52dacf0e58Schema? ToEnum(string value)
        {
            return value switch
            {
                "experimentalServicesV2" => AutoSDKShared171aaf52dacf0e58Schema.ExperimentalServicesV2,
                _ => null,
            };
        }
    }
}