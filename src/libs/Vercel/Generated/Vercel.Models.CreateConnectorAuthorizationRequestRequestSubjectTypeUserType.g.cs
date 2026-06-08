
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateConnectorAuthorizationRequestRequestSubjectTypeUserType
    {
        /// <summary>
        /// 
        /// </summary>
        User,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateConnectorAuthorizationRequestRequestSubjectTypeUserTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateConnectorAuthorizationRequestRequestSubjectTypeUserType value)
        {
            return value switch
            {
                CreateConnectorAuthorizationRequestRequestSubjectTypeUserType.User => "user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateConnectorAuthorizationRequestRequestSubjectTypeUserType? ToEnum(string value)
        {
            return value switch
            {
                "user" => CreateConnectorAuthorizationRequestRequestSubjectTypeUserType.User,
                _ => null,
            };
        }
    }
}