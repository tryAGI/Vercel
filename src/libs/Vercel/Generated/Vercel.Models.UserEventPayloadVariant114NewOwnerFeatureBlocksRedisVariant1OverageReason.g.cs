
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant114NewOwnerFeatureBlocksRedisVariant1OverageReason
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
    public static class UserEventPayloadVariant114NewOwnerFeatureBlocksRedisVariant1OverageReasonExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant114NewOwnerFeatureBlocksRedisVariant1OverageReason value)
        {
            return value switch
            {
                UserEventPayloadVariant114NewOwnerFeatureBlocksRedisVariant1OverageReason.AnalyticsUsage => "analyticsUsage",
                UserEventPayloadVariant114NewOwnerFeatureBlocksRedisVariant1OverageReason.Artifacts => "artifacts",
                UserEventPayloadVariant114NewOwnerFeatureBlocksRedisVariant1OverageReason.Bandwidth => "bandwidth",
                UserEventPayloadVariant114NewOwnerFeatureBlocksRedisVariant1OverageReason.BlobDataTransfer => "blobDataTransfer",
                UserEventPayloadVariant114NewOwnerFeatureBlocksRedisVariant1OverageReason.BlobTotalAdvancedRequests => "blobTotalAdvancedRequests",
                UserEventPayloadVariant114NewOwnerFeatureBlocksRedisVariant1OverageReason.BlobTotalAvgSizeInBytes => "blobTotalAvgSizeInBytes",
                UserEventPayloadVariant114NewOwnerFeatureBlocksRedisVariant1OverageReason.BlobTotalGetResponseObjectSizeInBytes => "blobTotalGetResponseObjectSizeInBytes",
                UserEventPayloadVariant114NewOwnerFeatureBlocksRedisVariant1OverageReason.BlobTotalSimpleRequests => "blobTotalSimpleRequests",
                UserEventPayloadVariant114NewOwnerFeatureBlocksRedisVariant1OverageReason.ConnectDataTransfer => "connectDataTransfer",
                UserEventPayloadVariant114NewOwnerFeatureBlocksRedisVariant1OverageReason.DataCacheRead => "dataCacheRead",
                UserEventPayloadVariant114NewOwnerFeatureBlocksRedisVariant1OverageReason.DataCacheWrite => "dataCacheWrite",
                UserEventPayloadVariant114NewOwnerFeatureBlocksRedisVariant1OverageReason.EdgeConfigRead => "edgeConfigRead",
                UserEventPayloadVariant114NewOwnerFeatureBlocksRedisVariant1OverageReason.EdgeConfigWrite => "edgeConfigWrite",
                UserEventPayloadVariant114NewOwnerFeatureBlocksRedisVariant1OverageReason.EdgeFunctionExecutionUnits => "edgeFunctionExecutionUnits",
                UserEventPayloadVariant114NewOwnerFeatureBlocksRedisVariant1OverageReason.EdgeMiddlewareInvocations => "edgeMiddlewareInvocations",
                UserEventPayloadVariant114NewOwnerFeatureBlocksRedisVariant1OverageReason.EdgeRequest => "edgeRequest",
                UserEventPayloadVariant114NewOwnerFeatureBlocksRedisVariant1OverageReason.EdgeRequestAdditionalCpuDuration => "edgeRequestAdditionalCpuDuration",
                UserEventPayloadVariant114NewOwnerFeatureBlocksRedisVariant1OverageReason.ElasticConcurrencyBuildSlots => "elasticConcurrencyBuildSlots",
                UserEventPayloadVariant114NewOwnerFeatureBlocksRedisVariant1OverageReason.FastDataTransfer => "fastDataTransfer",
                UserEventPayloadVariant114NewOwnerFeatureBlocksRedisVariant1OverageReason.FastOriginTransfer => "fastOriginTransfer",
                UserEventPayloadVariant114NewOwnerFeatureBlocksRedisVariant1OverageReason.FluidCpuDuration => "fluidCpuDuration",
                UserEventPayloadVariant114NewOwnerFeatureBlocksRedisVariant1OverageReason.FluidDuration => "fluidDuration",
                UserEventPayloadVariant114NewOwnerFeatureBlocksRedisVariant1OverageReason.FunctionDuration => "functionDuration",
                UserEventPayloadVariant114NewOwnerFeatureBlocksRedisVariant1OverageReason.FunctionInvocation => "functionInvocation",
                UserEventPayloadVariant114NewOwnerFeatureBlocksRedisVariant1OverageReason.ImageOptimizationCacheRead => "imageOptimizationCacheRead",
                UserEventPayloadVariant114NewOwnerFeatureBlocksRedisVariant1OverageReason.ImageOptimizationCacheWrite => "imageOptimizationCacheWrite",
                UserEventPayloadVariant114NewOwnerFeatureBlocksRedisVariant1OverageReason.ImageOptimizationTransformation => "imageOptimizationTransformation",
                UserEventPayloadVariant114NewOwnerFeatureBlocksRedisVariant1OverageReason.LogDrainsVolume => "logDrainsVolume",
                UserEventPayloadVariant114NewOwnerFeatureBlocksRedisVariant1OverageReason.MonitoringMetric => "monitoringMetric",
                UserEventPayloadVariant114NewOwnerFeatureBlocksRedisVariant1OverageReason.ObservabilityEvent => "observabilityEvent",
                UserEventPayloadVariant114NewOwnerFeatureBlocksRedisVariant1OverageReason.OnDemandConcurrencyMinutes => "onDemandConcurrencyMinutes",
                UserEventPayloadVariant114NewOwnerFeatureBlocksRedisVariant1OverageReason.RuntimeCacheRead => "runtimeCacheRead",
                UserEventPayloadVariant114NewOwnerFeatureBlocksRedisVariant1OverageReason.RuntimeCacheWrite => "runtimeCacheWrite",
                UserEventPayloadVariant114NewOwnerFeatureBlocksRedisVariant1OverageReason.ServerlessFunctionExecution => "serverlessFunctionExecution",
                UserEventPayloadVariant114NewOwnerFeatureBlocksRedisVariant1OverageReason.SourceImages => "sourceImages",
                UserEventPayloadVariant114NewOwnerFeatureBlocksRedisVariant1OverageReason.WafOwaspExcessBytes => "wafOwaspExcessBytes",
                UserEventPayloadVariant114NewOwnerFeatureBlocksRedisVariant1OverageReason.WafOwaspRequests => "wafOwaspRequests",
                UserEventPayloadVariant114NewOwnerFeatureBlocksRedisVariant1OverageReason.WafRateLimitRequest => "wafRateLimitRequest",
                UserEventPayloadVariant114NewOwnerFeatureBlocksRedisVariant1OverageReason.WebAnalyticsEvent => "webAnalyticsEvent",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant114NewOwnerFeatureBlocksRedisVariant1OverageReason? ToEnum(string value)
        {
            return value switch
            {
                "analyticsUsage" => UserEventPayloadVariant114NewOwnerFeatureBlocksRedisVariant1OverageReason.AnalyticsUsage,
                "artifacts" => UserEventPayloadVariant114NewOwnerFeatureBlocksRedisVariant1OverageReason.Artifacts,
                "bandwidth" => UserEventPayloadVariant114NewOwnerFeatureBlocksRedisVariant1OverageReason.Bandwidth,
                "blobDataTransfer" => UserEventPayloadVariant114NewOwnerFeatureBlocksRedisVariant1OverageReason.BlobDataTransfer,
                "blobTotalAdvancedRequests" => UserEventPayloadVariant114NewOwnerFeatureBlocksRedisVariant1OverageReason.BlobTotalAdvancedRequests,
                "blobTotalAvgSizeInBytes" => UserEventPayloadVariant114NewOwnerFeatureBlocksRedisVariant1OverageReason.BlobTotalAvgSizeInBytes,
                "blobTotalGetResponseObjectSizeInBytes" => UserEventPayloadVariant114NewOwnerFeatureBlocksRedisVariant1OverageReason.BlobTotalGetResponseObjectSizeInBytes,
                "blobTotalSimpleRequests" => UserEventPayloadVariant114NewOwnerFeatureBlocksRedisVariant1OverageReason.BlobTotalSimpleRequests,
                "connectDataTransfer" => UserEventPayloadVariant114NewOwnerFeatureBlocksRedisVariant1OverageReason.ConnectDataTransfer,
                "dataCacheRead" => UserEventPayloadVariant114NewOwnerFeatureBlocksRedisVariant1OverageReason.DataCacheRead,
                "dataCacheWrite" => UserEventPayloadVariant114NewOwnerFeatureBlocksRedisVariant1OverageReason.DataCacheWrite,
                "edgeConfigRead" => UserEventPayloadVariant114NewOwnerFeatureBlocksRedisVariant1OverageReason.EdgeConfigRead,
                "edgeConfigWrite" => UserEventPayloadVariant114NewOwnerFeatureBlocksRedisVariant1OverageReason.EdgeConfigWrite,
                "edgeFunctionExecutionUnits" => UserEventPayloadVariant114NewOwnerFeatureBlocksRedisVariant1OverageReason.EdgeFunctionExecutionUnits,
                "edgeMiddlewareInvocations" => UserEventPayloadVariant114NewOwnerFeatureBlocksRedisVariant1OverageReason.EdgeMiddlewareInvocations,
                "edgeRequest" => UserEventPayloadVariant114NewOwnerFeatureBlocksRedisVariant1OverageReason.EdgeRequest,
                "edgeRequestAdditionalCpuDuration" => UserEventPayloadVariant114NewOwnerFeatureBlocksRedisVariant1OverageReason.EdgeRequestAdditionalCpuDuration,
                "elasticConcurrencyBuildSlots" => UserEventPayloadVariant114NewOwnerFeatureBlocksRedisVariant1OverageReason.ElasticConcurrencyBuildSlots,
                "fastDataTransfer" => UserEventPayloadVariant114NewOwnerFeatureBlocksRedisVariant1OverageReason.FastDataTransfer,
                "fastOriginTransfer" => UserEventPayloadVariant114NewOwnerFeatureBlocksRedisVariant1OverageReason.FastOriginTransfer,
                "fluidCpuDuration" => UserEventPayloadVariant114NewOwnerFeatureBlocksRedisVariant1OverageReason.FluidCpuDuration,
                "fluidDuration" => UserEventPayloadVariant114NewOwnerFeatureBlocksRedisVariant1OverageReason.FluidDuration,
                "functionDuration" => UserEventPayloadVariant114NewOwnerFeatureBlocksRedisVariant1OverageReason.FunctionDuration,
                "functionInvocation" => UserEventPayloadVariant114NewOwnerFeatureBlocksRedisVariant1OverageReason.FunctionInvocation,
                "imageOptimizationCacheRead" => UserEventPayloadVariant114NewOwnerFeatureBlocksRedisVariant1OverageReason.ImageOptimizationCacheRead,
                "imageOptimizationCacheWrite" => UserEventPayloadVariant114NewOwnerFeatureBlocksRedisVariant1OverageReason.ImageOptimizationCacheWrite,
                "imageOptimizationTransformation" => UserEventPayloadVariant114NewOwnerFeatureBlocksRedisVariant1OverageReason.ImageOptimizationTransformation,
                "logDrainsVolume" => UserEventPayloadVariant114NewOwnerFeatureBlocksRedisVariant1OverageReason.LogDrainsVolume,
                "monitoringMetric" => UserEventPayloadVariant114NewOwnerFeatureBlocksRedisVariant1OverageReason.MonitoringMetric,
                "observabilityEvent" => UserEventPayloadVariant114NewOwnerFeatureBlocksRedisVariant1OverageReason.ObservabilityEvent,
                "onDemandConcurrencyMinutes" => UserEventPayloadVariant114NewOwnerFeatureBlocksRedisVariant1OverageReason.OnDemandConcurrencyMinutes,
                "runtimeCacheRead" => UserEventPayloadVariant114NewOwnerFeatureBlocksRedisVariant1OverageReason.RuntimeCacheRead,
                "runtimeCacheWrite" => UserEventPayloadVariant114NewOwnerFeatureBlocksRedisVariant1OverageReason.RuntimeCacheWrite,
                "serverlessFunctionExecution" => UserEventPayloadVariant114NewOwnerFeatureBlocksRedisVariant1OverageReason.ServerlessFunctionExecution,
                "sourceImages" => UserEventPayloadVariant114NewOwnerFeatureBlocksRedisVariant1OverageReason.SourceImages,
                "wafOwaspExcessBytes" => UserEventPayloadVariant114NewOwnerFeatureBlocksRedisVariant1OverageReason.WafOwaspExcessBytes,
                "wafOwaspRequests" => UserEventPayloadVariant114NewOwnerFeatureBlocksRedisVariant1OverageReason.WafOwaspRequests,
                "wafRateLimitRequest" => UserEventPayloadVariant114NewOwnerFeatureBlocksRedisVariant1OverageReason.WafRateLimitRequest,
                "webAnalyticsEvent" => UserEventPayloadVariant114NewOwnerFeatureBlocksRedisVariant1OverageReason.WebAnalyticsEvent,
                _ => null,
            };
        }
    }
}