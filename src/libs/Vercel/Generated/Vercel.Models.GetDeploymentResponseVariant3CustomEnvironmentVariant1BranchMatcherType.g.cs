
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The type of matching to perform
    /// </summary>
    public enum GetDeploymentResponseVariant3CustomEnvironmentVariant1BranchMatcherType
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
    public static class GetDeploymentResponseVariant3CustomEnvironmentVariant1BranchMatcherTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetDeploymentResponseVariant3CustomEnvironmentVariant1BranchMatcherType value)
        {
            return value switch
            {
                GetDeploymentResponseVariant3CustomEnvironmentVariant1BranchMatcherType.EndsWith => "endsWith",
                GetDeploymentResponseVariant3CustomEnvironmentVariant1BranchMatcherType.Equals => "equals",
                GetDeploymentResponseVariant3CustomEnvironmentVariant1BranchMatcherType.StartsWith => "startsWith",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetDeploymentResponseVariant3CustomEnvironmentVariant1BranchMatcherType? ToEnum(string value)
        {
            return value switch
            {
                "endsWith" => GetDeploymentResponseVariant3CustomEnvironmentVariant1BranchMatcherType.EndsWith,
                "equals" => GetDeploymentResponseVariant3CustomEnvironmentVariant1BranchMatcherType.Equals,
                "startsWith" => GetDeploymentResponseVariant3CustomEnvironmentVariant1BranchMatcherType.StartsWith,
                _ => null,
            };
        }
    }
}