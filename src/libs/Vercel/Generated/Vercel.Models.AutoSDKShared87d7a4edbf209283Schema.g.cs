
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared87d7a4edbf209283Schema
    {
        /// <summary>
        ///
        /// </summary>
        ExperimentalServicesV2,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKShared87d7a4edbf209283SchemaExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared87d7a4edbf209283Schema value)
        {
            return value switch
            {
                AutoSDKShared87d7a4edbf209283Schema.ExperimentalServicesV2 => "experimentalServicesV2",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared87d7a4edbf209283Schema? ToEnum(string value)
        {
            return value switch
            {
                "experimentalServicesV2" => AutoSDKShared87d7a4edbf209283Schema.ExperimentalServicesV2,
                _ => null,
            };
        }
    }
}