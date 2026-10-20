
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared6ca7f4005d33343fSchema
    {
        /// <summary>
        ///
        /// </summary>
        ExperimentalServicesV2,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKShared6ca7f4005d33343fSchemaExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared6ca7f4005d33343fSchema value)
        {
            return value switch
            {
                AutoSDKShared6ca7f4005d33343fSchema.ExperimentalServicesV2 => "experimentalServicesV2",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared6ca7f4005d33343fSchema? ToEnum(string value)
        {
            return value switch
            {
                "experimentalServicesV2" => AutoSDKShared6ca7f4005d33343fSchema.ExperimentalServicesV2,
                _ => null,
            };
        }
    }
}