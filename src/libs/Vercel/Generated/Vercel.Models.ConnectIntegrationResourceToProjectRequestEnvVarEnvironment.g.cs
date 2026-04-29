
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum ConnectIntegrationResourceToProjectRequestEnvVarEnvironment
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
    public static class ConnectIntegrationResourceToProjectRequestEnvVarEnvironmentExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ConnectIntegrationResourceToProjectRequestEnvVarEnvironment value)
        {
            return value switch
            {
                ConnectIntegrationResourceToProjectRequestEnvVarEnvironment.Development => "development",
                ConnectIntegrationResourceToProjectRequestEnvVarEnvironment.Preview => "preview",
                ConnectIntegrationResourceToProjectRequestEnvVarEnvironment.Production => "production",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ConnectIntegrationResourceToProjectRequestEnvVarEnvironment? ToEnum(string value)
        {
            return value switch
            {
                "development" => ConnectIntegrationResourceToProjectRequestEnvVarEnvironment.Development,
                "preview" => ConnectIntegrationResourceToProjectRequestEnvVarEnvironment.Preview,
                "production" => ConnectIntegrationResourceToProjectRequestEnvVarEnvironment.Production,
                _ => null,
            };
        }
    }
}