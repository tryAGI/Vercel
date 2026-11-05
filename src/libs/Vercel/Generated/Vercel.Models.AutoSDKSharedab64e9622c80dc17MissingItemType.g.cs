
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKSharedab64e9622c80dc17MissingItemType
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
    public static class AutoSDKSharedab64e9622c80dc17MissingItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharedab64e9622c80dc17MissingItemType value)
        {
            return value switch
            {
                AutoSDKSharedab64e9622c80dc17MissingItemType.Cookie => "cookie",
                AutoSDKSharedab64e9622c80dc17MissingItemType.DomainEnvironment => "domain_environment",
                AutoSDKSharedab64e9622c80dc17MissingItemType.Environment => "environment",
                AutoSDKSharedab64e9622c80dc17MissingItemType.Header => "header",
                AutoSDKSharedab64e9622c80dc17MissingItemType.Headers => "headers",
                AutoSDKSharedab64e9622c80dc17MissingItemType.Host => "host",
                AutoSDKSharedab64e9622c80dc17MissingItemType.InitialRequestPath => "initial_request_path",
                AutoSDKSharedab64e9622c80dc17MissingItemType.IpAddress => "ip_address",
                AutoSDKSharedab64e9622c80dc17MissingItemType.Method => "method",
                AutoSDKSharedab64e9622c80dc17MissingItemType.Path => "path",
                AutoSDKSharedab64e9622c80dc17MissingItemType.Protocol => "protocol",
                AutoSDKSharedab64e9622c80dc17MissingItemType.Query => "query",
                AutoSDKSharedab64e9622c80dc17MissingItemType.Region => "region",
                AutoSDKSharedab64e9622c80dc17MissingItemType.Scheme => "scheme",
                AutoSDKSharedab64e9622c80dc17MissingItemType.TrustedSource => "trusted_source",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharedab64e9622c80dc17MissingItemType? ToEnum(string value)
        {
            return value switch
            {
                "cookie" => AutoSDKSharedab64e9622c80dc17MissingItemType.Cookie,
                "domain_environment" => AutoSDKSharedab64e9622c80dc17MissingItemType.DomainEnvironment,
                "environment" => AutoSDKSharedab64e9622c80dc17MissingItemType.Environment,
                "header" => AutoSDKSharedab64e9622c80dc17MissingItemType.Header,
                "headers" => AutoSDKSharedab64e9622c80dc17MissingItemType.Headers,
                "host" => AutoSDKSharedab64e9622c80dc17MissingItemType.Host,
                "initial_request_path" => AutoSDKSharedab64e9622c80dc17MissingItemType.InitialRequestPath,
                "ip_address" => AutoSDKSharedab64e9622c80dc17MissingItemType.IpAddress,
                "method" => AutoSDKSharedab64e9622c80dc17MissingItemType.Method,
                "path" => AutoSDKSharedab64e9622c80dc17MissingItemType.Path,
                "protocol" => AutoSDKSharedab64e9622c80dc17MissingItemType.Protocol,
                "query" => AutoSDKSharedab64e9622c80dc17MissingItemType.Query,
                "region" => AutoSDKSharedab64e9622c80dc17MissingItemType.Region,
                "scheme" => AutoSDKSharedab64e9622c80dc17MissingItemType.Scheme,
                "trusted_source" => AutoSDKSharedab64e9622c80dc17MissingItemType.TrustedSource,
                _ => null,
            };
        }
    }
}