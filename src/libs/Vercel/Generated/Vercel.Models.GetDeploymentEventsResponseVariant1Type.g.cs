
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetDeploymentEventsResponseVariant1Type
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
    public static class GetDeploymentEventsResponseVariant1TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetDeploymentEventsResponseVariant1Type value)
        {
            return value switch
            {
                GetDeploymentEventsResponseVariant1Type.Command => "command",
                GetDeploymentEventsResponseVariant1Type.Delimiter => "delimiter",
                GetDeploymentEventsResponseVariant1Type.DeploymentState => "deployment-state",
                GetDeploymentEventsResponseVariant1Type.EdgeFunctionInvocation => "edge-function-invocation",
                GetDeploymentEventsResponseVariant1Type.Exit => "exit",
                GetDeploymentEventsResponseVariant1Type.Fatal => "fatal",
                GetDeploymentEventsResponseVariant1Type.Metric => "metric",
                GetDeploymentEventsResponseVariant1Type.Middleware => "middleware",
                GetDeploymentEventsResponseVariant1Type.MiddlewareInvocation => "middleware-invocation",
                GetDeploymentEventsResponseVariant1Type.Report => "report",
                GetDeploymentEventsResponseVariant1Type.Stderr => "stderr",
                GetDeploymentEventsResponseVariant1Type.Stdout => "stdout",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetDeploymentEventsResponseVariant1Type? ToEnum(string value)
        {
            return value switch
            {
                "command" => GetDeploymentEventsResponseVariant1Type.Command,
                "delimiter" => GetDeploymentEventsResponseVariant1Type.Delimiter,
                "deployment-state" => GetDeploymentEventsResponseVariant1Type.DeploymentState,
                "edge-function-invocation" => GetDeploymentEventsResponseVariant1Type.EdgeFunctionInvocation,
                "exit" => GetDeploymentEventsResponseVariant1Type.Exit,
                "fatal" => GetDeploymentEventsResponseVariant1Type.Fatal,
                "metric" => GetDeploymentEventsResponseVariant1Type.Metric,
                "middleware" => GetDeploymentEventsResponseVariant1Type.Middleware,
                "middleware-invocation" => GetDeploymentEventsResponseVariant1Type.MiddlewareInvocation,
                "report" => GetDeploymentEventsResponseVariant1Type.Report,
                "stderr" => GetDeploymentEventsResponseVariant1Type.Stderr,
                "stdout" => GetDeploymentEventsResponseVariant1Type.Stdout,
                _ => null,
            };
        }
    }
}