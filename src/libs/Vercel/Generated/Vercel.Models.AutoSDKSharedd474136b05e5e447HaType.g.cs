
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKSharedd474136b05e5e447HaType
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
    public static class AutoSDKSharedd474136b05e5e447HaTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharedd474136b05e5e447HaType value)
        {
            return value switch
            {
                AutoSDKSharedd474136b05e5e447HaType.Cookie => "cookie",
                AutoSDKSharedd474136b05e5e447HaType.DomainEnvironment => "domain_environment",
                AutoSDKSharedd474136b05e5e447HaType.Environment => "environment",
                AutoSDKSharedd474136b05e5e447HaType.Header => "header",
                AutoSDKSharedd474136b05e5e447HaType.Headers => "headers",
                AutoSDKSharedd474136b05e5e447HaType.Host => "host",
                AutoSDKSharedd474136b05e5e447HaType.InitialRequestPath => "initial_request_path",
                AutoSDKSharedd474136b05e5e447HaType.IpAddress => "ip_address",
                AutoSDKSharedd474136b05e5e447HaType.Method => "method",
                AutoSDKSharedd474136b05e5e447HaType.Path => "path",
                AutoSDKSharedd474136b05e5e447HaType.Protocol => "protocol",
                AutoSDKSharedd474136b05e5e447HaType.Query => "query",
                AutoSDKSharedd474136b05e5e447HaType.Region => "region",
                AutoSDKSharedd474136b05e5e447HaType.Scheme => "scheme",
                AutoSDKSharedd474136b05e5e447HaType.TrustedSource => "trusted_source",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharedd474136b05e5e447HaType? ToEnum(string value)
        {
            return value switch
            {
                "cookie" => AutoSDKSharedd474136b05e5e447HaType.Cookie,
                "domain_environment" => AutoSDKSharedd474136b05e5e447HaType.DomainEnvironment,
                "environment" => AutoSDKSharedd474136b05e5e447HaType.Environment,
                "header" => AutoSDKSharedd474136b05e5e447HaType.Header,
                "headers" => AutoSDKSharedd474136b05e5e447HaType.Headers,
                "host" => AutoSDKSharedd474136b05e5e447HaType.Host,
                "initial_request_path" => AutoSDKSharedd474136b05e5e447HaType.InitialRequestPath,
                "ip_address" => AutoSDKSharedd474136b05e5e447HaType.IpAddress,
                "method" => AutoSDKSharedd474136b05e5e447HaType.Method,
                "path" => AutoSDKSharedd474136b05e5e447HaType.Path,
                "protocol" => AutoSDKSharedd474136b05e5e447HaType.Protocol,
                "query" => AutoSDKSharedd474136b05e5e447HaType.Query,
                "region" => AutoSDKSharedd474136b05e5e447HaType.Region,
                "scheme" => AutoSDKSharedd474136b05e5e447HaType.Scheme,
                "trusted_source" => AutoSDKSharedd474136b05e5e447HaType.TrustedSource,
                _ => null,
            };
        }
    }
}