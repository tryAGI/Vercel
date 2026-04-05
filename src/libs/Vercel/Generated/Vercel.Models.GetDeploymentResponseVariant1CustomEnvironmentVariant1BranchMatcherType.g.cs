
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The type of matching to perform
    /// </summary>
    public enum GetDeploymentResponseVariant1CustomEnvironmentVariant1BranchMatcherType
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
    public static class GetDeploymentResponseVariant1CustomEnvironmentVariant1BranchMatcherTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetDeploymentResponseVariant1CustomEnvironmentVariant1BranchMatcherType value)
        {
            return value switch
            {
                GetDeploymentResponseVariant1CustomEnvironmentVariant1BranchMatcherType.EndsWith => "endsWith",
                GetDeploymentResponseVariant1CustomEnvironmentVariant1BranchMatcherType.Equals => "equals",
                GetDeploymentResponseVariant1CustomEnvironmentVariant1BranchMatcherType.StartsWith => "startsWith",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetDeploymentResponseVariant1CustomEnvironmentVariant1BranchMatcherType? ToEnum(string value)
        {
            return value switch
            {
                "endsWith" => GetDeploymentResponseVariant1CustomEnvironmentVariant1BranchMatcherType.EndsWith,
                "equals" => GetDeploymentResponseVariant1CustomEnvironmentVariant1BranchMatcherType.Equals,
                "startsWith" => GetDeploymentResponseVariant1CustomEnvironmentVariant1BranchMatcherType.StartsWith,
                _ => null,
            };
        }
    }
}