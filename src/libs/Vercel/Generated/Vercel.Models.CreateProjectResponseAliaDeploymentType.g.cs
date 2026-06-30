
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateProjectResponseAliaDeploymentType
    {
        /// <summary>
        /// 
        /// </summary>
        Lambdas,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateProjectResponseAliaDeploymentTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateProjectResponseAliaDeploymentType value)
        {
            return value switch
            {
                CreateProjectResponseAliaDeploymentType.Lambdas => "LAMBDAS",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateProjectResponseAliaDeploymentType? ToEnum(string value)
        {
            return value switch
            {
                "LAMBDAS" => CreateProjectResponseAliaDeploymentType.Lambdas,
                _ => null,
            };
        }
    }
}