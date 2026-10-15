
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKSharedd474136b05e5e447MissingItemType
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
    public static class AutoSDKSharedd474136b05e5e447MissingItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharedd474136b05e5e447MissingItemType value)
        {
            return value switch
            {
                AutoSDKSharedd474136b05e5e447MissingItemType.Cookie => "cookie",
                AutoSDKSharedd474136b05e5e447MissingItemType.DomainEnvironment => "domain_environment",
                AutoSDKSharedd474136b05e5e447MissingItemType.Environment => "environment",
                AutoSDKSharedd474136b05e5e447MissingItemType.Header => "header",
                AutoSDKSharedd474136b05e5e447MissingItemType.Headers => "headers",
                AutoSDKSharedd474136b05e5e447MissingItemType.Host => "host",
                AutoSDKSharedd474136b05e5e447MissingItemType.InitialRequestPath => "initial_request_path",
                AutoSDKSharedd474136b05e5e447MissingItemType.IpAddress => "ip_address",
                AutoSDKSharedd474136b05e5e447MissingItemType.Method => "method",
                AutoSDKSharedd474136b05e5e447MissingItemType.Path => "path",
                AutoSDKSharedd474136b05e5e447MissingItemType.Protocol => "protocol",
                AutoSDKSharedd474136b05e5e447MissingItemType.Query => "query",
                AutoSDKSharedd474136b05e5e447MissingItemType.Region => "region",
                AutoSDKSharedd474136b05e5e447MissingItemType.Scheme => "scheme",
                AutoSDKSharedd474136b05e5e447MissingItemType.TrustedSource => "trusted_source",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharedd474136b05e5e447MissingItemType? ToEnum(string value)
        {
            return value switch
            {
                "cookie" => AutoSDKSharedd474136b05e5e447MissingItemType.Cookie,
                "domain_environment" => AutoSDKSharedd474136b05e5e447MissingItemType.DomainEnvironment,
                "environment" => AutoSDKSharedd474136b05e5e447MissingItemType.Environment,
                "header" => AutoSDKSharedd474136b05e5e447MissingItemType.Header,
                "headers" => AutoSDKSharedd474136b05e5e447MissingItemType.Headers,
                "host" => AutoSDKSharedd474136b05e5e447MissingItemType.Host,
                "initial_request_path" => AutoSDKSharedd474136b05e5e447MissingItemType.InitialRequestPath,
                "ip_address" => AutoSDKSharedd474136b05e5e447MissingItemType.IpAddress,
                "method" => AutoSDKSharedd474136b05e5e447MissingItemType.Method,
                "path" => AutoSDKSharedd474136b05e5e447MissingItemType.Path,
                "protocol" => AutoSDKSharedd474136b05e5e447MissingItemType.Protocol,
                "query" => AutoSDKSharedd474136b05e5e447MissingItemType.Query,
                "region" => AutoSDKSharedd474136b05e5e447MissingItemType.Region,
                "scheme" => AutoSDKSharedd474136b05e5e447MissingItemType.Scheme,
                "trusted_source" => AutoSDKSharedd474136b05e5e447MissingItemType.TrustedSource,
                _ => null,
            };
        }
    }
}