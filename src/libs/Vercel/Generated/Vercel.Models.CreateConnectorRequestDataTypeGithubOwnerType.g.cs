
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateConnectorRequestDataTypeGithubOwnerType
    {
        /// <summary>
        /// 
        /// </summary>
        Organization2,
        /// <summary>
        /// 
        /// </summary>
        User2,
        /// <summary>
        /// 
        /// </summary>
        Organization,
        /// <summary>
        /// 
        /// </summary>
        User,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateConnectorRequestDataTypeGithubOwnerTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateConnectorRequestDataTypeGithubOwnerType value)
        {
            return value switch
            {
                CreateConnectorRequestDataTypeGithubOwnerType.Organization2 => "Organization",
                CreateConnectorRequestDataTypeGithubOwnerType.User2 => "User",
                CreateConnectorRequestDataTypeGithubOwnerType.Organization => "organization",
                CreateConnectorRequestDataTypeGithubOwnerType.User => "user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateConnectorRequestDataTypeGithubOwnerType? ToEnum(string value)
        {
            return value switch
            {
                "Organization" => CreateConnectorRequestDataTypeGithubOwnerType.Organization2,
                "User" => CreateConnectorRequestDataTypeGithubOwnerType.User2,
                "organization" => CreateConnectorRequestDataTypeGithubOwnerType.Organization,
                "user" => CreateConnectorRequestDataTypeGithubOwnerType.User,
                _ => null,
            };
        }
    }
}