
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The type of matching to perform
    /// </summary>
    public enum UpdateCustomEnvironmentResponseBranchMatcherType
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
    public static class UpdateCustomEnvironmentResponseBranchMatcherTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateCustomEnvironmentResponseBranchMatcherType value)
        {
            return value switch
            {
                UpdateCustomEnvironmentResponseBranchMatcherType.EndsWith => "endsWith",
                UpdateCustomEnvironmentResponseBranchMatcherType.Equals => "equals",
                UpdateCustomEnvironmentResponseBranchMatcherType.StartsWith => "startsWith",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateCustomEnvironmentResponseBranchMatcherType? ToEnum(string value)
        {
            return value switch
            {
                "endsWith" => UpdateCustomEnvironmentResponseBranchMatcherType.EndsWith,
                "equals" => UpdateCustomEnvironmentResponseBranchMatcherType.Equals,
                "startsWith" => UpdateCustomEnvironmentResponseBranchMatcherType.StartsWith,
                _ => null,
            };
        }
    }
}