
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The type of matching to perform
    /// </summary>
    public enum GetCustomEnvironmentResponseBranchMatcherType
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
    public static class GetCustomEnvironmentResponseBranchMatcherTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetCustomEnvironmentResponseBranchMatcherType value)
        {
            return value switch
            {
                GetCustomEnvironmentResponseBranchMatcherType.EndsWith => "endsWith",
                GetCustomEnvironmentResponseBranchMatcherType.Equals => "equals",
                GetCustomEnvironmentResponseBranchMatcherType.StartsWith => "startsWith",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetCustomEnvironmentResponseBranchMatcherType? ToEnum(string value)
        {
            return value switch
            {
                "endsWith" => GetCustomEnvironmentResponseBranchMatcherType.EndsWith,
                "equals" => GetCustomEnvironmentResponseBranchMatcherType.Equals,
                "startsWith" => GetCustomEnvironmentResponseBranchMatcherType.StartsWith,
                _ => null,
            };
        }
    }
}