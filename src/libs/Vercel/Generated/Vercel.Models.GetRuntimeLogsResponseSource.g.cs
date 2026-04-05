
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetRuntimeLogsResponseSource
    {
        /// <summary>
        /// 
        /// </summary>
        Delimiter,
        /// <summary>
        /// 
        /// </summary>
        EdgeFunction,
        /// <summary>
        /// 
        /// </summary>
        EdgeMiddleware,
        /// <summary>
        /// 
        /// </summary>
        Request,
        /// <summary>
        /// 
        /// </summary>
        Serverless,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetRuntimeLogsResponseSourceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetRuntimeLogsResponseSource value)
        {
            return value switch
            {
                GetRuntimeLogsResponseSource.Delimiter => "delimiter",
                GetRuntimeLogsResponseSource.EdgeFunction => "edge-function",
                GetRuntimeLogsResponseSource.EdgeMiddleware => "edge-middleware",
                GetRuntimeLogsResponseSource.Request => "request",
                GetRuntimeLogsResponseSource.Serverless => "serverless",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetRuntimeLogsResponseSource? ToEnum(string value)
        {
            return value switch
            {
                "delimiter" => GetRuntimeLogsResponseSource.Delimiter,
                "edge-function" => GetRuntimeLogsResponseSource.EdgeFunction,
                "edge-middleware" => GetRuntimeLogsResponseSource.EdgeMiddleware,
                "request" => GetRuntimeLogsResponseSource.Request,
                "serverless" => GetRuntimeLogsResponseSource.Serverless,
                _ => null,
            };
        }
    }
}