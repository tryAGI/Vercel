
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum ConnectUpsertProjectConnectionRequestEnvironment
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
    public static class ConnectUpsertProjectConnectionRequestEnvironmentExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ConnectUpsertProjectConnectionRequestEnvironment value)
        {
            return value switch
            {
                ConnectUpsertProjectConnectionRequestEnvironment.Development => "development",
                ConnectUpsertProjectConnectionRequestEnvironment.Preview => "preview",
                ConnectUpsertProjectConnectionRequestEnvironment.Production => "production",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ConnectUpsertProjectConnectionRequestEnvironment? ToEnum(string value)
        {
            return value switch
            {
                "development" => ConnectUpsertProjectConnectionRequestEnvironment.Development,
                "preview" => ConnectUpsertProjectConnectionRequestEnvironment.Preview,
                "production" => ConnectUpsertProjectConnectionRequestEnvironment.Production,
                _ => null,
            };
        }
    }
}