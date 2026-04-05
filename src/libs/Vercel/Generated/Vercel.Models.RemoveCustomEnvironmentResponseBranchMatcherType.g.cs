
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The type of matching to perform
    /// </summary>
    public enum RemoveCustomEnvironmentResponseBranchMatcherType
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
    public static class RemoveCustomEnvironmentResponseBranchMatcherTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RemoveCustomEnvironmentResponseBranchMatcherType value)
        {
            return value switch
            {
                RemoveCustomEnvironmentResponseBranchMatcherType.EndsWith => "endsWith",
                RemoveCustomEnvironmentResponseBranchMatcherType.Equals => "equals",
                RemoveCustomEnvironmentResponseBranchMatcherType.StartsWith => "startsWith",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RemoveCustomEnvironmentResponseBranchMatcherType? ToEnum(string value)
        {
            return value switch
            {
                "endsWith" => RemoveCustomEnvironmentResponseBranchMatcherType.EndsWith,
                "equals" => RemoveCustomEnvironmentResponseBranchMatcherType.Equals,
                "startsWith" => RemoveCustomEnvironmentResponseBranchMatcherType.StartsWith,
                _ => null,
            };
        }
    }
}