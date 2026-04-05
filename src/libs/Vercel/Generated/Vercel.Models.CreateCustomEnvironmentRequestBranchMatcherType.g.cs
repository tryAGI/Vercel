
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Type of matcher. One of \"equals\", \"startsWith\", or \"endsWith\".
    /// </summary>
    public enum CreateCustomEnvironmentRequestBranchMatcherType
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
    public static class CreateCustomEnvironmentRequestBranchMatcherTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateCustomEnvironmentRequestBranchMatcherType value)
        {
            return value switch
            {
                CreateCustomEnvironmentRequestBranchMatcherType.EndsWith => "endsWith",
                CreateCustomEnvironmentRequestBranchMatcherType.Equals => "equals",
                CreateCustomEnvironmentRequestBranchMatcherType.StartsWith => "startsWith",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateCustomEnvironmentRequestBranchMatcherType? ToEnum(string value)
        {
            return value switch
            {
                "endsWith" => CreateCustomEnvironmentRequestBranchMatcherType.EndsWith,
                "equals" => CreateCustomEnvironmentRequestBranchMatcherType.Equals,
                "startsWith" => CreateCustomEnvironmentRequestBranchMatcherType.StartsWith,
                _ => null,
            };
        }
    }
}