
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateConnectorAuthorizationRequestRequestSubjectTypeJwtBearerType
    {
        /// <summary>
        /// 
        /// </summary>
        JwtBearer,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateConnectorAuthorizationRequestRequestSubjectTypeJwtBearerTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateConnectorAuthorizationRequestRequestSubjectTypeJwtBearerType value)
        {
            return value switch
            {
                CreateConnectorAuthorizationRequestRequestSubjectTypeJwtBearerType.JwtBearer => "jwt-bearer",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateConnectorAuthorizationRequestRequestSubjectTypeJwtBearerType? ToEnum(string value)
        {
            return value switch
            {
                "jwt-bearer" => CreateConnectorAuthorizationRequestRequestSubjectTypeJwtBearerType.JwtBearer,
                _ => null,
            };
        }
    }
}