
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum GetDeploymentResponseVariant2GitRepoVariant4OwnerType
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
    public static class GetDeploymentResponseVariant2GitRepoVariant4OwnerTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetDeploymentResponseVariant2GitRepoVariant4OwnerType value)
        {
            return value switch
            {
                GetDeploymentResponseVariant2GitRepoVariant4OwnerType.Team => "team",
                GetDeploymentResponseVariant2GitRepoVariant4OwnerType.User => "user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetDeploymentResponseVariant2GitRepoVariant4OwnerType? ToEnum(string value)
        {
            return value switch
            {
                "team" => GetDeploymentResponseVariant2GitRepoVariant4OwnerType.Team,
                "user" => GetDeploymentResponseVariant2GitRepoVariant4OwnerType.User,
                _ => null,
            };
        }
    }
}