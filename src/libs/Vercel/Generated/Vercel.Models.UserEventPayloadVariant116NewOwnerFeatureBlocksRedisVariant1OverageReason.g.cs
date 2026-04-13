
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant116NewOwnerFeatureBlocksRedisVariant1OverageReason
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
    public static class UserEventPayloadVariant116NewOwnerFeatureBlocksRedisVariant1OverageReasonExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant116NewOwnerFeatureBlocksRedisVariant1OverageReason value)
        {
            return value switch
            {
                UserEventPayloadVariant116NewOwnerFeatureBlocksRedisVariant1OverageReason.AnalyticsUsage => "analyticsUsage",
                UserEventPayloadVariant116NewOwnerFeatureBlocksRedisVariant1OverageReason.Artifacts => "artifacts",
                UserEventPayloadVariant116NewOwnerFeatureBlocksRedisVariant1OverageReason.Bandwidth => "bandwidth",
                UserEventPayloadVariant116NewOwnerFeatureBlocksRedisVariant1OverageReason.BlobDataTransfer => "blobDataTransfer",
                UserEventPayloadVariant116NewOwnerFeatureBlocksRedisVariant1OverageReason.BlobTotalAdvancedRequests => "blobTotalAdvancedRequests",
                UserEventPayloadVariant116NewOwnerFeatureBlocksRedisVariant1OverageReason.BlobTotalAvgSizeInBytes => "blobTotalAvgSizeInBytes",
                UserEventPayloadVariant116NewOwnerFeatureBlocksRedisVariant1OverageReason.BlobTotalGetResponseObjectSizeInBytes => "blobTotalGetResponseObjectSizeInBytes",
                UserEventPayloadVariant116NewOwnerFeatureBlocksRedisVariant1OverageReason.BlobTotalSimpleRequests => "blobTotalSimpleRequests",
                UserEventPayloadVariant116NewOwnerFeatureBlocksRedisVariant1OverageReason.ConnectDataTransfer => "connectDataTransfer",
                UserEventPayloadVariant116NewOwnerFeatureBlocksRedisVariant1OverageReason.DataCacheRead => "dataCacheRead",
                UserEventPayloadVariant116NewOwnerFeatureBlocksRedisVariant1OverageReason.DataCacheWrite => "dataCacheWrite",
                UserEventPayloadVariant116NewOwnerFeatureBlocksRedisVariant1OverageReason.EdgeConfigRead => "edgeConfigRead",
                UserEventPayloadVariant116NewOwnerFeatureBlocksRedisVariant1OverageReason.EdgeConfigWrite => "edgeConfigWrite",
                UserEventPayloadVariant116NewOwnerFeatureBlocksRedisVariant1OverageReason.EdgeFunctionExecutionUnits => "edgeFunctionExecutionUnits",
                UserEventPayloadVariant116NewOwnerFeatureBlocksRedisVariant1OverageReason.EdgeMiddlewareInvocations => "edgeMiddlewareInvocations",
                UserEventPayloadVariant116NewOwnerFeatureBlocksRedisVariant1OverageReason.EdgeRequest => "edgeRequest",
                UserEventPayloadVariant116NewOwnerFeatureBlocksRedisVariant1OverageReason.EdgeRequestAdditionalCpuDuration => "edgeRequestAdditionalCpuDuration",
                UserEventPayloadVariant116NewOwnerFeatureBlocksRedisVariant1OverageReason.ElasticConcurrencyBuildSlots => "elasticConcurrencyBuildSlots",
                UserEventPayloadVariant116NewOwnerFeatureBlocksRedisVariant1OverageReason.FastDataTransfer => "fastDataTransfer",
                UserEventPayloadVariant116NewOwnerFeatureBlocksRedisVariant1OverageReason.FastOriginTransfer => "fastOriginTransfer",
                UserEventPayloadVariant116NewOwnerFeatureBlocksRedisVariant1OverageReason.FluidCpuDuration => "fluidCpuDuration",
                UserEventPayloadVariant116NewOwnerFeatureBlocksRedisVariant1OverageReason.FluidDuration => "fluidDuration",
                UserEventPayloadVariant116NewOwnerFeatureBlocksRedisVariant1OverageReason.FunctionDuration => "functionDuration",
                UserEventPayloadVariant116NewOwnerFeatureBlocksRedisVariant1OverageReason.FunctionInvocation => "functionInvocation",
                UserEventPayloadVariant116NewOwnerFeatureBlocksRedisVariant1OverageReason.ImageOptimizationCacheRead => "imageOptimizationCacheRead",
                UserEventPayloadVariant116NewOwnerFeatureBlocksRedisVariant1OverageReason.ImageOptimizationCacheWrite => "imageOptimizationCacheWrite",
                UserEventPayloadVariant116NewOwnerFeatureBlocksRedisVariant1OverageReason.ImageOptimizationTransformation => "imageOptimizationTransformation",
                UserEventPayloadVariant116NewOwnerFeatureBlocksRedisVariant1OverageReason.LogDrainsVolume => "logDrainsVolume",
                UserEventPayloadVariant116NewOwnerFeatureBlocksRedisVariant1OverageReason.MonitoringMetric => "monitoringMetric",
                UserEventPayloadVariant116NewOwnerFeatureBlocksRedisVariant1OverageReason.ObservabilityEvent => "observabilityEvent",
                UserEventPayloadVariant116NewOwnerFeatureBlocksRedisVariant1OverageReason.OnDemandConcurrencyMinutes => "onDemandConcurrencyMinutes",
                UserEventPayloadVariant116NewOwnerFeatureBlocksRedisVariant1OverageReason.RuntimeCacheRead => "runtimeCacheRead",
                UserEventPayloadVariant116NewOwnerFeatureBlocksRedisVariant1OverageReason.RuntimeCacheWrite => "runtimeCacheWrite",
                UserEventPayloadVariant116NewOwnerFeatureBlocksRedisVariant1OverageReason.ServerlessFunctionExecution => "serverlessFunctionExecution",
                UserEventPayloadVariant116NewOwnerFeatureBlocksRedisVariant1OverageReason.SourceImages => "sourceImages",
                UserEventPayloadVariant116NewOwnerFeatureBlocksRedisVariant1OverageReason.WafOwaspExcessBytes => "wafOwaspExcessBytes",
                UserEventPayloadVariant116NewOwnerFeatureBlocksRedisVariant1OverageReason.WafOwaspRequests => "wafOwaspRequests",
                UserEventPayloadVariant116NewOwnerFeatureBlocksRedisVariant1OverageReason.WafRateLimitRequest => "wafRateLimitRequest",
                UserEventPayloadVariant116NewOwnerFeatureBlocksRedisVariant1OverageReason.WebAnalyticsEvent => "webAnalyticsEvent",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant116NewOwnerFeatureBlocksRedisVariant1OverageReason? ToEnum(string value)
        {
            return value switch
            {
                "analyticsUsage" => UserEventPayloadVariant116NewOwnerFeatureBlocksRedisVariant1OverageReason.AnalyticsUsage,
                "artifacts" => UserEventPayloadVariant116NewOwnerFeatureBlocksRedisVariant1OverageReason.Artifacts,
                "bandwidth" => UserEventPayloadVariant116NewOwnerFeatureBlocksRedisVariant1OverageReason.Bandwidth,
                "blobDataTransfer" => UserEventPayloadVariant116NewOwnerFeatureBlocksRedisVariant1OverageReason.BlobDataTransfer,
                "blobTotalAdvancedRequests" => UserEventPayloadVariant116NewOwnerFeatureBlocksRedisVariant1OverageReason.BlobTotalAdvancedRequests,
                "blobTotalAvgSizeInBytes" => UserEventPayloadVariant116NewOwnerFeatureBlocksRedisVariant1OverageReason.BlobTotalAvgSizeInBytes,
                "blobTotalGetResponseObjectSizeInBytes" => UserEventPayloadVariant116NewOwnerFeatureBlocksRedisVariant1OverageReason.BlobTotalGetResponseObjectSizeInBytes,
                "blobTotalSimpleRequests" => UserEventPayloadVariant116NewOwnerFeatureBlocksRedisVariant1OverageReason.BlobTotalSimpleRequests,
                "connectDataTransfer" => UserEventPayloadVariant116NewOwnerFeatureBlocksRedisVariant1OverageReason.ConnectDataTransfer,
                "dataCacheRead" => UserEventPayloadVariant116NewOwnerFeatureBlocksRedisVariant1OverageReason.DataCacheRead,
                "dataCacheWrite" => UserEventPayloadVariant116NewOwnerFeatureBlocksRedisVariant1OverageReason.DataCacheWrite,
                "edgeConfigRead" => UserEventPayloadVariant116NewOwnerFeatureBlocksRedisVariant1OverageReason.EdgeConfigRead,
                "edgeConfigWrite" => UserEventPayloadVariant116NewOwnerFeatureBlocksRedisVariant1OverageReason.EdgeConfigWrite,
                "edgeFunctionExecutionUnits" => UserEventPayloadVariant116NewOwnerFeatureBlocksRedisVariant1OverageReason.EdgeFunctionExecutionUnits,
                "edgeMiddlewareInvocations" => UserEventPayloadVariant116NewOwnerFeatureBlocksRedisVariant1OverageReason.EdgeMiddlewareInvocations,
                "edgeRequest" => UserEventPayloadVariant116NewOwnerFeatureBlocksRedisVariant1OverageReason.EdgeRequest,
                "edgeRequestAdditionalCpuDuration" => UserEventPayloadVariant116NewOwnerFeatureBlocksRedisVariant1OverageReason.EdgeRequestAdditionalCpuDuration,
                "elasticConcurrencyBuildSlots" => UserEventPayloadVariant116NewOwnerFeatureBlocksRedisVariant1OverageReason.ElasticConcurrencyBuildSlots,
                "fastDataTransfer" => UserEventPayloadVariant116NewOwnerFeatureBlocksRedisVariant1OverageReason.FastDataTransfer,
                "fastOriginTransfer" => UserEventPayloadVariant116NewOwnerFeatureBlocksRedisVariant1OverageReason.FastOriginTransfer,
                "fluidCpuDuration" => UserEventPayloadVariant116NewOwnerFeatureBlocksRedisVariant1OverageReason.FluidCpuDuration,
                "fluidDuration" => UserEventPayloadVariant116NewOwnerFeatureBlocksRedisVariant1OverageReason.FluidDuration,
                "functionDuration" => UserEventPayloadVariant116NewOwnerFeatureBlocksRedisVariant1OverageReason.FunctionDuration,
                "functionInvocation" => UserEventPayloadVariant116NewOwnerFeatureBlocksRedisVariant1OverageReason.FunctionInvocation,
                "imageOptimizationCacheRead" => UserEventPayloadVariant116NewOwnerFeatureBlocksRedisVariant1OverageReason.ImageOptimizationCacheRead,
                "imageOptimizationCacheWrite" => UserEventPayloadVariant116NewOwnerFeatureBlocksRedisVariant1OverageReason.ImageOptimizationCacheWrite,
                "imageOptimizationTransformation" => UserEventPayloadVariant116NewOwnerFeatureBlocksRedisVariant1OverageReason.ImageOptimizationTransformation,
                "logDrainsVolume" => UserEventPayloadVariant116NewOwnerFeatureBlocksRedisVariant1OverageReason.LogDrainsVolume,
                "monitoringMetric" => UserEventPayloadVariant116NewOwnerFeatureBlocksRedisVariant1OverageReason.MonitoringMetric,
                "observabilityEvent" => UserEventPayloadVariant116NewOwnerFeatureBlocksRedisVariant1OverageReason.ObservabilityEvent,
                "onDemandConcurrencyMinutes" => UserEventPayloadVariant116NewOwnerFeatureBlocksRedisVariant1OverageReason.OnDemandConcurrencyMinutes,
                "runtimeCacheRead" => UserEventPayloadVariant116NewOwnerFeatureBlocksRedisVariant1OverageReason.RuntimeCacheRead,
                "runtimeCacheWrite" => UserEventPayloadVariant116NewOwnerFeatureBlocksRedisVariant1OverageReason.RuntimeCacheWrite,
                "serverlessFunctionExecution" => UserEventPayloadVariant116NewOwnerFeatureBlocksRedisVariant1OverageReason.ServerlessFunctionExecution,
                "sourceImages" => UserEventPayloadVariant116NewOwnerFeatureBlocksRedisVariant1OverageReason.SourceImages,
                "wafOwaspExcessBytes" => UserEventPayloadVariant116NewOwnerFeatureBlocksRedisVariant1OverageReason.WafOwaspExcessBytes,
                "wafOwaspRequests" => UserEventPayloadVariant116NewOwnerFeatureBlocksRedisVariant1OverageReason.WafOwaspRequests,
                "wafRateLimitRequest" => UserEventPayloadVariant116NewOwnerFeatureBlocksRedisVariant1OverageReason.WafRateLimitRequest,
                "webAnalyticsEvent" => UserEventPayloadVariant116NewOwnerFeatureBlocksRedisVariant1OverageReason.WebAnalyticsEvent,
                _ => null,
            };
        }
    }
}