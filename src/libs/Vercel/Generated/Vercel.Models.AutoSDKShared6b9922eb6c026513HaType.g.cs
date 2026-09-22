
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared6b9922eb6c026513HaType
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
    public static class AutoSDKShared6b9922eb6c026513HaTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared6b9922eb6c026513HaType value)
        {
            return value switch
            {
                AutoSDKShared6b9922eb6c026513HaType.Cookie => "cookie",
                AutoSDKShared6b9922eb6c026513HaType.DomainEnvironment => "domain_environment",
                AutoSDKShared6b9922eb6c026513HaType.Environment => "environment",
                AutoSDKShared6b9922eb6c026513HaType.Header => "header",
                AutoSDKShared6b9922eb6c026513HaType.Headers => "headers",
                AutoSDKShared6b9922eb6c026513HaType.Host => "host",
                AutoSDKShared6b9922eb6c026513HaType.InitialRequestPath => "initial_request_path",
                AutoSDKShared6b9922eb6c026513HaType.IpAddress => "ip_address",
                AutoSDKShared6b9922eb6c026513HaType.Method => "method",
                AutoSDKShared6b9922eb6c026513HaType.Path => "path",
                AutoSDKShared6b9922eb6c026513HaType.Protocol => "protocol",
                AutoSDKShared6b9922eb6c026513HaType.Query => "query",
                AutoSDKShared6b9922eb6c026513HaType.Region => "region",
                AutoSDKShared6b9922eb6c026513HaType.Scheme => "scheme",
                AutoSDKShared6b9922eb6c026513HaType.TrustedSource => "trusted_source",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared6b9922eb6c026513HaType? ToEnum(string value)
        {
            return value switch
            {
                "cookie" => AutoSDKShared6b9922eb6c026513HaType.Cookie,
                "domain_environment" => AutoSDKShared6b9922eb6c026513HaType.DomainEnvironment,
                "environment" => AutoSDKShared6b9922eb6c026513HaType.Environment,
                "header" => AutoSDKShared6b9922eb6c026513HaType.Header,
                "headers" => AutoSDKShared6b9922eb6c026513HaType.Headers,
                "host" => AutoSDKShared6b9922eb6c026513HaType.Host,
                "initial_request_path" => AutoSDKShared6b9922eb6c026513HaType.InitialRequestPath,
                "ip_address" => AutoSDKShared6b9922eb6c026513HaType.IpAddress,
                "method" => AutoSDKShared6b9922eb6c026513HaType.Method,
                "path" => AutoSDKShared6b9922eb6c026513HaType.Path,
                "protocol" => AutoSDKShared6b9922eb6c026513HaType.Protocol,
                "query" => AutoSDKShared6b9922eb6c026513HaType.Query,
                "region" => AutoSDKShared6b9922eb6c026513HaType.Region,
                "scheme" => AutoSDKShared6b9922eb6c026513HaType.Scheme,
                "trusted_source" => AutoSDKShared6b9922eb6c026513HaType.TrustedSource,
                _ => null,
            };
        }
    }
}