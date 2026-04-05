
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetDeploymentEventsResponseItemVariant1Type
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
    public static class GetDeploymentEventsResponseItemVariant1TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetDeploymentEventsResponseItemVariant1Type value)
        {
            return value switch
            {
                GetDeploymentEventsResponseItemVariant1Type.Command => "command",
                GetDeploymentEventsResponseItemVariant1Type.Delimiter => "delimiter",
                GetDeploymentEventsResponseItemVariant1Type.DeploymentState => "deployment-state",
                GetDeploymentEventsResponseItemVariant1Type.EdgeFunctionInvocation => "edge-function-invocation",
                GetDeploymentEventsResponseItemVariant1Type.Exit => "exit",
                GetDeploymentEventsResponseItemVariant1Type.Fatal => "fatal",
                GetDeploymentEventsResponseItemVariant1Type.Metric => "metric",
                GetDeploymentEventsResponseItemVariant1Type.Middleware => "middleware",
                GetDeploymentEventsResponseItemVariant1Type.MiddlewareInvocation => "middleware-invocation",
                GetDeploymentEventsResponseItemVariant1Type.Report => "report",
                GetDeploymentEventsResponseItemVariant1Type.Stderr => "stderr",
                GetDeploymentEventsResponseItemVariant1Type.Stdout => "stdout",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetDeploymentEventsResponseItemVariant1Type? ToEnum(string value)
        {
            return value switch
            {
                "command" => GetDeploymentEventsResponseItemVariant1Type.Command,
                "delimiter" => GetDeploymentEventsResponseItemVariant1Type.Delimiter,
                "deployment-state" => GetDeploymentEventsResponseItemVariant1Type.DeploymentState,
                "edge-function-invocation" => GetDeploymentEventsResponseItemVariant1Type.EdgeFunctionInvocation,
                "exit" => GetDeploymentEventsResponseItemVariant1Type.Exit,
                "fatal" => GetDeploymentEventsResponseItemVariant1Type.Fatal,
                "metric" => GetDeploymentEventsResponseItemVariant1Type.Metric,
                "middleware" => GetDeploymentEventsResponseItemVariant1Type.Middleware,
                "middleware-invocation" => GetDeploymentEventsResponseItemVariant1Type.MiddlewareInvocation,
                "report" => GetDeploymentEventsResponseItemVariant1Type.Report,
                "stderr" => GetDeploymentEventsResponseItemVariant1Type.Stderr,
                "stdout" => GetDeploymentEventsResponseItemVariant1Type.Stdout,
                _ => null,
            };
        }
    }
}