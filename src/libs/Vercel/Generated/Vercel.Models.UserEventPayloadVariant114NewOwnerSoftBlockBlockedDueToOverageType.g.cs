
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant114NewOwnerSoftBlockBlockedDueToOverageType
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
    public static class UserEventPayloadVariant114NewOwnerSoftBlockBlockedDueToOverageTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant114NewOwnerSoftBlockBlockedDueToOverageType value)
        {
            return value switch
            {
                UserEventPayloadVariant114NewOwnerSoftBlockBlockedDueToOverageType.AnalyticsUsage => "analyticsUsage",
                UserEventPayloadVariant114NewOwnerSoftBlockBlockedDueToOverageType.Artifacts => "artifacts",
                UserEventPayloadVariant114NewOwnerSoftBlockBlockedDueToOverageType.Bandwidth => "bandwidth",
                UserEventPayloadVariant114NewOwnerSoftBlockBlockedDueToOverageType.BlobDataTransfer => "blobDataTransfer",
                UserEventPayloadVariant114NewOwnerSoftBlockBlockedDueToOverageType.BlobTotalAdvancedRequests => "blobTotalAdvancedRequests",
                UserEventPayloadVariant114NewOwnerSoftBlockBlockedDueToOverageType.BlobTotalAvgSizeInBytes => "blobTotalAvgSizeInBytes",
                UserEventPayloadVariant114NewOwnerSoftBlockBlockedDueToOverageType.BlobTotalGetResponseObjectSizeInBytes => "blobTotalGetResponseObjectSizeInBytes",
                UserEventPayloadVariant114NewOwnerSoftBlockBlockedDueToOverageType.BlobTotalSimpleRequests => "blobTotalSimpleRequests",
                UserEventPayloadVariant114NewOwnerSoftBlockBlockedDueToOverageType.ConnectDataTransfer => "connectDataTransfer",
                UserEventPayloadVariant114NewOwnerSoftBlockBlockedDueToOverageType.DataCacheRead => "dataCacheRead",
                UserEventPayloadVariant114NewOwnerSoftBlockBlockedDueToOverageType.DataCacheWrite => "dataCacheWrite",
                UserEventPayloadVariant114NewOwnerSoftBlockBlockedDueToOverageType.EdgeConfigRead => "edgeConfigRead",
                UserEventPayloadVariant114NewOwnerSoftBlockBlockedDueToOverageType.EdgeConfigWrite => "edgeConfigWrite",
                UserEventPayloadVariant114NewOwnerSoftBlockBlockedDueToOverageType.EdgeFunctionExecutionUnits => "edgeFunctionExecutionUnits",
                UserEventPayloadVariant114NewOwnerSoftBlockBlockedDueToOverageType.EdgeMiddlewareInvocations => "edgeMiddlewareInvocations",
                UserEventPayloadVariant114NewOwnerSoftBlockBlockedDueToOverageType.EdgeRequest => "edgeRequest",
                UserEventPayloadVariant114NewOwnerSoftBlockBlockedDueToOverageType.EdgeRequestAdditionalCpuDuration => "edgeRequestAdditionalCpuDuration",
                UserEventPayloadVariant114NewOwnerSoftBlockBlockedDueToOverageType.ElasticConcurrencyBuildSlots => "elasticConcurrencyBuildSlots",
                UserEventPayloadVariant114NewOwnerSoftBlockBlockedDueToOverageType.FastDataTransfer => "fastDataTransfer",
                UserEventPayloadVariant114NewOwnerSoftBlockBlockedDueToOverageType.FastOriginTransfer => "fastOriginTransfer",
                UserEventPayloadVariant114NewOwnerSoftBlockBlockedDueToOverageType.FluidCpuDuration => "fluidCpuDuration",
                UserEventPayloadVariant114NewOwnerSoftBlockBlockedDueToOverageType.FluidDuration => "fluidDuration",
                UserEventPayloadVariant114NewOwnerSoftBlockBlockedDueToOverageType.FunctionDuration => "functionDuration",
                UserEventPayloadVariant114NewOwnerSoftBlockBlockedDueToOverageType.FunctionInvocation => "functionInvocation",
                UserEventPayloadVariant114NewOwnerSoftBlockBlockedDueToOverageType.ImageOptimizationCacheRead => "imageOptimizationCacheRead",
                UserEventPayloadVariant114NewOwnerSoftBlockBlockedDueToOverageType.ImageOptimizationCacheWrite => "imageOptimizationCacheWrite",
                UserEventPayloadVariant114NewOwnerSoftBlockBlockedDueToOverageType.ImageOptimizationTransformation => "imageOptimizationTransformation",
                UserEventPayloadVariant114NewOwnerSoftBlockBlockedDueToOverageType.LogDrainsVolume => "logDrainsVolume",
                UserEventPayloadVariant114NewOwnerSoftBlockBlockedDueToOverageType.MonitoringMetric => "monitoringMetric",
                UserEventPayloadVariant114NewOwnerSoftBlockBlockedDueToOverageType.ObservabilityEvent => "observabilityEvent",
                UserEventPayloadVariant114NewOwnerSoftBlockBlockedDueToOverageType.OnDemandConcurrencyMinutes => "onDemandConcurrencyMinutes",
                UserEventPayloadVariant114NewOwnerSoftBlockBlockedDueToOverageType.RuntimeCacheRead => "runtimeCacheRead",
                UserEventPayloadVariant114NewOwnerSoftBlockBlockedDueToOverageType.RuntimeCacheWrite => "runtimeCacheWrite",
                UserEventPayloadVariant114NewOwnerSoftBlockBlockedDueToOverageType.ServerlessFunctionExecution => "serverlessFunctionExecution",
                UserEventPayloadVariant114NewOwnerSoftBlockBlockedDueToOverageType.SourceImages => "sourceImages",
                UserEventPayloadVariant114NewOwnerSoftBlockBlockedDueToOverageType.WafOwaspExcessBytes => "wafOwaspExcessBytes",
                UserEventPayloadVariant114NewOwnerSoftBlockBlockedDueToOverageType.WafOwaspRequests => "wafOwaspRequests",
                UserEventPayloadVariant114NewOwnerSoftBlockBlockedDueToOverageType.WafRateLimitRequest => "wafRateLimitRequest",
                UserEventPayloadVariant114NewOwnerSoftBlockBlockedDueToOverageType.WebAnalyticsEvent => "webAnalyticsEvent",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant114NewOwnerSoftBlockBlockedDueToOverageType? ToEnum(string value)
        {
            return value switch
            {
                "analyticsUsage" => UserEventPayloadVariant114NewOwnerSoftBlockBlockedDueToOverageType.AnalyticsUsage,
                "artifacts" => UserEventPayloadVariant114NewOwnerSoftBlockBlockedDueToOverageType.Artifacts,
                "bandwidth" => UserEventPayloadVariant114NewOwnerSoftBlockBlockedDueToOverageType.Bandwidth,
                "blobDataTransfer" => UserEventPayloadVariant114NewOwnerSoftBlockBlockedDueToOverageType.BlobDataTransfer,
                "blobTotalAdvancedRequests" => UserEventPayloadVariant114NewOwnerSoftBlockBlockedDueToOverageType.BlobTotalAdvancedRequests,
                "blobTotalAvgSizeInBytes" => UserEventPayloadVariant114NewOwnerSoftBlockBlockedDueToOverageType.BlobTotalAvgSizeInBytes,
                "blobTotalGetResponseObjectSizeInBytes" => UserEventPayloadVariant114NewOwnerSoftBlockBlockedDueToOverageType.BlobTotalGetResponseObjectSizeInBytes,
                "blobTotalSimpleRequests" => UserEventPayloadVariant114NewOwnerSoftBlockBlockedDueToOverageType.BlobTotalSimpleRequests,
                "connectDataTransfer" => UserEventPayloadVariant114NewOwnerSoftBlockBlockedDueToOverageType.ConnectDataTransfer,
                "dataCacheRead" => UserEventPayloadVariant114NewOwnerSoftBlockBlockedDueToOverageType.DataCacheRead,
                "dataCacheWrite" => UserEventPayloadVariant114NewOwnerSoftBlockBlockedDueToOverageType.DataCacheWrite,
                "edgeConfigRead" => UserEventPayloadVariant114NewOwnerSoftBlockBlockedDueToOverageType.EdgeConfigRead,
                "edgeConfigWrite" => UserEventPayloadVariant114NewOwnerSoftBlockBlockedDueToOverageType.EdgeConfigWrite,
                "edgeFunctionExecutionUnits" => UserEventPayloadVariant114NewOwnerSoftBlockBlockedDueToOverageType.EdgeFunctionExecutionUnits,
                "edgeMiddlewareInvocations" => UserEventPayloadVariant114NewOwnerSoftBlockBlockedDueToOverageType.EdgeMiddlewareInvocations,
                "edgeRequest" => UserEventPayloadVariant114NewOwnerSoftBlockBlockedDueToOverageType.EdgeRequest,
                "edgeRequestAdditionalCpuDuration" => UserEventPayloadVariant114NewOwnerSoftBlockBlockedDueToOverageType.EdgeRequestAdditionalCpuDuration,
                "elasticConcurrencyBuildSlots" => UserEventPayloadVariant114NewOwnerSoftBlockBlockedDueToOverageType.ElasticConcurrencyBuildSlots,
                "fastDataTransfer" => UserEventPayloadVariant114NewOwnerSoftBlockBlockedDueToOverageType.FastDataTransfer,
                "fastOriginTransfer" => UserEventPayloadVariant114NewOwnerSoftBlockBlockedDueToOverageType.FastOriginTransfer,
                "fluidCpuDuration" => UserEventPayloadVariant114NewOwnerSoftBlockBlockedDueToOverageType.FluidCpuDuration,
                "fluidDuration" => UserEventPayloadVariant114NewOwnerSoftBlockBlockedDueToOverageType.FluidDuration,
                "functionDuration" => UserEventPayloadVariant114NewOwnerSoftBlockBlockedDueToOverageType.FunctionDuration,
                "functionInvocation" => UserEventPayloadVariant114NewOwnerSoftBlockBlockedDueToOverageType.FunctionInvocation,
                "imageOptimizationCacheRead" => UserEventPayloadVariant114NewOwnerSoftBlockBlockedDueToOverageType.ImageOptimizationCacheRead,
                "imageOptimizationCacheWrite" => UserEventPayloadVariant114NewOwnerSoftBlockBlockedDueToOverageType.ImageOptimizationCacheWrite,
                "imageOptimizationTransformation" => UserEventPayloadVariant114NewOwnerSoftBlockBlockedDueToOverageType.ImageOptimizationTransformation,
                "logDrainsVolume" => UserEventPayloadVariant114NewOwnerSoftBlockBlockedDueToOverageType.LogDrainsVolume,
                "monitoringMetric" => UserEventPayloadVariant114NewOwnerSoftBlockBlockedDueToOverageType.MonitoringMetric,
                "observabilityEvent" => UserEventPayloadVariant114NewOwnerSoftBlockBlockedDueToOverageType.ObservabilityEvent,
                "onDemandConcurrencyMinutes" => UserEventPayloadVariant114NewOwnerSoftBlockBlockedDueToOverageType.OnDemandConcurrencyMinutes,
                "runtimeCacheRead" => UserEventPayloadVariant114NewOwnerSoftBlockBlockedDueToOverageType.RuntimeCacheRead,
                "runtimeCacheWrite" => UserEventPayloadVariant114NewOwnerSoftBlockBlockedDueToOverageType.RuntimeCacheWrite,
                "serverlessFunctionExecution" => UserEventPayloadVariant114NewOwnerSoftBlockBlockedDueToOverageType.ServerlessFunctionExecution,
                "sourceImages" => UserEventPayloadVariant114NewOwnerSoftBlockBlockedDueToOverageType.SourceImages,
                "wafOwaspExcessBytes" => UserEventPayloadVariant114NewOwnerSoftBlockBlockedDueToOverageType.WafOwaspExcessBytes,
                "wafOwaspRequests" => UserEventPayloadVariant114NewOwnerSoftBlockBlockedDueToOverageType.WafOwaspRequests,
                "wafRateLimitRequest" => UserEventPayloadVariant114NewOwnerSoftBlockBlockedDueToOverageType.WafRateLimitRequest,
                "webAnalyticsEvent" => UserEventPayloadVariant114NewOwnerSoftBlockBlockedDueToOverageType.WebAnalyticsEvent,
                _ => null,
            };
        }
    }
}