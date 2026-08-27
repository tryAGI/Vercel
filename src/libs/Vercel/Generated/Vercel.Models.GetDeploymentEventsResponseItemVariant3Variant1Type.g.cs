
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum GetDeploymentEventsResponseItemVariant3Variant1Type
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
    public static class GetDeploymentEventsResponseItemVariant3Variant1TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetDeploymentEventsResponseItemVariant3Variant1Type value)
        {
            return value switch
            {
                GetDeploymentEventsResponseItemVariant3Variant1Type.Command => "command",
                GetDeploymentEventsResponseItemVariant3Variant1Type.Delimiter => "delimiter",
                GetDeploymentEventsResponseItemVariant3Variant1Type.DeploymentState => "deployment-state",
                GetDeploymentEventsResponseItemVariant3Variant1Type.EdgeFunctionInvocation => "edge-function-invocation",
                GetDeploymentEventsResponseItemVariant3Variant1Type.Exit => "exit",
                GetDeploymentEventsResponseItemVariant3Variant1Type.Fatal => "fatal",
                GetDeploymentEventsResponseItemVariant3Variant1Type.Metric => "metric",
                GetDeploymentEventsResponseItemVariant3Variant1Type.Middleware => "middleware",
                GetDeploymentEventsResponseItemVariant3Variant1Type.MiddlewareInvocation => "middleware-invocation",
                GetDeploymentEventsResponseItemVariant3Variant1Type.Report => "report",
                GetDeploymentEventsResponseItemVariant3Variant1Type.Stderr => "stderr",
                GetDeploymentEventsResponseItemVariant3Variant1Type.Stdout => "stdout",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetDeploymentEventsResponseItemVariant3Variant1Type? ToEnum(string value)
        {
            return value switch
            {
                "command" => GetDeploymentEventsResponseItemVariant3Variant1Type.Command,
                "delimiter" => GetDeploymentEventsResponseItemVariant3Variant1Type.Delimiter,
                "deployment-state" => GetDeploymentEventsResponseItemVariant3Variant1Type.DeploymentState,
                "edge-function-invocation" => GetDeploymentEventsResponseItemVariant3Variant1Type.EdgeFunctionInvocation,
                "exit" => GetDeploymentEventsResponseItemVariant3Variant1Type.Exit,
                "fatal" => GetDeploymentEventsResponseItemVariant3Variant1Type.Fatal,
                "metric" => GetDeploymentEventsResponseItemVariant3Variant1Type.Metric,
                "middleware" => GetDeploymentEventsResponseItemVariant3Variant1Type.Middleware,
                "middleware-invocation" => GetDeploymentEventsResponseItemVariant3Variant1Type.MiddlewareInvocation,
                "report" => GetDeploymentEventsResponseItemVariant3Variant1Type.Report,
                "stderr" => GetDeploymentEventsResponseItemVariant3Variant1Type.Stderr,
                "stdout" => GetDeploymentEventsResponseItemVariant3Variant1Type.Stdout,
                _ => null,
            };
        }
    }
}