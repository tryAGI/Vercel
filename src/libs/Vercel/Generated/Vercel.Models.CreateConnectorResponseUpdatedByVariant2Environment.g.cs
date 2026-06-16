
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateConnectorResponseUpdatedByVariant2Environment
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
    public static class CreateConnectorResponseUpdatedByVariant2EnvironmentExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateConnectorResponseUpdatedByVariant2Environment value)
        {
            return value switch
            {
                CreateConnectorResponseUpdatedByVariant2Environment.Development => "development",
                CreateConnectorResponseUpdatedByVariant2Environment.Preview => "preview",
                CreateConnectorResponseUpdatedByVariant2Environment.Production => "production",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateConnectorResponseUpdatedByVariant2Environment? ToEnum(string value)
        {
            return value switch
            {
                "development" => CreateConnectorResponseUpdatedByVariant2Environment.Development,
                "preview" => CreateConnectorResponseUpdatedByVariant2Environment.Preview,
                "production" => CreateConnectorResponseUpdatedByVariant2Environment.Production,
                _ => null,
            };
        }
    }
}