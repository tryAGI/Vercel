
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum GetProjectBoxesResponseDaemonScopeVariant1Type
    {
        /// <summary>
        ///
        /// </summary>
        Target,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetProjectBoxesResponseDaemonScopeVariant1TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetProjectBoxesResponseDaemonScopeVariant1Type value)
        {
            return value switch
            {
                GetProjectBoxesResponseDaemonScopeVariant1Type.Target => "target",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetProjectBoxesResponseDaemonScopeVariant1Type? ToEnum(string value)
        {
            return value switch
            {
                "target" => GetProjectBoxesResponseDaemonScopeVariant1Type.Target,
                _ => null,
            };
        }
    }
}