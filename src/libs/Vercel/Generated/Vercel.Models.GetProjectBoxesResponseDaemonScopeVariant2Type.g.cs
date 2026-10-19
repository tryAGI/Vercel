
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum GetProjectBoxesResponseDaemonScopeVariant2Type
    {
        /// <summary>
        ///
        /// </summary>
        Branch,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetProjectBoxesResponseDaemonScopeVariant2TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetProjectBoxesResponseDaemonScopeVariant2Type value)
        {
            return value switch
            {
                GetProjectBoxesResponseDaemonScopeVariant2Type.Branch => "branch",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetProjectBoxesResponseDaemonScopeVariant2Type? ToEnum(string value)
        {
            return value switch
            {
                "branch" => GetProjectBoxesResponseDaemonScopeVariant2Type.Branch,
                _ => null,
            };
        }
    }
}