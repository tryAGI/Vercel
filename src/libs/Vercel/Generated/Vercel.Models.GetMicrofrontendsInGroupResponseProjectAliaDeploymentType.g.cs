
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum GetMicrofrontendsInGroupResponseProjectAliaDeploymentType
    {
        /// <summary>
        ///
        /// </summary>
        Lambdas,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetMicrofrontendsInGroupResponseProjectAliaDeploymentTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetMicrofrontendsInGroupResponseProjectAliaDeploymentType value)
        {
            return value switch
            {
                GetMicrofrontendsInGroupResponseProjectAliaDeploymentType.Lambdas => "LAMBDAS",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetMicrofrontendsInGroupResponseProjectAliaDeploymentType? ToEnum(string value)
        {
            return value switch
            {
                "LAMBDAS" => GetMicrofrontendsInGroupResponseProjectAliaDeploymentType.Lambdas,
                _ => null,
            };
        }
    }
}