
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant114NewOwnerFeatureBlocksBlobVariant1OverageReason
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
    public static class UserEventPayloadVariant114NewOwnerFeatureBlocksBlobVariant1OverageReasonExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant114NewOwnerFeatureBlocksBlobVariant1OverageReason value)
        {
            return value switch
            {
                UserEventPayloadVariant114NewOwnerFeatureBlocksBlobVariant1OverageReason.AnalyticsUsage => "analyticsUsage",
                UserEventPayloadVariant114NewOwnerFeatureBlocksBlobVariant1OverageReason.Artifacts => "artifacts",
                UserEventPayloadVariant114NewOwnerFeatureBlocksBlobVariant1OverageReason.Bandwidth => "bandwidth",
                UserEventPayloadVariant114NewOwnerFeatureBlocksBlobVariant1OverageReason.BlobDataTransfer => "blobDataTransfer",
                UserEventPayloadVariant114NewOwnerFeatureBlocksBlobVariant1OverageReason.BlobTotalAdvancedRequests => "blobTotalAdvancedRequests",
                UserEventPayloadVariant114NewOwnerFeatureBlocksBlobVariant1OverageReason.BlobTotalAvgSizeInBytes => "blobTotalAvgSizeInBytes",
                UserEventPayloadVariant114NewOwnerFeatureBlocksBlobVariant1OverageReason.BlobTotalGetResponseObjectSizeInBytes => "blobTotalGetResponseObjectSizeInBytes",
                UserEventPayloadVariant114NewOwnerFeatureBlocksBlobVariant1OverageReason.BlobTotalSimpleRequests => "blobTotalSimpleRequests",
                UserEventPayloadVariant114NewOwnerFeatureBlocksBlobVariant1OverageReason.ConnectDataTransfer => "connectDataTransfer",
                UserEventPayloadVariant114NewOwnerFeatureBlocksBlobVariant1OverageReason.DataCacheRead => "dataCacheRead",
                UserEventPayloadVariant114NewOwnerFeatureBlocksBlobVariant1OverageReason.DataCacheWrite => "dataCacheWrite",
                UserEventPayloadVariant114NewOwnerFeatureBlocksBlobVariant1OverageReason.EdgeConfigRead => "edgeConfigRead",
                UserEventPayloadVariant114NewOwnerFeatureBlocksBlobVariant1OverageReason.EdgeConfigWrite => "edgeConfigWrite",
                UserEventPayloadVariant114NewOwnerFeatureBlocksBlobVariant1OverageReason.EdgeFunctionExecutionUnits => "edgeFunctionExecutionUnits",
                UserEventPayloadVariant114NewOwnerFeatureBlocksBlobVariant1OverageReason.EdgeMiddlewareInvocations => "edgeMiddlewareInvocations",
                UserEventPayloadVariant114NewOwnerFeatureBlocksBlobVariant1OverageReason.EdgeRequest => "edgeRequest",
                UserEventPayloadVariant114NewOwnerFeatureBlocksBlobVariant1OverageReason.EdgeRequestAdditionalCpuDuration => "edgeRequestAdditionalCpuDuration",
                UserEventPayloadVariant114NewOwnerFeatureBlocksBlobVariant1OverageReason.ElasticConcurrencyBuildSlots => "elasticConcurrencyBuildSlots",
                UserEventPayloadVariant114NewOwnerFeatureBlocksBlobVariant1OverageReason.FastDataTransfer => "fastDataTransfer",
                UserEventPayloadVariant114NewOwnerFeatureBlocksBlobVariant1OverageReason.FastOriginTransfer => "fastOriginTransfer",
                UserEventPayloadVariant114NewOwnerFeatureBlocksBlobVariant1OverageReason.FluidCpuDuration => "fluidCpuDuration",
                UserEventPayloadVariant114NewOwnerFeatureBlocksBlobVariant1OverageReason.FluidDuration => "fluidDuration",
                UserEventPayloadVariant114NewOwnerFeatureBlocksBlobVariant1OverageReason.FunctionDuration => "functionDuration",
                UserEventPayloadVariant114NewOwnerFeatureBlocksBlobVariant1OverageReason.FunctionInvocation => "functionInvocation",
                UserEventPayloadVariant114NewOwnerFeatureBlocksBlobVariant1OverageReason.ImageOptimizationCacheRead => "imageOptimizationCacheRead",
                UserEventPayloadVariant114NewOwnerFeatureBlocksBlobVariant1OverageReason.ImageOptimizationCacheWrite => "imageOptimizationCacheWrite",
                UserEventPayloadVariant114NewOwnerFeatureBlocksBlobVariant1OverageReason.ImageOptimizationTransformation => "imageOptimizationTransformation",
                UserEventPayloadVariant114NewOwnerFeatureBlocksBlobVariant1OverageReason.LogDrainsVolume => "logDrainsVolume",
                UserEventPayloadVariant114NewOwnerFeatureBlocksBlobVariant1OverageReason.MonitoringMetric => "monitoringMetric",
                UserEventPayloadVariant114NewOwnerFeatureBlocksBlobVariant1OverageReason.ObservabilityEvent => "observabilityEvent",
                UserEventPayloadVariant114NewOwnerFeatureBlocksBlobVariant1OverageReason.OnDemandConcurrencyMinutes => "onDemandConcurrencyMinutes",
                UserEventPayloadVariant114NewOwnerFeatureBlocksBlobVariant1OverageReason.RuntimeCacheRead => "runtimeCacheRead",
                UserEventPayloadVariant114NewOwnerFeatureBlocksBlobVariant1OverageReason.RuntimeCacheWrite => "runtimeCacheWrite",
                UserEventPayloadVariant114NewOwnerFeatureBlocksBlobVariant1OverageReason.ServerlessFunctionExecution => "serverlessFunctionExecution",
                UserEventPayloadVariant114NewOwnerFeatureBlocksBlobVariant1OverageReason.SourceImages => "sourceImages",
                UserEventPayloadVariant114NewOwnerFeatureBlocksBlobVariant1OverageReason.WafOwaspExcessBytes => "wafOwaspExcessBytes",
                UserEventPayloadVariant114NewOwnerFeatureBlocksBlobVariant1OverageReason.WafOwaspRequests => "wafOwaspRequests",
                UserEventPayloadVariant114NewOwnerFeatureBlocksBlobVariant1OverageReason.WafRateLimitRequest => "wafRateLimitRequest",
                UserEventPayloadVariant114NewOwnerFeatureBlocksBlobVariant1OverageReason.WebAnalyticsEvent => "webAnalyticsEvent",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant114NewOwnerFeatureBlocksBlobVariant1OverageReason? ToEnum(string value)
        {
            return value switch
            {
                "analyticsUsage" => UserEventPayloadVariant114NewOwnerFeatureBlocksBlobVariant1OverageReason.AnalyticsUsage,
                "artifacts" => UserEventPayloadVariant114NewOwnerFeatureBlocksBlobVariant1OverageReason.Artifacts,
                "bandwidth" => UserEventPayloadVariant114NewOwnerFeatureBlocksBlobVariant1OverageReason.Bandwidth,
                "blobDataTransfer" => UserEventPayloadVariant114NewOwnerFeatureBlocksBlobVariant1OverageReason.BlobDataTransfer,
                "blobTotalAdvancedRequests" => UserEventPayloadVariant114NewOwnerFeatureBlocksBlobVariant1OverageReason.BlobTotalAdvancedRequests,
                "blobTotalAvgSizeInBytes" => UserEventPayloadVariant114NewOwnerFeatureBlocksBlobVariant1OverageReason.BlobTotalAvgSizeInBytes,
                "blobTotalGetResponseObjectSizeInBytes" => UserEventPayloadVariant114NewOwnerFeatureBlocksBlobVariant1OverageReason.BlobTotalGetResponseObjectSizeInBytes,
                "blobTotalSimpleRequests" => UserEventPayloadVariant114NewOwnerFeatureBlocksBlobVariant1OverageReason.BlobTotalSimpleRequests,
                "connectDataTransfer" => UserEventPayloadVariant114NewOwnerFeatureBlocksBlobVariant1OverageReason.ConnectDataTransfer,
                "dataCacheRead" => UserEventPayloadVariant114NewOwnerFeatureBlocksBlobVariant1OverageReason.DataCacheRead,
                "dataCacheWrite" => UserEventPayloadVariant114NewOwnerFeatureBlocksBlobVariant1OverageReason.DataCacheWrite,
                "edgeConfigRead" => UserEventPayloadVariant114NewOwnerFeatureBlocksBlobVariant1OverageReason.EdgeConfigRead,
                "edgeConfigWrite" => UserEventPayloadVariant114NewOwnerFeatureBlocksBlobVariant1OverageReason.EdgeConfigWrite,
                "edgeFunctionExecutionUnits" => UserEventPayloadVariant114NewOwnerFeatureBlocksBlobVariant1OverageReason.EdgeFunctionExecutionUnits,
                "edgeMiddlewareInvocations" => UserEventPayloadVariant114NewOwnerFeatureBlocksBlobVariant1OverageReason.EdgeMiddlewareInvocations,
                "edgeRequest" => UserEventPayloadVariant114NewOwnerFeatureBlocksBlobVariant1OverageReason.EdgeRequest,
                "edgeRequestAdditionalCpuDuration" => UserEventPayloadVariant114NewOwnerFeatureBlocksBlobVariant1OverageReason.EdgeRequestAdditionalCpuDuration,
                "elasticConcurrencyBuildSlots" => UserEventPayloadVariant114NewOwnerFeatureBlocksBlobVariant1OverageReason.ElasticConcurrencyBuildSlots,
                "fastDataTransfer" => UserEventPayloadVariant114NewOwnerFeatureBlocksBlobVariant1OverageReason.FastDataTransfer,
                "fastOriginTransfer" => UserEventPayloadVariant114NewOwnerFeatureBlocksBlobVariant1OverageReason.FastOriginTransfer,
                "fluidCpuDuration" => UserEventPayloadVariant114NewOwnerFeatureBlocksBlobVariant1OverageReason.FluidCpuDuration,
                "fluidDuration" => UserEventPayloadVariant114NewOwnerFeatureBlocksBlobVariant1OverageReason.FluidDuration,
                "functionDuration" => UserEventPayloadVariant114NewOwnerFeatureBlocksBlobVariant1OverageReason.FunctionDuration,
                "functionInvocation" => UserEventPayloadVariant114NewOwnerFeatureBlocksBlobVariant1OverageReason.FunctionInvocation,
                "imageOptimizationCacheRead" => UserEventPayloadVariant114NewOwnerFeatureBlocksBlobVariant1OverageReason.ImageOptimizationCacheRead,
                "imageOptimizationCacheWrite" => UserEventPayloadVariant114NewOwnerFeatureBlocksBlobVariant1OverageReason.ImageOptimizationCacheWrite,
                "imageOptimizationTransformation" => UserEventPayloadVariant114NewOwnerFeatureBlocksBlobVariant1OverageReason.ImageOptimizationTransformation,
                "logDrainsVolume" => UserEventPayloadVariant114NewOwnerFeatureBlocksBlobVariant1OverageReason.LogDrainsVolume,
                "monitoringMetric" => UserEventPayloadVariant114NewOwnerFeatureBlocksBlobVariant1OverageReason.MonitoringMetric,
                "observabilityEvent" => UserEventPayloadVariant114NewOwnerFeatureBlocksBlobVariant1OverageReason.ObservabilityEvent,
                "onDemandConcurrencyMinutes" => UserEventPayloadVariant114NewOwnerFeatureBlocksBlobVariant1OverageReason.OnDemandConcurrencyMinutes,
                "runtimeCacheRead" => UserEventPayloadVariant114NewOwnerFeatureBlocksBlobVariant1OverageReason.RuntimeCacheRead,
                "runtimeCacheWrite" => UserEventPayloadVariant114NewOwnerFeatureBlocksBlobVariant1OverageReason.RuntimeCacheWrite,
                "serverlessFunctionExecution" => UserEventPayloadVariant114NewOwnerFeatureBlocksBlobVariant1OverageReason.ServerlessFunctionExecution,
                "sourceImages" => UserEventPayloadVariant114NewOwnerFeatureBlocksBlobVariant1OverageReason.SourceImages,
                "wafOwaspExcessBytes" => UserEventPayloadVariant114NewOwnerFeatureBlocksBlobVariant1OverageReason.WafOwaspExcessBytes,
                "wafOwaspRequests" => UserEventPayloadVariant114NewOwnerFeatureBlocksBlobVariant1OverageReason.WafOwaspRequests,
                "wafRateLimitRequest" => UserEventPayloadVariant114NewOwnerFeatureBlocksBlobVariant1OverageReason.WafRateLimitRequest,
                "webAnalyticsEvent" => UserEventPayloadVariant114NewOwnerFeatureBlocksBlobVariant1OverageReason.WebAnalyticsEvent,
                _ => null,
            };
        }
    }
}