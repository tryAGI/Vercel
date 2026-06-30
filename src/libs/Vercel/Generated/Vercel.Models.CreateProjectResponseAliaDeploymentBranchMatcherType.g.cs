
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The type of matching to perform
    /// </summary>
    public enum CreateProjectResponseAliaDeploymentBranchMatcherType
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
    public static class CreateProjectResponseAliaDeploymentBranchMatcherTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateProjectResponseAliaDeploymentBranchMatcherType value)
        {
            return value switch
            {
                CreateProjectResponseAliaDeploymentBranchMatcherType.EndsWith => "endsWith",
                CreateProjectResponseAliaDeploymentBranchMatcherType.Equals => "equals",
                CreateProjectResponseAliaDeploymentBranchMatcherType.StartsWith => "startsWith",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateProjectResponseAliaDeploymentBranchMatcherType? ToEnum(string value)
        {
            return value switch
            {
                "endsWith" => CreateProjectResponseAliaDeploymentBranchMatcherType.EndsWith,
                "equals" => CreateProjectResponseAliaDeploymentBranchMatcherType.Equals,
                "startsWith" => CreateProjectResponseAliaDeploymentBranchMatcherType.StartsWith,
                _ => null,
            };
        }
    }
}