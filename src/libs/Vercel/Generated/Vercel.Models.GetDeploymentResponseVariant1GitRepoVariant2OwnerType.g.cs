
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetDeploymentResponseVariant1GitRepoVariant2OwnerType
    {
        /// <summary>
        /// 
        /// </summary>
        Team,
        /// <summary>
        /// 
        /// </summary>
        User,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetDeploymentResponseVariant1GitRepoVariant2OwnerTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetDeploymentResponseVariant1GitRepoVariant2OwnerType value)
        {
            return value switch
            {
                GetDeploymentResponseVariant1GitRepoVariant2OwnerType.Team => "team",
                GetDeploymentResponseVariant1GitRepoVariant2OwnerType.User => "user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetDeploymentResponseVariant1GitRepoVariant2OwnerType? ToEnum(string value)
        {
            return value switch
            {
                "team" => GetDeploymentResponseVariant1GitRepoVariant2OwnerType.Team,
                "user" => GetDeploymentResponseVariant1GitRepoVariant2OwnerType.User,
                _ => null,
            };
        }
    }
}