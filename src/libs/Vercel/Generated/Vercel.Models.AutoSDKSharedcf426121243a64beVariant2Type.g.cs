
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKSharedcf426121243a64beVariant2Type
    {
        /// <summary>
        ///
        /// </summary>
        Command,
        /// <summary>
        ///
        /// </summary>
        Delimiter,
        /// <summary>
        ///
        /// </summary>
        DeploymentState,
        /// <summary>
        ///
        /// </summary>
        EdgeFunctionInvocation,
        /// <summary>
        ///
        /// </summary>
        Exit,
        /// <summary>
        ///
        /// </summary>
        Fatal,
        /// <summary>
        ///
        /// </summary>
        Metric,
        /// <summary>
        ///
        /// </summary>
        Middleware,
        /// <summary>
        ///
        /// </summary>
        MiddlewareInvocation,
        /// <summary>
        ///
        /// </summary>
        Report,
        /// <summary>
        ///
        /// </summary>
        Stderr,
        /// <summary>
        ///
        /// </summary>
        Stdout,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKSharedcf426121243a64beVariant2TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharedcf426121243a64beVariant2Type value)
        {
            return value switch
            {
                AutoSDKSharedcf426121243a64beVariant2Type.Command => "command",
                AutoSDKSharedcf426121243a64beVariant2Type.Delimiter => "delimiter",
                AutoSDKSharedcf426121243a64beVariant2Type.DeploymentState => "deployment-state",
                AutoSDKSharedcf426121243a64beVariant2Type.EdgeFunctionInvocation => "edge-function-invocation",
                AutoSDKSharedcf426121243a64beVariant2Type.Exit => "exit",
                AutoSDKSharedcf426121243a64beVariant2Type.Fatal => "fatal",
                AutoSDKSharedcf426121243a64beVariant2Type.Metric => "metric",
                AutoSDKSharedcf426121243a64beVariant2Type.Middleware => "middleware",
                AutoSDKSharedcf426121243a64beVariant2Type.MiddlewareInvocation => "middleware-invocation",
                AutoSDKSharedcf426121243a64beVariant2Type.Report => "report",
                AutoSDKSharedcf426121243a64beVariant2Type.Stderr => "stderr",
                AutoSDKSharedcf426121243a64beVariant2Type.Stdout => "stdout",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharedcf426121243a64beVariant2Type? ToEnum(string value)
        {
            return value switch
            {
                "command" => AutoSDKSharedcf426121243a64beVariant2Type.Command,
                "delimiter" => AutoSDKSharedcf426121243a64beVariant2Type.Delimiter,
                "deployment-state" => AutoSDKSharedcf426121243a64beVariant2Type.DeploymentState,
                "edge-function-invocation" => AutoSDKSharedcf426121243a64beVariant2Type.EdgeFunctionInvocation,
                "exit" => AutoSDKSharedcf426121243a64beVariant2Type.Exit,
                "fatal" => AutoSDKSharedcf426121243a64beVariant2Type.Fatal,
                "metric" => AutoSDKSharedcf426121243a64beVariant2Type.Metric,
                "middleware" => AutoSDKSharedcf426121243a64beVariant2Type.Middleware,
                "middleware-invocation" => AutoSDKSharedcf426121243a64beVariant2Type.MiddlewareInvocation,
                "report" => AutoSDKSharedcf426121243a64beVariant2Type.Report,
                "stderr" => AutoSDKSharedcf426121243a64beVariant2Type.Stderr,
                "stdout" => AutoSDKSharedcf426121243a64beVariant2Type.Stdout,
                _ => null,
            };
        }
    }
}