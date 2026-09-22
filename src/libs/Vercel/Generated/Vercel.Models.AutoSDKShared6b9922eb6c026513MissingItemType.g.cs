
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared6b9922eb6c026513MissingItemType
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
    public static class AutoSDKShared6b9922eb6c026513MissingItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared6b9922eb6c026513MissingItemType value)
        {
            return value switch
            {
                AutoSDKShared6b9922eb6c026513MissingItemType.Cookie => "cookie",
                AutoSDKShared6b9922eb6c026513MissingItemType.DomainEnvironment => "domain_environment",
                AutoSDKShared6b9922eb6c026513MissingItemType.Environment => "environment",
                AutoSDKShared6b9922eb6c026513MissingItemType.Header => "header",
                AutoSDKShared6b9922eb6c026513MissingItemType.Headers => "headers",
                AutoSDKShared6b9922eb6c026513MissingItemType.Host => "host",
                AutoSDKShared6b9922eb6c026513MissingItemType.InitialRequestPath => "initial_request_path",
                AutoSDKShared6b9922eb6c026513MissingItemType.IpAddress => "ip_address",
                AutoSDKShared6b9922eb6c026513MissingItemType.Method => "method",
                AutoSDKShared6b9922eb6c026513MissingItemType.Path => "path",
                AutoSDKShared6b9922eb6c026513MissingItemType.Protocol => "protocol",
                AutoSDKShared6b9922eb6c026513MissingItemType.Query => "query",
                AutoSDKShared6b9922eb6c026513MissingItemType.Region => "region",
                AutoSDKShared6b9922eb6c026513MissingItemType.Scheme => "scheme",
                AutoSDKShared6b9922eb6c026513MissingItemType.TrustedSource => "trusted_source",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared6b9922eb6c026513MissingItemType? ToEnum(string value)
        {
            return value switch
            {
                "cookie" => AutoSDKShared6b9922eb6c026513MissingItemType.Cookie,
                "domain_environment" => AutoSDKShared6b9922eb6c026513MissingItemType.DomainEnvironment,
                "environment" => AutoSDKShared6b9922eb6c026513MissingItemType.Environment,
                "header" => AutoSDKShared6b9922eb6c026513MissingItemType.Header,
                "headers" => AutoSDKShared6b9922eb6c026513MissingItemType.Headers,
                "host" => AutoSDKShared6b9922eb6c026513MissingItemType.Host,
                "initial_request_path" => AutoSDKShared6b9922eb6c026513MissingItemType.InitialRequestPath,
                "ip_address" => AutoSDKShared6b9922eb6c026513MissingItemType.IpAddress,
                "method" => AutoSDKShared6b9922eb6c026513MissingItemType.Method,
                "path" => AutoSDKShared6b9922eb6c026513MissingItemType.Path,
                "protocol" => AutoSDKShared6b9922eb6c026513MissingItemType.Protocol,
                "query" => AutoSDKShared6b9922eb6c026513MissingItemType.Query,
                "region" => AutoSDKShared6b9922eb6c026513MissingItemType.Region,
                "scheme" => AutoSDKShared6b9922eb6c026513MissingItemType.Scheme,
                "trusted_source" => AutoSDKShared6b9922eb6c026513MissingItemType.TrustedSource,
                _ => null,
            };
        }
    }
}