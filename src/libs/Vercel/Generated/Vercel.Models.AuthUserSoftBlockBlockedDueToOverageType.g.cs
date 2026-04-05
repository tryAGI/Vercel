
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum AuthUserSoftBlockBlockedDueToOverageType
    {
        /// <summary>
        /// 
        /// </summary>
        AnalyticsUsage,
        /// <summary>
        /// 
        /// </summary>
        Artifacts,
        /// <summary>
        /// 
        /// </summary>
        Bandwidth,
        /// <summary>
        /// 
        /// </summary>
        BlobDataTransfer,
        /// <summary>
        /// 
        /// </summary>
        BlobTotalAdvancedRequests,
        /// <summary>
        /// 
        /// </summary>
        BlobTotalAvgSizeInBytes,
        /// <summary>
        /// 
        /// </summary>
        BlobTotalGetResponseObjectSizeInBytes,
        /// <summary>
        /// 
        /// </summary>
        BlobTotalSimpleRequests,
        /// <summary>
        /// 
        /// </summary>
        ConnectDataTransfer,
        /// <summary>
        /// 
        /// </summary>
        DataCacheRead,
        /// <summary>
        /// 
        /// </summary>
        DataCacheWrite,
        /// <summary>
        /// 
        /// </summary>
        EdgeConfigRead,
        /// <summary>
        /// 
        /// </summary>
        EdgeConfigWrite,
        /// <summary>
        /// 
        /// </summary>
        EdgeFunctionExecutionUnits,
        /// <summary>
        /// 
        /// </summary>
        EdgeMiddlewareInvocations,
        /// <summary>
        /// 
        /// </summary>
        EdgeRequest,
        /// <summary>
        /// 
        /// </summary>
        EdgeRequestAdditionalCpuDuration,
        /// <summary>
        /// 
        /// </summary>
        ElasticConcurrencyBuildSlots,
        /// <summary>
        /// 
        /// </summary>
        FastDataTransfer,
        /// <summary>
        /// 
        /// </summary>
        FastOriginTransfer,
        /// <summary>
        /// 
        /// </summary>
        FluidCpuDuration,
        /// <summary>
        /// 
        /// </summary>
        FluidDuration,
        /// <summary>
        /// 
        /// </summary>
        FunctionDuration,
        /// <summary>
        /// 
        /// </summary>
        FunctionInvocation,
        /// <summary>
        /// 
        /// </summary>
        ImageOptimizationCacheRead,
        /// <summary>
        /// 
        /// </summary>
        ImageOptimizationCacheWrite,
        /// <summary>
        /// 
        /// </summary>
        ImageOptimizationTransformation,
        /// <summary>
        /// 
        /// </summary>
        LogDrainsVolume,
        /// <summary>
        /// 
        /// </summary>
        MonitoringMetric,
        /// <summary>
        /// 
        /// </summary>
        ObservabilityEvent,
        /// <summary>
        /// 
        /// </summary>
        OnDemandConcurrencyMinutes,
        /// <summary>
        /// 
        /// </summary>
        RuntimeCacheRead,
        /// <summary>
        /// 
        /// </summary>
        RuntimeCacheWrite,
        /// <summary>
        /// 
        /// </summary>
        ServerlessFunctionExecution,
        /// <summary>
        /// 
        /// </summary>
        SourceImages,
        /// <summary>
        /// 
        /// </summary>
        WafOwaspExcessBytes,
        /// <summary>
        /// 
        /// </summary>
        WafOwaspRequests,
        /// <summary>
        /// 
        /// </summary>
        WafRateLimitRequest,
        /// <summary>
        /// 
        /// </summary>
        WebAnalyticsEvent,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AuthUserSoftBlockBlockedDueToOverageTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AuthUserSoftBlockBlockedDueToOverageType value)
        {
            return value switch
            {
                AuthUserSoftBlockBlockedDueToOverageType.AnalyticsUsage => "analyticsUsage",
                AuthUserSoftBlockBlockedDueToOverageType.Artifacts => "artifacts",
                AuthUserSoftBlockBlockedDueToOverageType.Bandwidth => "bandwidth",
                AuthUserSoftBlockBlockedDueToOverageType.BlobDataTransfer => "blobDataTransfer",
                AuthUserSoftBlockBlockedDueToOverageType.BlobTotalAdvancedRequests => "blobTotalAdvancedRequests",
                AuthUserSoftBlockBlockedDueToOverageType.BlobTotalAvgSizeInBytes => "blobTotalAvgSizeInBytes",
                AuthUserSoftBlockBlockedDueToOverageType.BlobTotalGetResponseObjectSizeInBytes => "blobTotalGetResponseObjectSizeInBytes",
                AuthUserSoftBlockBlockedDueToOverageType.BlobTotalSimpleRequests => "blobTotalSimpleRequests",
                AuthUserSoftBlockBlockedDueToOverageType.ConnectDataTransfer => "connectDataTransfer",
                AuthUserSoftBlockBlockedDueToOverageType.DataCacheRead => "dataCacheRead",
                AuthUserSoftBlockBlockedDueToOverageType.DataCacheWrite => "dataCacheWrite",
                AuthUserSoftBlockBlockedDueToOverageType.EdgeConfigRead => "edgeConfigRead",
                AuthUserSoftBlockBlockedDueToOverageType.EdgeConfigWrite => "edgeConfigWrite",
                AuthUserSoftBlockBlockedDueToOverageType.EdgeFunctionExecutionUnits => "edgeFunctionExecutionUnits",
                AuthUserSoftBlockBlockedDueToOverageType.EdgeMiddlewareInvocations => "edgeMiddlewareInvocations",
                AuthUserSoftBlockBlockedDueToOverageType.EdgeRequest => "edgeRequest",
                AuthUserSoftBlockBlockedDueToOverageType.EdgeRequestAdditionalCpuDuration => "edgeRequestAdditionalCpuDuration",
                AuthUserSoftBlockBlockedDueToOverageType.ElasticConcurrencyBuildSlots => "elasticConcurrencyBuildSlots",
                AuthUserSoftBlockBlockedDueToOverageType.FastDataTransfer => "fastDataTransfer",
                AuthUserSoftBlockBlockedDueToOverageType.FastOriginTransfer => "fastOriginTransfer",
                AuthUserSoftBlockBlockedDueToOverageType.FluidCpuDuration => "fluidCpuDuration",
                AuthUserSoftBlockBlockedDueToOverageType.FluidDuration => "fluidDuration",
                AuthUserSoftBlockBlockedDueToOverageType.FunctionDuration => "functionDuration",
                AuthUserSoftBlockBlockedDueToOverageType.FunctionInvocation => "functionInvocation",
                AuthUserSoftBlockBlockedDueToOverageType.ImageOptimizationCacheRead => "imageOptimizationCacheRead",
                AuthUserSoftBlockBlockedDueToOverageType.ImageOptimizationCacheWrite => "imageOptimizationCacheWrite",
                AuthUserSoftBlockBlockedDueToOverageType.ImageOptimizationTransformation => "imageOptimizationTransformation",
                AuthUserSoftBlockBlockedDueToOverageType.LogDrainsVolume => "logDrainsVolume",
                AuthUserSoftBlockBlockedDueToOverageType.MonitoringMetric => "monitoringMetric",
                AuthUserSoftBlockBlockedDueToOverageType.ObservabilityEvent => "observabilityEvent",
                AuthUserSoftBlockBlockedDueToOverageType.OnDemandConcurrencyMinutes => "onDemandConcurrencyMinutes",
                AuthUserSoftBlockBlockedDueToOverageType.RuntimeCacheRead => "runtimeCacheRead",
                AuthUserSoftBlockBlockedDueToOverageType.RuntimeCacheWrite => "runtimeCacheWrite",
                AuthUserSoftBlockBlockedDueToOverageType.ServerlessFunctionExecution => "serverlessFunctionExecution",
                AuthUserSoftBlockBlockedDueToOverageType.SourceImages => "sourceImages",
                AuthUserSoftBlockBlockedDueToOverageType.WafOwaspExcessBytes => "wafOwaspExcessBytes",
                AuthUserSoftBlockBlockedDueToOverageType.WafOwaspRequests => "wafOwaspRequests",
                AuthUserSoftBlockBlockedDueToOverageType.WafRateLimitRequest => "wafRateLimitRequest",
                AuthUserSoftBlockBlockedDueToOverageType.WebAnalyticsEvent => "webAnalyticsEvent",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AuthUserSoftBlockBlockedDueToOverageType? ToEnum(string value)
        {
            return value switch
            {
                "analyticsUsage" => AuthUserSoftBlockBlockedDueToOverageType.AnalyticsUsage,
                "artifacts" => AuthUserSoftBlockBlockedDueToOverageType.Artifacts,
                "bandwidth" => AuthUserSoftBlockBlockedDueToOverageType.Bandwidth,
                "blobDataTransfer" => AuthUserSoftBlockBlockedDueToOverageType.BlobDataTransfer,
                "blobTotalAdvancedRequests" => AuthUserSoftBlockBlockedDueToOverageType.BlobTotalAdvancedRequests,
                "blobTotalAvgSizeInBytes" => AuthUserSoftBlockBlockedDueToOverageType.BlobTotalAvgSizeInBytes,
                "blobTotalGetResponseObjectSizeInBytes" => AuthUserSoftBlockBlockedDueToOverageType.BlobTotalGetResponseObjectSizeInBytes,
                "blobTotalSimpleRequests" => AuthUserSoftBlockBlockedDueToOverageType.BlobTotalSimpleRequests,
                "connectDataTransfer" => AuthUserSoftBlockBlockedDueToOverageType.ConnectDataTransfer,
                "dataCacheRead" => AuthUserSoftBlockBlockedDueToOverageType.DataCacheRead,
                "dataCacheWrite" => AuthUserSoftBlockBlockedDueToOverageType.DataCacheWrite,
                "edgeConfigRead" => AuthUserSoftBlockBlockedDueToOverageType.EdgeConfigRead,
                "edgeConfigWrite" => AuthUserSoftBlockBlockedDueToOverageType.EdgeConfigWrite,
                "edgeFunctionExecutionUnits" => AuthUserSoftBlockBlockedDueToOverageType.EdgeFunctionExecutionUnits,
                "edgeMiddlewareInvocations" => AuthUserSoftBlockBlockedDueToOverageType.EdgeMiddlewareInvocations,
                "edgeRequest" => AuthUserSoftBlockBlockedDueToOverageType.EdgeRequest,
                "edgeRequestAdditionalCpuDuration" => AuthUserSoftBlockBlockedDueToOverageType.EdgeRequestAdditionalCpuDuration,
                "elasticConcurrencyBuildSlots" => AuthUserSoftBlockBlockedDueToOverageType.ElasticConcurrencyBuildSlots,
                "fastDataTransfer" => AuthUserSoftBlockBlockedDueToOverageType.FastDataTransfer,
                "fastOriginTransfer" => AuthUserSoftBlockBlockedDueToOverageType.FastOriginTransfer,
                "fluidCpuDuration" => AuthUserSoftBlockBlockedDueToOverageType.FluidCpuDuration,
                "fluidDuration" => AuthUserSoftBlockBlockedDueToOverageType.FluidDuration,
                "functionDuration" => AuthUserSoftBlockBlockedDueToOverageType.FunctionDuration,
                "functionInvocation" => AuthUserSoftBlockBlockedDueToOverageType.FunctionInvocation,
                "imageOptimizationCacheRead" => AuthUserSoftBlockBlockedDueToOverageType.ImageOptimizationCacheRead,
                "imageOptimizationCacheWrite" => AuthUserSoftBlockBlockedDueToOverageType.ImageOptimizationCacheWrite,
                "imageOptimizationTransformation" => AuthUserSoftBlockBlockedDueToOverageType.ImageOptimizationTransformation,
                "logDrainsVolume" => AuthUserSoftBlockBlockedDueToOverageType.LogDrainsVolume,
                "monitoringMetric" => AuthUserSoftBlockBlockedDueToOverageType.MonitoringMetric,
                "observabilityEvent" => AuthUserSoftBlockBlockedDueToOverageType.ObservabilityEvent,
                "onDemandConcurrencyMinutes" => AuthUserSoftBlockBlockedDueToOverageType.OnDemandConcurrencyMinutes,
                "runtimeCacheRead" => AuthUserSoftBlockBlockedDueToOverageType.RuntimeCacheRead,
                "runtimeCacheWrite" => AuthUserSoftBlockBlockedDueToOverageType.RuntimeCacheWrite,
                "serverlessFunctionExecution" => AuthUserSoftBlockBlockedDueToOverageType.ServerlessFunctionExecution,
                "sourceImages" => AuthUserSoftBlockBlockedDueToOverageType.SourceImages,
                "wafOwaspExcessBytes" => AuthUserSoftBlockBlockedDueToOverageType.WafOwaspExcessBytes,
                "wafOwaspRequests" => AuthUserSoftBlockBlockedDueToOverageType.WafOwaspRequests,
                "wafRateLimitRequest" => AuthUserSoftBlockBlockedDueToOverageType.WafRateLimitRequest,
                "webAnalyticsEvent" => AuthUserSoftBlockBlockedDueToOverageType.WebAnalyticsEvent,
                _ => null,
            };
        }
    }
}