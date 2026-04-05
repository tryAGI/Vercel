
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The type of matching to perform
    /// </summary>
    public enum GetDeploymentResponseVariant2CustomEnvironmentVariant1BranchMatcherType
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
    public static class GetDeploymentResponseVariant2CustomEnvironmentVariant1BranchMatcherTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetDeploymentResponseVariant2CustomEnvironmentVariant1BranchMatcherType value)
        {
            return value switch
            {
                GetDeploymentResponseVariant2CustomEnvironmentVariant1BranchMatcherType.EndsWith => "endsWith",
                GetDeploymentResponseVariant2CustomEnvironmentVariant1BranchMatcherType.Equals => "equals",
                GetDeploymentResponseVariant2CustomEnvironmentVariant1BranchMatcherType.StartsWith => "startsWith",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetDeploymentResponseVariant2CustomEnvironmentVariant1BranchMatcherType? ToEnum(string value)
        {
            return value switch
            {
                "endsWith" => GetDeploymentResponseVariant2CustomEnvironmentVariant1BranchMatcherType.EndsWith,
                "equals" => GetDeploymentResponseVariant2CustomEnvironmentVariant1BranchMatcherType.Equals,
                "startsWith" => GetDeploymentResponseVariant2CustomEnvironmentVariant1BranchMatcherType.StartsWith,
                _ => null,
            };
        }
    }
}