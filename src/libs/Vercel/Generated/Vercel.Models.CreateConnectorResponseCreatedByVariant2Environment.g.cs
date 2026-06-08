
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateConnectorResponseCreatedByVariant2Environment
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
    public static class CreateConnectorResponseCreatedByVariant2EnvironmentExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateConnectorResponseCreatedByVariant2Environment value)
        {
            return value switch
            {
                CreateConnectorResponseCreatedByVariant2Environment.Development => "development",
                CreateConnectorResponseCreatedByVariant2Environment.Preview => "preview",
                CreateConnectorResponseCreatedByVariant2Environment.Production => "production",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateConnectorResponseCreatedByVariant2Environment? ToEnum(string value)
        {
            return value switch
            {
                "development" => CreateConnectorResponseCreatedByVariant2Environment.Development,
                "preview" => CreateConnectorResponseCreatedByVariant2Environment.Preview,
                "production" => CreateConnectorResponseCreatedByVariant2Environment.Production,
                _ => null,
            };
        }
    }
}