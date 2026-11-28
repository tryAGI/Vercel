
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared0b04f80869bc5cc2Schema
    {
        /// <summary>
        ///
        /// </summary>
        ExperimentalServices,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKShared0b04f80869bc5cc2SchemaExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared0b04f80869bc5cc2Schema value)
        {
            return value switch
            {
                AutoSDKShared0b04f80869bc5cc2Schema.ExperimentalServices => "experimentalServices",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared0b04f80869bc5cc2Schema? ToEnum(string value)
        {
            return value switch
            {
                "experimentalServices" => AutoSDKShared0b04f80869bc5cc2Schema.ExperimentalServices,
                _ => null,
            };
        }
    }
}