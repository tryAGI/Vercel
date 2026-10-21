
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared03f29e765d13306dSchema
    {
        /// <summary>
        ///
        /// </summary>
        ExperimentalServices,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKShared03f29e765d13306dSchemaExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared03f29e765d13306dSchema value)
        {
            return value switch
            {
                AutoSDKShared03f29e765d13306dSchema.ExperimentalServices => "experimentalServices",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared03f29e765d13306dSchema? ToEnum(string value)
        {
            return value switch
            {
                "experimentalServices" => AutoSDKShared03f29e765d13306dSchema.ExperimentalServices,
                _ => null,
            };
        }
    }
}