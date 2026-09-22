
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKSharedbd3f01cc8f6abd3dVariant2Type
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
    public static class AutoSDKSharedbd3f01cc8f6abd3dVariant2TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharedbd3f01cc8f6abd3dVariant2Type value)
        {
            return value switch
            {
                AutoSDKSharedbd3f01cc8f6abd3dVariant2Type.Command => "command",
                AutoSDKSharedbd3f01cc8f6abd3dVariant2Type.Delimiter => "delimiter",
                AutoSDKSharedbd3f01cc8f6abd3dVariant2Type.DeploymentState => "deployment-state",
                AutoSDKSharedbd3f01cc8f6abd3dVariant2Type.EdgeFunctionInvocation => "edge-function-invocation",
                AutoSDKSharedbd3f01cc8f6abd3dVariant2Type.Exit => "exit",
                AutoSDKSharedbd3f01cc8f6abd3dVariant2Type.Fatal => "fatal",
                AutoSDKSharedbd3f01cc8f6abd3dVariant2Type.Metric => "metric",
                AutoSDKSharedbd3f01cc8f6abd3dVariant2Type.Middleware => "middleware",
                AutoSDKSharedbd3f01cc8f6abd3dVariant2Type.MiddlewareInvocation => "middleware-invocation",
                AutoSDKSharedbd3f01cc8f6abd3dVariant2Type.Report => "report",
                AutoSDKSharedbd3f01cc8f6abd3dVariant2Type.Stderr => "stderr",
                AutoSDKSharedbd3f01cc8f6abd3dVariant2Type.Stdout => "stdout",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharedbd3f01cc8f6abd3dVariant2Type? ToEnum(string value)
        {
            return value switch
            {
                "command" => AutoSDKSharedbd3f01cc8f6abd3dVariant2Type.Command,
                "delimiter" => AutoSDKSharedbd3f01cc8f6abd3dVariant2Type.Delimiter,
                "deployment-state" => AutoSDKSharedbd3f01cc8f6abd3dVariant2Type.DeploymentState,
                "edge-function-invocation" => AutoSDKSharedbd3f01cc8f6abd3dVariant2Type.EdgeFunctionInvocation,
                "exit" => AutoSDKSharedbd3f01cc8f6abd3dVariant2Type.Exit,
                "fatal" => AutoSDKSharedbd3f01cc8f6abd3dVariant2Type.Fatal,
                "metric" => AutoSDKSharedbd3f01cc8f6abd3dVariant2Type.Metric,
                "middleware" => AutoSDKSharedbd3f01cc8f6abd3dVariant2Type.Middleware,
                "middleware-invocation" => AutoSDKSharedbd3f01cc8f6abd3dVariant2Type.MiddlewareInvocation,
                "report" => AutoSDKSharedbd3f01cc8f6abd3dVariant2Type.Report,
                "stderr" => AutoSDKSharedbd3f01cc8f6abd3dVariant2Type.Stderr,
                "stdout" => AutoSDKSharedbd3f01cc8f6abd3dVariant2Type.Stdout,
                _ => null,
            };
        }
    }
}