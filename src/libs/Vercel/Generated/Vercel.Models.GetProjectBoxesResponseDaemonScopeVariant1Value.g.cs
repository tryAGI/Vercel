
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum GetProjectBoxesResponseDaemonScopeVariant1Value
    {
        /// <summary>
        ///
        /// </summary>
        Development,
        /// <summary>
        ///
        /// </summary>
        Preview,
        /// <summary>
        ///
        /// </summary>
        Production,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetProjectBoxesResponseDaemonScopeVariant1ValueExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetProjectBoxesResponseDaemonScopeVariant1Value value)
        {
            return value switch
            {
                GetProjectBoxesResponseDaemonScopeVariant1Value.Development => "development",
                GetProjectBoxesResponseDaemonScopeVariant1Value.Preview => "preview",
                GetProjectBoxesResponseDaemonScopeVariant1Value.Production => "production",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetProjectBoxesResponseDaemonScopeVariant1Value? ToEnum(string value)
        {
            return value switch
            {
                "development" => GetProjectBoxesResponseDaemonScopeVariant1Value.Development,
                "preview" => GetProjectBoxesResponseDaemonScopeVariant1Value.Preview,
                "production" => GetProjectBoxesResponseDaemonScopeVariant1Value.Production,
                _ => null,
            };
        }
    }
}