
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateConnectorResponseIncludesProjectsItemEnvironment
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
    public static class CreateConnectorResponseIncludesProjectsItemEnvironmentExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateConnectorResponseIncludesProjectsItemEnvironment value)
        {
            return value switch
            {
                CreateConnectorResponseIncludesProjectsItemEnvironment.Development => "development",
                CreateConnectorResponseIncludesProjectsItemEnvironment.Preview => "preview",
                CreateConnectorResponseIncludesProjectsItemEnvironment.Production => "production",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateConnectorResponseIncludesProjectsItemEnvironment? ToEnum(string value)
        {
            return value switch
            {
                "development" => CreateConnectorResponseIncludesProjectsItemEnvironment.Development,
                "preview" => CreateConnectorResponseIncludesProjectsItemEnvironment.Preview,
                "production" => CreateConnectorResponseIncludesProjectsItemEnvironment.Production,
                _ => null,
            };
        }
    }
}