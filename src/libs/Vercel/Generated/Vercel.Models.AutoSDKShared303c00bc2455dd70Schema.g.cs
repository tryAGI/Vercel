
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared303c00bc2455dd70Schema
    {
        /// <summary>
        ///
        /// </summary>
        ExperimentalServices,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKShared303c00bc2455dd70SchemaExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared303c00bc2455dd70Schema value)
        {
            return value switch
            {
                AutoSDKShared303c00bc2455dd70Schema.ExperimentalServices => "experimentalServices",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared303c00bc2455dd70Schema? ToEnum(string value)
        {
            return value switch
            {
                "experimentalServices" => AutoSDKShared303c00bc2455dd70Schema.ExperimentalServices,
                _ => null,
            };
        }
    }
}