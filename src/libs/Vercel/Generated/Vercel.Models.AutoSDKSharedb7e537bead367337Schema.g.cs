
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKSharedb7e537bead367337Schema
    {
        /// <summary>
        ///
        /// </summary>
        ExperimentalServicesV2,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKSharedb7e537bead367337SchemaExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharedb7e537bead367337Schema value)
        {
            return value switch
            {
                AutoSDKSharedb7e537bead367337Schema.ExperimentalServicesV2 => "experimentalServicesV2",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharedb7e537bead367337Schema? ToEnum(string value)
        {
            return value switch
            {
                "experimentalServicesV2" => AutoSDKSharedb7e537bead367337Schema.ExperimentalServicesV2,
                _ => null,
            };
        }
    }
}