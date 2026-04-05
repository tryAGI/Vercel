
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetDeploymentEventsResponseItemVariant2Type
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
    public static class GetDeploymentEventsResponseItemVariant2TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetDeploymentEventsResponseItemVariant2Type value)
        {
            return value switch
            {
                GetDeploymentEventsResponseItemVariant2Type.Command => "command",
                GetDeploymentEventsResponseItemVariant2Type.Delimiter => "delimiter",
                GetDeploymentEventsResponseItemVariant2Type.DeploymentState => "deployment-state",
                GetDeploymentEventsResponseItemVariant2Type.EdgeFunctionInvocation => "edge-function-invocation",
                GetDeploymentEventsResponseItemVariant2Type.Exit => "exit",
                GetDeploymentEventsResponseItemVariant2Type.Fatal => "fatal",
                GetDeploymentEventsResponseItemVariant2Type.Metric => "metric",
                GetDeploymentEventsResponseItemVariant2Type.Middleware => "middleware",
                GetDeploymentEventsResponseItemVariant2Type.MiddlewareInvocation => "middleware-invocation",
                GetDeploymentEventsResponseItemVariant2Type.Report => "report",
                GetDeploymentEventsResponseItemVariant2Type.Stderr => "stderr",
                GetDeploymentEventsResponseItemVariant2Type.Stdout => "stdout",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetDeploymentEventsResponseItemVariant2Type? ToEnum(string value)
        {
            return value switch
            {
                "command" => GetDeploymentEventsResponseItemVariant2Type.Command,
                "delimiter" => GetDeploymentEventsResponseItemVariant2Type.Delimiter,
                "deployment-state" => GetDeploymentEventsResponseItemVariant2Type.DeploymentState,
                "edge-function-invocation" => GetDeploymentEventsResponseItemVariant2Type.EdgeFunctionInvocation,
                "exit" => GetDeploymentEventsResponseItemVariant2Type.Exit,
                "fatal" => GetDeploymentEventsResponseItemVariant2Type.Fatal,
                "metric" => GetDeploymentEventsResponseItemVariant2Type.Metric,
                "middleware" => GetDeploymentEventsResponseItemVariant2Type.Middleware,
                "middleware-invocation" => GetDeploymentEventsResponseItemVariant2Type.MiddlewareInvocation,
                "report" => GetDeploymentEventsResponseItemVariant2Type.Report,
                "stderr" => GetDeploymentEventsResponseItemVariant2Type.Stderr,
                "stdout" => GetDeploymentEventsResponseItemVariant2Type.Stdout,
                _ => null,
            };
        }
    }
}