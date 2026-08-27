
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum GetDeploymentEventsResponseItemVariant3Variant2Type
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
    public static class GetDeploymentEventsResponseItemVariant3Variant2TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetDeploymentEventsResponseItemVariant3Variant2Type value)
        {
            return value switch
            {
                GetDeploymentEventsResponseItemVariant3Variant2Type.Command => "command",
                GetDeploymentEventsResponseItemVariant3Variant2Type.Delimiter => "delimiter",
                GetDeploymentEventsResponseItemVariant3Variant2Type.DeploymentState => "deployment-state",
                GetDeploymentEventsResponseItemVariant3Variant2Type.EdgeFunctionInvocation => "edge-function-invocation",
                GetDeploymentEventsResponseItemVariant3Variant2Type.Exit => "exit",
                GetDeploymentEventsResponseItemVariant3Variant2Type.Fatal => "fatal",
                GetDeploymentEventsResponseItemVariant3Variant2Type.Metric => "metric",
                GetDeploymentEventsResponseItemVariant3Variant2Type.Middleware => "middleware",
                GetDeploymentEventsResponseItemVariant3Variant2Type.MiddlewareInvocation => "middleware-invocation",
                GetDeploymentEventsResponseItemVariant3Variant2Type.Report => "report",
                GetDeploymentEventsResponseItemVariant3Variant2Type.Stderr => "stderr",
                GetDeploymentEventsResponseItemVariant3Variant2Type.Stdout => "stdout",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetDeploymentEventsResponseItemVariant3Variant2Type? ToEnum(string value)
        {
            return value switch
            {
                "command" => GetDeploymentEventsResponseItemVariant3Variant2Type.Command,
                "delimiter" => GetDeploymentEventsResponseItemVariant3Variant2Type.Delimiter,
                "deployment-state" => GetDeploymentEventsResponseItemVariant3Variant2Type.DeploymentState,
                "edge-function-invocation" => GetDeploymentEventsResponseItemVariant3Variant2Type.EdgeFunctionInvocation,
                "exit" => GetDeploymentEventsResponseItemVariant3Variant2Type.Exit,
                "fatal" => GetDeploymentEventsResponseItemVariant3Variant2Type.Fatal,
                "metric" => GetDeploymentEventsResponseItemVariant3Variant2Type.Metric,
                "middleware" => GetDeploymentEventsResponseItemVariant3Variant2Type.Middleware,
                "middleware-invocation" => GetDeploymentEventsResponseItemVariant3Variant2Type.MiddlewareInvocation,
                "report" => GetDeploymentEventsResponseItemVariant3Variant2Type.Report,
                "stderr" => GetDeploymentEventsResponseItemVariant3Variant2Type.Stderr,
                "stdout" => GetDeploymentEventsResponseItemVariant3Variant2Type.Stdout,
                _ => null,
            };
        }
    }
}