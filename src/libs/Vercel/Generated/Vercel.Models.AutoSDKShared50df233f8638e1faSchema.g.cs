
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared50df233f8638e1faSchema
    {
        /// <summary>
        ///
        /// </summary>
        ExperimentalServicesV2,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKShared50df233f8638e1faSchemaExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared50df233f8638e1faSchema value)
        {
            return value switch
            {
                AutoSDKShared50df233f8638e1faSchema.ExperimentalServicesV2 => "experimentalServicesV2",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared50df233f8638e1faSchema? ToEnum(string value)
        {
            return value switch
            {
                "experimentalServicesV2" => AutoSDKShared50df233f8638e1faSchema.ExperimentalServicesV2,
                _ => null,
            };
        }
    }
}