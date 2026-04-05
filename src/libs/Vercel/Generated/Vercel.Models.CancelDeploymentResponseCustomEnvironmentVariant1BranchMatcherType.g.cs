
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The type of matching to perform
    /// </summary>
    public enum CancelDeploymentResponseCustomEnvironmentVariant1BranchMatcherType
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
    public static class CancelDeploymentResponseCustomEnvironmentVariant1BranchMatcherTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CancelDeploymentResponseCustomEnvironmentVariant1BranchMatcherType value)
        {
            return value switch
            {
                CancelDeploymentResponseCustomEnvironmentVariant1BranchMatcherType.EndsWith => "endsWith",
                CancelDeploymentResponseCustomEnvironmentVariant1BranchMatcherType.Equals => "equals",
                CancelDeploymentResponseCustomEnvironmentVariant1BranchMatcherType.StartsWith => "startsWith",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CancelDeploymentResponseCustomEnvironmentVariant1BranchMatcherType? ToEnum(string value)
        {
            return value switch
            {
                "endsWith" => CancelDeploymentResponseCustomEnvironmentVariant1BranchMatcherType.EndsWith,
                "equals" => CancelDeploymentResponseCustomEnvironmentVariant1BranchMatcherType.Equals,
                "startsWith" => CancelDeploymentResponseCustomEnvironmentVariant1BranchMatcherType.StartsWith,
                _ => null,
            };
        }
    }
}