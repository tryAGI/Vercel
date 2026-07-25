
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateConnectorEnvironments
    {
        /// <summary>
        /// 
        /// </summary>
        Development,
        /// <summary>
        /// 
        /// </summary>
        Preview,
        /// <summary>
        /// 
        /// </summary>
        Production,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateConnectorEnvironmentsExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateConnectorEnvironments value)
        {
            return value switch
            {
                CreateConnectorEnvironments.Development => "development",
                CreateConnectorEnvironments.Preview => "preview",
                CreateConnectorEnvironments.Production => "production",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateConnectorEnvironments? ToEnum(string value)
        {
            return value switch
            {
                "development" => CreateConnectorEnvironments.Development,
                "preview" => CreateConnectorEnvironments.Preview,
                "production" => CreateConnectorEnvironments.Production,
                _ => null,
            };
        }
    }
}