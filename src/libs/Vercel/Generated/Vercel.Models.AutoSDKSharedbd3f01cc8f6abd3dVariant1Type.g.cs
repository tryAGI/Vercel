
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKSharedbd3f01cc8f6abd3dVariant1Type
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
    public static class AutoSDKSharedbd3f01cc8f6abd3dVariant1TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharedbd3f01cc8f6abd3dVariant1Type value)
        {
            return value switch
            {
                AutoSDKSharedbd3f01cc8f6abd3dVariant1Type.Command => "command",
                AutoSDKSharedbd3f01cc8f6abd3dVariant1Type.Delimiter => "delimiter",
                AutoSDKSharedbd3f01cc8f6abd3dVariant1Type.DeploymentState => "deployment-state",
                AutoSDKSharedbd3f01cc8f6abd3dVariant1Type.EdgeFunctionInvocation => "edge-function-invocation",
                AutoSDKSharedbd3f01cc8f6abd3dVariant1Type.Exit => "exit",
                AutoSDKSharedbd3f01cc8f6abd3dVariant1Type.Fatal => "fatal",
                AutoSDKSharedbd3f01cc8f6abd3dVariant1Type.Metric => "metric",
                AutoSDKSharedbd3f01cc8f6abd3dVariant1Type.Middleware => "middleware",
                AutoSDKSharedbd3f01cc8f6abd3dVariant1Type.MiddlewareInvocation => "middleware-invocation",
                AutoSDKSharedbd3f01cc8f6abd3dVariant1Type.Report => "report",
                AutoSDKSharedbd3f01cc8f6abd3dVariant1Type.Stderr => "stderr",
                AutoSDKSharedbd3f01cc8f6abd3dVariant1Type.Stdout => "stdout",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharedbd3f01cc8f6abd3dVariant1Type? ToEnum(string value)
        {
            return value switch
            {
                "command" => AutoSDKSharedbd3f01cc8f6abd3dVariant1Type.Command,
                "delimiter" => AutoSDKSharedbd3f01cc8f6abd3dVariant1Type.Delimiter,
                "deployment-state" => AutoSDKSharedbd3f01cc8f6abd3dVariant1Type.DeploymentState,
                "edge-function-invocation" => AutoSDKSharedbd3f01cc8f6abd3dVariant1Type.EdgeFunctionInvocation,
                "exit" => AutoSDKSharedbd3f01cc8f6abd3dVariant1Type.Exit,
                "fatal" => AutoSDKSharedbd3f01cc8f6abd3dVariant1Type.Fatal,
                "metric" => AutoSDKSharedbd3f01cc8f6abd3dVariant1Type.Metric,
                "middleware" => AutoSDKSharedbd3f01cc8f6abd3dVariant1Type.Middleware,
                "middleware-invocation" => AutoSDKSharedbd3f01cc8f6abd3dVariant1Type.MiddlewareInvocation,
                "report" => AutoSDKSharedbd3f01cc8f6abd3dVariant1Type.Report,
                "stderr" => AutoSDKSharedbd3f01cc8f6abd3dVariant1Type.Stderr,
                "stdout" => AutoSDKSharedbd3f01cc8f6abd3dVariant1Type.Stdout,
                _ => null,
            };
        }
    }
}