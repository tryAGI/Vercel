
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared32260c85dfc16e39Schema
    {
        /// <summary>
        ///
        /// </summary>
        ExperimentalServices,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKShared32260c85dfc16e39SchemaExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared32260c85dfc16e39Schema value)
        {
            return value switch
            {
                AutoSDKShared32260c85dfc16e39Schema.ExperimentalServices => "experimentalServices",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared32260c85dfc16e39Schema? ToEnum(string value)
        {
            return value switch
            {
                "experimentalServices" => AutoSDKShared32260c85dfc16e39Schema.ExperimentalServices,
                _ => null,
            };
        }
    }
}