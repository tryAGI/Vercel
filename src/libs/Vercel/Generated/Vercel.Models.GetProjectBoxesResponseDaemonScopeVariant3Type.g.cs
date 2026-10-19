
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum GetProjectBoxesResponseDaemonScopeVariant3Type
    {
        /// <summary>
        ///
        /// </summary>
        CustomEnvironment,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetProjectBoxesResponseDaemonScopeVariant3TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetProjectBoxesResponseDaemonScopeVariant3Type value)
        {
            return value switch
            {
                GetProjectBoxesResponseDaemonScopeVariant3Type.CustomEnvironment => "customEnvironment",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetProjectBoxesResponseDaemonScopeVariant3Type? ToEnum(string value)
        {
            return value switch
            {
                "customEnvironment" => GetProjectBoxesResponseDaemonScopeVariant3Type.CustomEnvironment,
                _ => null,
            };
        }
    }
}