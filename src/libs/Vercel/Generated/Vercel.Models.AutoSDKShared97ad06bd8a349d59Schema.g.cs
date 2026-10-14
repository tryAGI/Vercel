
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared97ad06bd8a349d59Schema
    {
        /// <summary>
        ///
        /// </summary>
        ExperimentalServices,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKShared97ad06bd8a349d59SchemaExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared97ad06bd8a349d59Schema value)
        {
            return value switch
            {
                AutoSDKShared97ad06bd8a349d59Schema.ExperimentalServices => "experimentalServices",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared97ad06bd8a349d59Schema? ToEnum(string value)
        {
            return value switch
            {
                "experimentalServices" => AutoSDKShared97ad06bd8a349d59Schema.ExperimentalServices,
                _ => null,
            };
        }
    }
}