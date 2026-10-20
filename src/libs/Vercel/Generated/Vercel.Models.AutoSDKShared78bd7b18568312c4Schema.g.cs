
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared78bd7b18568312c4Schema
    {
        /// <summary>
        ///
        /// </summary>
        ExperimentalServices,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKShared78bd7b18568312c4SchemaExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared78bd7b18568312c4Schema value)
        {
            return value switch
            {
                AutoSDKShared78bd7b18568312c4Schema.ExperimentalServices => "experimentalServices",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared78bd7b18568312c4Schema? ToEnum(string value)
        {
            return value switch
            {
                "experimentalServices" => AutoSDKShared78bd7b18568312c4Schema.ExperimentalServices,
                _ => null,
            };
        }
    }
}