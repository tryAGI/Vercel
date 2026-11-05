
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKSharedab64e9622c80dc17HaType
    {
        /// <summary>
        ///
        /// </summary>
        Cookie,
        /// <summary>
        ///
        /// </summary>
        DomainEnvironment,
        /// <summary>
        ///
        /// </summary>
        Environment,
        /// <summary>
        ///
        /// </summary>
        Header,
        /// <summary>
        ///
        /// </summary>
        Headers,
        /// <summary>
        ///
        /// </summary>
        Host,
        /// <summary>
        ///
        /// </summary>
        InitialRequestPath,
        /// <summary>
        ///
        /// </summary>
        IpAddress,
        /// <summary>
        ///
        /// </summary>
        Method,
        /// <summary>
        ///
        /// </summary>
        Path,
        /// <summary>
        ///
        /// </summary>
        Protocol,
        /// <summary>
        ///
        /// </summary>
        Query,
        /// <summary>
        ///
        /// </summary>
        Region,
        /// <summary>
        ///
        /// </summary>
        Scheme,
        /// <summary>
        ///
        /// </summary>
        TrustedSource,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKSharedab64e9622c80dc17HaTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharedab64e9622c80dc17HaType value)
        {
            return value switch
            {
                AutoSDKSharedab64e9622c80dc17HaType.Cookie => "cookie",
                AutoSDKSharedab64e9622c80dc17HaType.DomainEnvironment => "domain_environment",
                AutoSDKSharedab64e9622c80dc17HaType.Environment => "environment",
                AutoSDKSharedab64e9622c80dc17HaType.Header => "header",
                AutoSDKSharedab64e9622c80dc17HaType.Headers => "headers",
                AutoSDKSharedab64e9622c80dc17HaType.Host => "host",
                AutoSDKSharedab64e9622c80dc17HaType.InitialRequestPath => "initial_request_path",
                AutoSDKSharedab64e9622c80dc17HaType.IpAddress => "ip_address",
                AutoSDKSharedab64e9622c80dc17HaType.Method => "method",
                AutoSDKSharedab64e9622c80dc17HaType.Path => "path",
                AutoSDKSharedab64e9622c80dc17HaType.Protocol => "protocol",
                AutoSDKSharedab64e9622c80dc17HaType.Query => "query",
                AutoSDKSharedab64e9622c80dc17HaType.Region => "region",
                AutoSDKSharedab64e9622c80dc17HaType.Scheme => "scheme",
                AutoSDKSharedab64e9622c80dc17HaType.TrustedSource => "trusted_source",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharedab64e9622c80dc17HaType? ToEnum(string value)
        {
            return value switch
            {
                "cookie" => AutoSDKSharedab64e9622c80dc17HaType.Cookie,
                "domain_environment" => AutoSDKSharedab64e9622c80dc17HaType.DomainEnvironment,
                "environment" => AutoSDKSharedab64e9622c80dc17HaType.Environment,
                "header" => AutoSDKSharedab64e9622c80dc17HaType.Header,
                "headers" => AutoSDKSharedab64e9622c80dc17HaType.Headers,
                "host" => AutoSDKSharedab64e9622c80dc17HaType.Host,
                "initial_request_path" => AutoSDKSharedab64e9622c80dc17HaType.InitialRequestPath,
                "ip_address" => AutoSDKSharedab64e9622c80dc17HaType.IpAddress,
                "method" => AutoSDKSharedab64e9622c80dc17HaType.Method,
                "path" => AutoSDKSharedab64e9622c80dc17HaType.Path,
                "protocol" => AutoSDKSharedab64e9622c80dc17HaType.Protocol,
                "query" => AutoSDKSharedab64e9622c80dc17HaType.Query,
                "region" => AutoSDKSharedab64e9622c80dc17HaType.Region,
                "scheme" => AutoSDKSharedab64e9622c80dc17HaType.Scheme,
                "trusted_source" => AutoSDKSharedab64e9622c80dc17HaType.TrustedSource,
                _ => null,
            };
        }
    }
}