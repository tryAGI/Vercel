
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The type of matching to perform
    /// </summary>
    public enum CreateCustomEnvironmentResponseBranchMatcherType
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
    public static class CreateCustomEnvironmentResponseBranchMatcherTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateCustomEnvironmentResponseBranchMatcherType value)
        {
            return value switch
            {
                CreateCustomEnvironmentResponseBranchMatcherType.EndsWith => "endsWith",
                CreateCustomEnvironmentResponseBranchMatcherType.Equals => "equals",
                CreateCustomEnvironmentResponseBranchMatcherType.StartsWith => "startsWith",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateCustomEnvironmentResponseBranchMatcherType? ToEnum(string value)
        {
            return value switch
            {
                "endsWith" => CreateCustomEnvironmentResponseBranchMatcherType.EndsWith,
                "equals" => CreateCustomEnvironmentResponseBranchMatcherType.Equals,
                "startsWith" => CreateCustomEnvironmentResponseBranchMatcherType.StartsWith,
                _ => null,
            };
        }
    }
}