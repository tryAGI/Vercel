
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Type of matcher. One of \"equals\", \"startsWith\", or \"endsWith\".
    /// </summary>
    public enum UpdateCustomEnvironmentRequestBranchMatcherType
    {
        /// <summary>
        /// 
        /// </summary>
        EndsWith,
        /// <summary>
        /// 
        /// </summary>
        Equals,
        /// <summary>
        /// 
        /// </summary>
        StartsWith,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UpdateCustomEnvironmentRequestBranchMatcherTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateCustomEnvironmentRequestBranchMatcherType value)
        {
            return value switch
            {
                UpdateCustomEnvironmentRequestBranchMatcherType.EndsWith => "endsWith",
                UpdateCustomEnvironmentRequestBranchMatcherType.Equals => "equals",
                UpdateCustomEnvironmentRequestBranchMatcherType.StartsWith => "startsWith",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateCustomEnvironmentRequestBranchMatcherType? ToEnum(string value)
        {
            return value switch
            {
                "endsWith" => UpdateCustomEnvironmentRequestBranchMatcherType.EndsWith,
                "equals" => UpdateCustomEnvironmentRequestBranchMatcherType.Equals,
                "startsWith" => UpdateCustomEnvironmentRequestBranchMatcherType.StartsWith,
                _ => null,
            };
        }
    }
}