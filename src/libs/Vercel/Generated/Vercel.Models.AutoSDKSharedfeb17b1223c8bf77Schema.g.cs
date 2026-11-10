
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKSharedfeb17b1223c8bf77Schema
    {
        /// <summary>
        ///
        /// </summary>
        ExperimentalServicesV2,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKSharedfeb17b1223c8bf77SchemaExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharedfeb17b1223c8bf77Schema value)
        {
            return value switch
            {
                AutoSDKSharedfeb17b1223c8bf77Schema.ExperimentalServicesV2 => "experimentalServicesV2",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharedfeb17b1223c8bf77Schema? ToEnum(string value)
        {
            return value switch
            {
                "experimentalServicesV2" => AutoSDKSharedfeb17b1223c8bf77Schema.ExperimentalServicesV2,
                _ => null,
            };
        }
    }
}