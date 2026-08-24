
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum ConnectCreateConnectorRequestEnvironment
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
    public static class ConnectCreateConnectorRequestEnvironmentExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ConnectCreateConnectorRequestEnvironment value)
        {
            return value switch
            {
                ConnectCreateConnectorRequestEnvironment.Development => "development",
                ConnectCreateConnectorRequestEnvironment.Preview => "preview",
                ConnectCreateConnectorRequestEnvironment.Production => "production",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ConnectCreateConnectorRequestEnvironment? ToEnum(string value)
        {
            return value switch
            {
                "development" => ConnectCreateConnectorRequestEnvironment.Development,
                "preview" => ConnectCreateConnectorRequestEnvironment.Preview,
                "production" => ConnectCreateConnectorRequestEnvironment.Production,
                _ => null,
            };
        }
    }
}