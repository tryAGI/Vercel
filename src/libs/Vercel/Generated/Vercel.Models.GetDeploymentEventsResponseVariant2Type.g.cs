
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetDeploymentEventsResponseVariant2Type
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
    public static class GetDeploymentEventsResponseVariant2TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetDeploymentEventsResponseVariant2Type value)
        {
            return value switch
            {
                GetDeploymentEventsResponseVariant2Type.Command => "command",
                GetDeploymentEventsResponseVariant2Type.Delimiter => "delimiter",
                GetDeploymentEventsResponseVariant2Type.DeploymentState => "deployment-state",
                GetDeploymentEventsResponseVariant2Type.EdgeFunctionInvocation => "edge-function-invocation",
                GetDeploymentEventsResponseVariant2Type.Exit => "exit",
                GetDeploymentEventsResponseVariant2Type.Fatal => "fatal",
                GetDeploymentEventsResponseVariant2Type.Metric => "metric",
                GetDeploymentEventsResponseVariant2Type.Middleware => "middleware",
                GetDeploymentEventsResponseVariant2Type.MiddlewareInvocation => "middleware-invocation",
                GetDeploymentEventsResponseVariant2Type.Report => "report",
                GetDeploymentEventsResponseVariant2Type.Stderr => "stderr",
                GetDeploymentEventsResponseVariant2Type.Stdout => "stdout",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetDeploymentEventsResponseVariant2Type? ToEnum(string value)
        {
            return value switch
            {
                "command" => GetDeploymentEventsResponseVariant2Type.Command,
                "delimiter" => GetDeploymentEventsResponseVariant2Type.Delimiter,
                "deployment-state" => GetDeploymentEventsResponseVariant2Type.DeploymentState,
                "edge-function-invocation" => GetDeploymentEventsResponseVariant2Type.EdgeFunctionInvocation,
                "exit" => GetDeploymentEventsResponseVariant2Type.Exit,
                "fatal" => GetDeploymentEventsResponseVariant2Type.Fatal,
                "metric" => GetDeploymentEventsResponseVariant2Type.Metric,
                "middleware" => GetDeploymentEventsResponseVariant2Type.Middleware,
                "middleware-invocation" => GetDeploymentEventsResponseVariant2Type.MiddlewareInvocation,
                "report" => GetDeploymentEventsResponseVariant2Type.Report,
                "stderr" => GetDeploymentEventsResponseVariant2Type.Stderr,
                "stdout" => GetDeploymentEventsResponseVariant2Type.Stdout,
                _ => null,
            };
        }
    }
}