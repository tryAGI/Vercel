
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetDeploymentEventsResponseVariant3Variant1Type
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
    public static class GetDeploymentEventsResponseVariant3Variant1TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetDeploymentEventsResponseVariant3Variant1Type value)
        {
            return value switch
            {
                GetDeploymentEventsResponseVariant3Variant1Type.Command => "command",
                GetDeploymentEventsResponseVariant3Variant1Type.Delimiter => "delimiter",
                GetDeploymentEventsResponseVariant3Variant1Type.DeploymentState => "deployment-state",
                GetDeploymentEventsResponseVariant3Variant1Type.EdgeFunctionInvocation => "edge-function-invocation",
                GetDeploymentEventsResponseVariant3Variant1Type.Exit => "exit",
                GetDeploymentEventsResponseVariant3Variant1Type.Fatal => "fatal",
                GetDeploymentEventsResponseVariant3Variant1Type.Metric => "metric",
                GetDeploymentEventsResponseVariant3Variant1Type.Middleware => "middleware",
                GetDeploymentEventsResponseVariant3Variant1Type.MiddlewareInvocation => "middleware-invocation",
                GetDeploymentEventsResponseVariant3Variant1Type.Report => "report",
                GetDeploymentEventsResponseVariant3Variant1Type.Stderr => "stderr",
                GetDeploymentEventsResponseVariant3Variant1Type.Stdout => "stdout",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetDeploymentEventsResponseVariant3Variant1Type? ToEnum(string value)
        {
            return value switch
            {
                "command" => GetDeploymentEventsResponseVariant3Variant1Type.Command,
                "delimiter" => GetDeploymentEventsResponseVariant3Variant1Type.Delimiter,
                "deployment-state" => GetDeploymentEventsResponseVariant3Variant1Type.DeploymentState,
                "edge-function-invocation" => GetDeploymentEventsResponseVariant3Variant1Type.EdgeFunctionInvocation,
                "exit" => GetDeploymentEventsResponseVariant3Variant1Type.Exit,
                "fatal" => GetDeploymentEventsResponseVariant3Variant1Type.Fatal,
                "metric" => GetDeploymentEventsResponseVariant3Variant1Type.Metric,
                "middleware" => GetDeploymentEventsResponseVariant3Variant1Type.Middleware,
                "middleware-invocation" => GetDeploymentEventsResponseVariant3Variant1Type.MiddlewareInvocation,
                "report" => GetDeploymentEventsResponseVariant3Variant1Type.Report,
                "stderr" => GetDeploymentEventsResponseVariant3Variant1Type.Stderr,
                "stdout" => GetDeploymentEventsResponseVariant3Variant1Type.Stdout,
                _ => null,
            };
        }
    }
}