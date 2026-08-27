
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The type of matching to perform
    /// </summary>
    public enum CreateDeploymentResponseVariant2CustomEnvironmentVariant1BranchMatcherType
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
    public static class CreateDeploymentResponseVariant2CustomEnvironmentVariant1BranchMatcherTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateDeploymentResponseVariant2CustomEnvironmentVariant1BranchMatcherType value)
        {
            return value switch
            {
                CreateDeploymentResponseVariant2CustomEnvironmentVariant1BranchMatcherType.EndsWith => "endsWith",
                CreateDeploymentResponseVariant2CustomEnvironmentVariant1BranchMatcherType.Equals => "equals",
                CreateDeploymentResponseVariant2CustomEnvironmentVariant1BranchMatcherType.StartsWith => "startsWith",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateDeploymentResponseVariant2CustomEnvironmentVariant1BranchMatcherType? ToEnum(string value)
        {
            return value switch
            {
                "endsWith" => CreateDeploymentResponseVariant2CustomEnvironmentVariant1BranchMatcherType.EndsWith,
                "equals" => CreateDeploymentResponseVariant2CustomEnvironmentVariant1BranchMatcherType.Equals,
                "startsWith" => CreateDeploymentResponseVariant2CustomEnvironmentVariant1BranchMatcherType.StartsWith,
                _ => null,
            };
        }
    }
}