
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The type of matching to perform
    /// </summary>
    public enum CreateDeploymentResponseCustomEnvironmentVariant1BranchMatcherType
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
    public static class CreateDeploymentResponseCustomEnvironmentVariant1BranchMatcherTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateDeploymentResponseCustomEnvironmentVariant1BranchMatcherType value)
        {
            return value switch
            {
                CreateDeploymentResponseCustomEnvironmentVariant1BranchMatcherType.EndsWith => "endsWith",
                CreateDeploymentResponseCustomEnvironmentVariant1BranchMatcherType.Equals => "equals",
                CreateDeploymentResponseCustomEnvironmentVariant1BranchMatcherType.StartsWith => "startsWith",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateDeploymentResponseCustomEnvironmentVariant1BranchMatcherType? ToEnum(string value)
        {
            return value switch
            {
                "endsWith" => CreateDeploymentResponseCustomEnvironmentVariant1BranchMatcherType.EndsWith,
                "equals" => CreateDeploymentResponseCustomEnvironmentVariant1BranchMatcherType.Equals,
                "startsWith" => CreateDeploymentResponseCustomEnvironmentVariant1BranchMatcherType.StartsWith,
                _ => null,
            };
        }
    }
}