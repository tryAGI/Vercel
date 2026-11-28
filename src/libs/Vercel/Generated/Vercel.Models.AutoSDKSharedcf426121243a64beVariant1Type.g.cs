
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKSharedcf426121243a64beVariant1Type
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
    public static class AutoSDKSharedcf426121243a64beVariant1TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharedcf426121243a64beVariant1Type value)
        {
            return value switch
            {
                AutoSDKSharedcf426121243a64beVariant1Type.Command => "command",
                AutoSDKSharedcf426121243a64beVariant1Type.Delimiter => "delimiter",
                AutoSDKSharedcf426121243a64beVariant1Type.DeploymentState => "deployment-state",
                AutoSDKSharedcf426121243a64beVariant1Type.EdgeFunctionInvocation => "edge-function-invocation",
                AutoSDKSharedcf426121243a64beVariant1Type.Exit => "exit",
                AutoSDKSharedcf426121243a64beVariant1Type.Fatal => "fatal",
                AutoSDKSharedcf426121243a64beVariant1Type.Metric => "metric",
                AutoSDKSharedcf426121243a64beVariant1Type.Middleware => "middleware",
                AutoSDKSharedcf426121243a64beVariant1Type.MiddlewareInvocation => "middleware-invocation",
                AutoSDKSharedcf426121243a64beVariant1Type.Report => "report",
                AutoSDKSharedcf426121243a64beVariant1Type.Stderr => "stderr",
                AutoSDKSharedcf426121243a64beVariant1Type.Stdout => "stdout",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharedcf426121243a64beVariant1Type? ToEnum(string value)
        {
            return value switch
            {
                "command" => AutoSDKSharedcf426121243a64beVariant1Type.Command,
                "delimiter" => AutoSDKSharedcf426121243a64beVariant1Type.Delimiter,
                "deployment-state" => AutoSDKSharedcf426121243a64beVariant1Type.DeploymentState,
                "edge-function-invocation" => AutoSDKSharedcf426121243a64beVariant1Type.EdgeFunctionInvocation,
                "exit" => AutoSDKSharedcf426121243a64beVariant1Type.Exit,
                "fatal" => AutoSDKSharedcf426121243a64beVariant1Type.Fatal,
                "metric" => AutoSDKSharedcf426121243a64beVariant1Type.Metric,
                "middleware" => AutoSDKSharedcf426121243a64beVariant1Type.Middleware,
                "middleware-invocation" => AutoSDKSharedcf426121243a64beVariant1Type.MiddlewareInvocation,
                "report" => AutoSDKSharedcf426121243a64beVariant1Type.Report,
                "stderr" => AutoSDKSharedcf426121243a64beVariant1Type.Stderr,
                "stdout" => AutoSDKSharedcf426121243a64beVariant1Type.Stdout,
                _ => null,
            };
        }
    }
}