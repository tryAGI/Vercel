#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct AiGatewayEvaluationFallbackCondition : global::System.IEquatable<AiGatewayEvaluationFallbackCondition>
    {
        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vercel.AiGatewayEvaluationFallbackConditionVariant1? AiGatewayEvaluationFallbackConditionVariant1 { get; init; }
#else
        public global::Vercel.AiGatewayEvaluationFallbackConditionVariant1? AiGatewayEvaluationFallbackConditionVariant1 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AiGatewayEvaluationFallbackConditionVariant1))]
#endif
        public bool IsAiGatewayEvaluationFallbackConditionVariant1 => AiGatewayEvaluationFallbackConditionVariant1 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickAiGatewayEvaluationFallbackConditionVariant1(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Vercel.AiGatewayEvaluationFallbackConditionVariant1? value)
        {
            value = AiGatewayEvaluationFallbackConditionVariant1;
            return IsAiGatewayEvaluationFallbackConditionVariant1;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Vercel.AiGatewayEvaluationFallbackConditionVariant1 PickAiGatewayEvaluationFallbackConditionVariant1() => IsAiGatewayEvaluationFallbackConditionVariant1
            ? AiGatewayEvaluationFallbackConditionVariant1!
            : throw new global::System.InvalidOperationException($"Expected union variant 'AiGatewayEvaluationFallbackConditionVariant1' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vercel.AiGatewayEvaluationFallbackConditionVariant2? AiGatewayEvaluationFallbackConditionVariant2 { get; init; }
#else
        public global::Vercel.AiGatewayEvaluationFallbackConditionVariant2? AiGatewayEvaluationFallbackConditionVariant2 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AiGatewayEvaluationFallbackConditionVariant2))]
#endif
        public bool IsAiGatewayEvaluationFallbackConditionVariant2 => AiGatewayEvaluationFallbackConditionVariant2 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickAiGatewayEvaluationFallbackConditionVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Vercel.AiGatewayEvaluationFallbackConditionVariant2? value)
        {
            value = AiGatewayEvaluationFallbackConditionVariant2;
            return IsAiGatewayEvaluationFallbackConditionVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Vercel.AiGatewayEvaluationFallbackConditionVariant2 PickAiGatewayEvaluationFallbackConditionVariant2() => IsAiGatewayEvaluationFallbackConditionVariant2
            ? AiGatewayEvaluationFallbackConditionVariant2!
            : throw new global::System.InvalidOperationException($"Expected union variant 'AiGatewayEvaluationFallbackConditionVariant2' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vercel.AiGatewayEvaluationFallbackConditionVariant3? AiGatewayEvaluationFallbackConditionVariant3 { get; init; }
#else
        public global::Vercel.AiGatewayEvaluationFallbackConditionVariant3? AiGatewayEvaluationFallbackConditionVariant3 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AiGatewayEvaluationFallbackConditionVariant3))]
#endif
        public bool IsAiGatewayEvaluationFallbackConditionVariant3 => AiGatewayEvaluationFallbackConditionVariant3 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickAiGatewayEvaluationFallbackConditionVariant3(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Vercel.AiGatewayEvaluationFallbackConditionVariant3? value)
        {
            value = AiGatewayEvaluationFallbackConditionVariant3;
            return IsAiGatewayEvaluationFallbackConditionVariant3;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Vercel.AiGatewayEvaluationFallbackConditionVariant3 PickAiGatewayEvaluationFallbackConditionVariant3() => IsAiGatewayEvaluationFallbackConditionVariant3
            ? AiGatewayEvaluationFallbackConditionVariant3!
            : throw new global::System.InvalidOperationException($"Expected union variant 'AiGatewayEvaluationFallbackConditionVariant3' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vercel.AiGatewayEvaluationFallbackConditionVariant4? AiGatewayEvaluationFallbackConditionVariant4 { get; init; }
#else
        public global::Vercel.AiGatewayEvaluationFallbackConditionVariant4? AiGatewayEvaluationFallbackConditionVariant4 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AiGatewayEvaluationFallbackConditionVariant4))]
#endif
        public bool IsAiGatewayEvaluationFallbackConditionVariant4 => AiGatewayEvaluationFallbackConditionVariant4 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickAiGatewayEvaluationFallbackConditionVariant4(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Vercel.AiGatewayEvaluationFallbackConditionVariant4? value)
        {
            value = AiGatewayEvaluationFallbackConditionVariant4;
            return IsAiGatewayEvaluationFallbackConditionVariant4;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Vercel.AiGatewayEvaluationFallbackConditionVariant4 PickAiGatewayEvaluationFallbackConditionVariant4() => IsAiGatewayEvaluationFallbackConditionVariant4
            ? AiGatewayEvaluationFallbackConditionVariant4!
            : throw new global::System.InvalidOperationException($"Expected union variant 'AiGatewayEvaluationFallbackConditionVariant4' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vercel.AiGatewayEvaluationFallbackConditionVariant5? AiGatewayEvaluationFallbackConditionVariant5 { get; init; }
#else
        public global::Vercel.AiGatewayEvaluationFallbackConditionVariant5? AiGatewayEvaluationFallbackConditionVariant5 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AiGatewayEvaluationFallbackConditionVariant5))]
#endif
        public bool IsAiGatewayEvaluationFallbackConditionVariant5 => AiGatewayEvaluationFallbackConditionVariant5 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickAiGatewayEvaluationFallbackConditionVariant5(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Vercel.AiGatewayEvaluationFallbackConditionVariant5? value)
        {
            value = AiGatewayEvaluationFallbackConditionVariant5;
            return IsAiGatewayEvaluationFallbackConditionVariant5;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Vercel.AiGatewayEvaluationFallbackConditionVariant5 PickAiGatewayEvaluationFallbackConditionVariant5() => IsAiGatewayEvaluationFallbackConditionVariant5
            ? AiGatewayEvaluationFallbackConditionVariant5!
            : throw new global::System.InvalidOperationException($"Expected union variant 'AiGatewayEvaluationFallbackConditionVariant5' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator AiGatewayEvaluationFallbackCondition(global::Vercel.AiGatewayEvaluationFallbackConditionVariant1 value) => new AiGatewayEvaluationFallbackCondition((global::Vercel.AiGatewayEvaluationFallbackConditionVariant1?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Vercel.AiGatewayEvaluationFallbackConditionVariant1?(AiGatewayEvaluationFallbackCondition @this) => @this.AiGatewayEvaluationFallbackConditionVariant1;

        /// <summary>
        ///
        /// </summary>
        public AiGatewayEvaluationFallbackCondition(global::Vercel.AiGatewayEvaluationFallbackConditionVariant1? value)
        {
            AiGatewayEvaluationFallbackConditionVariant1 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static AiGatewayEvaluationFallbackCondition FromAiGatewayEvaluationFallbackConditionVariant1(global::Vercel.AiGatewayEvaluationFallbackConditionVariant1? value) => new AiGatewayEvaluationFallbackCondition(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator AiGatewayEvaluationFallbackCondition(global::Vercel.AiGatewayEvaluationFallbackConditionVariant2 value) => new AiGatewayEvaluationFallbackCondition((global::Vercel.AiGatewayEvaluationFallbackConditionVariant2?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Vercel.AiGatewayEvaluationFallbackConditionVariant2?(AiGatewayEvaluationFallbackCondition @this) => @this.AiGatewayEvaluationFallbackConditionVariant2;

        /// <summary>
        ///
        /// </summary>
        public AiGatewayEvaluationFallbackCondition(global::Vercel.AiGatewayEvaluationFallbackConditionVariant2? value)
        {
            AiGatewayEvaluationFallbackConditionVariant2 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static AiGatewayEvaluationFallbackCondition FromAiGatewayEvaluationFallbackConditionVariant2(global::Vercel.AiGatewayEvaluationFallbackConditionVariant2? value) => new AiGatewayEvaluationFallbackCondition(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator AiGatewayEvaluationFallbackCondition(global::Vercel.AiGatewayEvaluationFallbackConditionVariant3 value) => new AiGatewayEvaluationFallbackCondition((global::Vercel.AiGatewayEvaluationFallbackConditionVariant3?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Vercel.AiGatewayEvaluationFallbackConditionVariant3?(AiGatewayEvaluationFallbackCondition @this) => @this.AiGatewayEvaluationFallbackConditionVariant3;

        /// <summary>
        ///
        /// </summary>
        public AiGatewayEvaluationFallbackCondition(global::Vercel.AiGatewayEvaluationFallbackConditionVariant3? value)
        {
            AiGatewayEvaluationFallbackConditionVariant3 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static AiGatewayEvaluationFallbackCondition FromAiGatewayEvaluationFallbackConditionVariant3(global::Vercel.AiGatewayEvaluationFallbackConditionVariant3? value) => new AiGatewayEvaluationFallbackCondition(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator AiGatewayEvaluationFallbackCondition(global::Vercel.AiGatewayEvaluationFallbackConditionVariant4 value) => new AiGatewayEvaluationFallbackCondition((global::Vercel.AiGatewayEvaluationFallbackConditionVariant4?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Vercel.AiGatewayEvaluationFallbackConditionVariant4?(AiGatewayEvaluationFallbackCondition @this) => @this.AiGatewayEvaluationFallbackConditionVariant4;

        /// <summary>
        ///
        /// </summary>
        public AiGatewayEvaluationFallbackCondition(global::Vercel.AiGatewayEvaluationFallbackConditionVariant4? value)
        {
            AiGatewayEvaluationFallbackConditionVariant4 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static AiGatewayEvaluationFallbackCondition FromAiGatewayEvaluationFallbackConditionVariant4(global::Vercel.AiGatewayEvaluationFallbackConditionVariant4? value) => new AiGatewayEvaluationFallbackCondition(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator AiGatewayEvaluationFallbackCondition(global::Vercel.AiGatewayEvaluationFallbackConditionVariant5 value) => new AiGatewayEvaluationFallbackCondition((global::Vercel.AiGatewayEvaluationFallbackConditionVariant5?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Vercel.AiGatewayEvaluationFallbackConditionVariant5?(AiGatewayEvaluationFallbackCondition @this) => @this.AiGatewayEvaluationFallbackConditionVariant5;

        /// <summary>
        ///
        /// </summary>
        public AiGatewayEvaluationFallbackCondition(global::Vercel.AiGatewayEvaluationFallbackConditionVariant5? value)
        {
            AiGatewayEvaluationFallbackConditionVariant5 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static AiGatewayEvaluationFallbackCondition FromAiGatewayEvaluationFallbackConditionVariant5(global::Vercel.AiGatewayEvaluationFallbackConditionVariant5? value) => new AiGatewayEvaluationFallbackCondition(value);

        /// <summary>
        ///
        /// </summary>
        public AiGatewayEvaluationFallbackCondition(
            global::Vercel.AiGatewayEvaluationFallbackConditionVariant1? aiGatewayEvaluationFallbackConditionVariant1,
            global::Vercel.AiGatewayEvaluationFallbackConditionVariant2? aiGatewayEvaluationFallbackConditionVariant2,
            global::Vercel.AiGatewayEvaluationFallbackConditionVariant3? aiGatewayEvaluationFallbackConditionVariant3,
            global::Vercel.AiGatewayEvaluationFallbackConditionVariant4? aiGatewayEvaluationFallbackConditionVariant4,
            global::Vercel.AiGatewayEvaluationFallbackConditionVariant5? aiGatewayEvaluationFallbackConditionVariant5
            )
        {
            AiGatewayEvaluationFallbackConditionVariant1 = aiGatewayEvaluationFallbackConditionVariant1;
            AiGatewayEvaluationFallbackConditionVariant2 = aiGatewayEvaluationFallbackConditionVariant2;
            AiGatewayEvaluationFallbackConditionVariant3 = aiGatewayEvaluationFallbackConditionVariant3;
            AiGatewayEvaluationFallbackConditionVariant4 = aiGatewayEvaluationFallbackConditionVariant4;
            AiGatewayEvaluationFallbackConditionVariant5 = aiGatewayEvaluationFallbackConditionVariant5;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            AiGatewayEvaluationFallbackConditionVariant5 as object ??
            AiGatewayEvaluationFallbackConditionVariant4 as object ??
            AiGatewayEvaluationFallbackConditionVariant3 as object ??
            AiGatewayEvaluationFallbackConditionVariant2 as object ??
            AiGatewayEvaluationFallbackConditionVariant1 as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            AiGatewayEvaluationFallbackConditionVariant1?.ToString() ??
            AiGatewayEvaluationFallbackConditionVariant2?.ToString() ??
            AiGatewayEvaluationFallbackConditionVariant3?.ToString() ??
            AiGatewayEvaluationFallbackConditionVariant4?.ToString() ??
            AiGatewayEvaluationFallbackConditionVariant5?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsAiGatewayEvaluationFallbackConditionVariant1 && !IsAiGatewayEvaluationFallbackConditionVariant2 && !IsAiGatewayEvaluationFallbackConditionVariant3 && !IsAiGatewayEvaluationFallbackConditionVariant4 && !IsAiGatewayEvaluationFallbackConditionVariant5 || !IsAiGatewayEvaluationFallbackConditionVariant1 && IsAiGatewayEvaluationFallbackConditionVariant2 && !IsAiGatewayEvaluationFallbackConditionVariant3 && !IsAiGatewayEvaluationFallbackConditionVariant4 && !IsAiGatewayEvaluationFallbackConditionVariant5 || !IsAiGatewayEvaluationFallbackConditionVariant1 && !IsAiGatewayEvaluationFallbackConditionVariant2 && IsAiGatewayEvaluationFallbackConditionVariant3 && !IsAiGatewayEvaluationFallbackConditionVariant4 && !IsAiGatewayEvaluationFallbackConditionVariant5 || !IsAiGatewayEvaluationFallbackConditionVariant1 && !IsAiGatewayEvaluationFallbackConditionVariant2 && !IsAiGatewayEvaluationFallbackConditionVariant3 && IsAiGatewayEvaluationFallbackConditionVariant4 && !IsAiGatewayEvaluationFallbackConditionVariant5 || !IsAiGatewayEvaluationFallbackConditionVariant1 && !IsAiGatewayEvaluationFallbackConditionVariant2 && !IsAiGatewayEvaluationFallbackConditionVariant3 && !IsAiGatewayEvaluationFallbackConditionVariant4 && IsAiGatewayEvaluationFallbackConditionVariant5;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Vercel.AiGatewayEvaluationFallbackConditionVariant1, TResult>? aiGatewayEvaluationFallbackConditionVariant1 = null,
            global::System.Func<global::Vercel.AiGatewayEvaluationFallbackConditionVariant2, TResult>? aiGatewayEvaluationFallbackConditionVariant2 = null,
            global::System.Func<global::Vercel.AiGatewayEvaluationFallbackConditionVariant3, TResult>? aiGatewayEvaluationFallbackConditionVariant3 = null,
            global::System.Func<global::Vercel.AiGatewayEvaluationFallbackConditionVariant4, TResult>? aiGatewayEvaluationFallbackConditionVariant4 = null,
            global::System.Func<global::Vercel.AiGatewayEvaluationFallbackConditionVariant5, TResult>? aiGatewayEvaluationFallbackConditionVariant5 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsAiGatewayEvaluationFallbackConditionVariant1 && aiGatewayEvaluationFallbackConditionVariant1 != null)
            {
                return aiGatewayEvaluationFallbackConditionVariant1(AiGatewayEvaluationFallbackConditionVariant1!);
            }
            else if (IsAiGatewayEvaluationFallbackConditionVariant2 && aiGatewayEvaluationFallbackConditionVariant2 != null)
            {
                return aiGatewayEvaluationFallbackConditionVariant2(AiGatewayEvaluationFallbackConditionVariant2!);
            }
            else if (IsAiGatewayEvaluationFallbackConditionVariant3 && aiGatewayEvaluationFallbackConditionVariant3 != null)
            {
                return aiGatewayEvaluationFallbackConditionVariant3(AiGatewayEvaluationFallbackConditionVariant3!);
            }
            else if (IsAiGatewayEvaluationFallbackConditionVariant4 && aiGatewayEvaluationFallbackConditionVariant4 != null)
            {
                return aiGatewayEvaluationFallbackConditionVariant4(AiGatewayEvaluationFallbackConditionVariant4!);
            }
            else if (IsAiGatewayEvaluationFallbackConditionVariant5 && aiGatewayEvaluationFallbackConditionVariant5 != null)
            {
                return aiGatewayEvaluationFallbackConditionVariant5(AiGatewayEvaluationFallbackConditionVariant5!);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::Vercel.AiGatewayEvaluationFallbackConditionVariant1>? aiGatewayEvaluationFallbackConditionVariant1 = null,

            global::System.Action<global::Vercel.AiGatewayEvaluationFallbackConditionVariant2>? aiGatewayEvaluationFallbackConditionVariant2 = null,

            global::System.Action<global::Vercel.AiGatewayEvaluationFallbackConditionVariant3>? aiGatewayEvaluationFallbackConditionVariant3 = null,

            global::System.Action<global::Vercel.AiGatewayEvaluationFallbackConditionVariant4>? aiGatewayEvaluationFallbackConditionVariant4 = null,

            global::System.Action<global::Vercel.AiGatewayEvaluationFallbackConditionVariant5>? aiGatewayEvaluationFallbackConditionVariant5 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsAiGatewayEvaluationFallbackConditionVariant1)
            {
                aiGatewayEvaluationFallbackConditionVariant1?.Invoke(AiGatewayEvaluationFallbackConditionVariant1!);
            }
            else if (IsAiGatewayEvaluationFallbackConditionVariant2)
            {
                aiGatewayEvaluationFallbackConditionVariant2?.Invoke(AiGatewayEvaluationFallbackConditionVariant2!);
            }
            else if (IsAiGatewayEvaluationFallbackConditionVariant3)
            {
                aiGatewayEvaluationFallbackConditionVariant3?.Invoke(AiGatewayEvaluationFallbackConditionVariant3!);
            }
            else if (IsAiGatewayEvaluationFallbackConditionVariant4)
            {
                aiGatewayEvaluationFallbackConditionVariant4?.Invoke(AiGatewayEvaluationFallbackConditionVariant4!);
            }
            else if (IsAiGatewayEvaluationFallbackConditionVariant5)
            {
                aiGatewayEvaluationFallbackConditionVariant5?.Invoke(AiGatewayEvaluationFallbackConditionVariant5!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::Vercel.AiGatewayEvaluationFallbackConditionVariant1>? aiGatewayEvaluationFallbackConditionVariant1 = null,
            global::System.Action<global::Vercel.AiGatewayEvaluationFallbackConditionVariant2>? aiGatewayEvaluationFallbackConditionVariant2 = null,
            global::System.Action<global::Vercel.AiGatewayEvaluationFallbackConditionVariant3>? aiGatewayEvaluationFallbackConditionVariant3 = null,
            global::System.Action<global::Vercel.AiGatewayEvaluationFallbackConditionVariant4>? aiGatewayEvaluationFallbackConditionVariant4 = null,
            global::System.Action<global::Vercel.AiGatewayEvaluationFallbackConditionVariant5>? aiGatewayEvaluationFallbackConditionVariant5 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsAiGatewayEvaluationFallbackConditionVariant1)
            {
                aiGatewayEvaluationFallbackConditionVariant1?.Invoke(AiGatewayEvaluationFallbackConditionVariant1!);
            }
            else if (IsAiGatewayEvaluationFallbackConditionVariant2)
            {
                aiGatewayEvaluationFallbackConditionVariant2?.Invoke(AiGatewayEvaluationFallbackConditionVariant2!);
            }
            else if (IsAiGatewayEvaluationFallbackConditionVariant3)
            {
                aiGatewayEvaluationFallbackConditionVariant3?.Invoke(AiGatewayEvaluationFallbackConditionVariant3!);
            }
            else if (IsAiGatewayEvaluationFallbackConditionVariant4)
            {
                aiGatewayEvaluationFallbackConditionVariant4?.Invoke(AiGatewayEvaluationFallbackConditionVariant4!);
            }
            else if (IsAiGatewayEvaluationFallbackConditionVariant5)
            {
                aiGatewayEvaluationFallbackConditionVariant5?.Invoke(AiGatewayEvaluationFallbackConditionVariant5!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                AiGatewayEvaluationFallbackConditionVariant1,
                typeof(global::Vercel.AiGatewayEvaluationFallbackConditionVariant1),
                AiGatewayEvaluationFallbackConditionVariant2,
                typeof(global::Vercel.AiGatewayEvaluationFallbackConditionVariant2),
                AiGatewayEvaluationFallbackConditionVariant3,
                typeof(global::Vercel.AiGatewayEvaluationFallbackConditionVariant3),
                AiGatewayEvaluationFallbackConditionVariant4,
                typeof(global::Vercel.AiGatewayEvaluationFallbackConditionVariant4),
                AiGatewayEvaluationFallbackConditionVariant5,
                typeof(global::Vercel.AiGatewayEvaluationFallbackConditionVariant5),
            };
            const int offset = unchecked((int)2166136261);
            const int prime = 16777619;
            static int HashCodeAggregator(int hashCode, object? value) => value == null
                ? (hashCode ^ 0) * prime
                : (hashCode ^ value.GetHashCode()) * prime;

            return global::System.Linq.Enumerable.Aggregate(fields, offset, HashCodeAggregator);
        }

        /// <summary>
        ///
        /// </summary>
        public bool Equals(AiGatewayEvaluationFallbackCondition other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Vercel.AiGatewayEvaluationFallbackConditionVariant1?>.Default.Equals(AiGatewayEvaluationFallbackConditionVariant1, other.AiGatewayEvaluationFallbackConditionVariant1) &&
                global::System.Collections.Generic.EqualityComparer<global::Vercel.AiGatewayEvaluationFallbackConditionVariant2?>.Default.Equals(AiGatewayEvaluationFallbackConditionVariant2, other.AiGatewayEvaluationFallbackConditionVariant2) &&
                global::System.Collections.Generic.EqualityComparer<global::Vercel.AiGatewayEvaluationFallbackConditionVariant3?>.Default.Equals(AiGatewayEvaluationFallbackConditionVariant3, other.AiGatewayEvaluationFallbackConditionVariant3) &&
                global::System.Collections.Generic.EqualityComparer<global::Vercel.AiGatewayEvaluationFallbackConditionVariant4?>.Default.Equals(AiGatewayEvaluationFallbackConditionVariant4, other.AiGatewayEvaluationFallbackConditionVariant4) &&
                global::System.Collections.Generic.EqualityComparer<global::Vercel.AiGatewayEvaluationFallbackConditionVariant5?>.Default.Equals(AiGatewayEvaluationFallbackConditionVariant5, other.AiGatewayEvaluationFallbackConditionVariant5)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(AiGatewayEvaluationFallbackCondition obj1, AiGatewayEvaluationFallbackCondition obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<AiGatewayEvaluationFallbackCondition>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(AiGatewayEvaluationFallbackCondition obj1, AiGatewayEvaluationFallbackCondition obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is AiGatewayEvaluationFallbackCondition o && Equals(o);
        }
    }
}
