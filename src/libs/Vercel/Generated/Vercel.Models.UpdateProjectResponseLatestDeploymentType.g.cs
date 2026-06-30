
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UpdateProjectResponseLatestDeploymentType
    {
        /// <summary>
        /// 
        /// </summary>
        Lambdas,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UpdateProjectResponseLatestDeploymentTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateProjectResponseLatestDeploymentType value)
        {
            return value switch
            {
                UpdateProjectResponseLatestDeploymentType.Lambdas => "LAMBDAS",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateProjectResponseLatestDeploymentType? ToEnum(string value)
        {
            return value switch
            {
                "LAMBDAS" => UpdateProjectResponseLatestDeploymentType.Lambdas,
                _ => null,
            };
        }
    }
}