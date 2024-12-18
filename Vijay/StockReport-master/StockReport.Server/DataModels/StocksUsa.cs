using System;
using System.Collections.Generic;

namespace StockReport.Server.Models;

public partial class StocksUsa
{
    public int Id { get; set; }

    public string? Description { get; set; }

    public string? Symbol { get; set; }

    public string? Ex { get; set; }

    public DateTime? Date { get; set; }

    public string? Dayofweek { get; set; }

    public string? MarketCapnNew { get; set; }

    public decimal? Change { get; set; }

    public decimal? InTheMoney { get; set; }

    public decimal? OutOfTheMoney { get; set; }

    public decimal? _52high { get; set; }

    public decimal? _52low { get; set; }

    public decimal? Adx { get; set; }

    public decimal? AdxbreakoutsFilter { get; set; }

    public decimal? Adxcrossover { get; set; }

    public decimal? Adxr { get; set; }

    public decimal? AmDetector { get; set; }

    public decimal? Aptr { get; set; }

    public decimal? Arsi { get; set; }

    public decimal? Atr { get; set; }

    public decimal? AtrhighSmabreakoutsFilter { get; set; }

    public decimal? AtrtrailingStop { get; set; }

    public decimal? AbandonedBaby { get; set; }

    public decimal? AccDist { get; set; }

    public decimal? AccelerationBands { get; set; }

    public decimal? AccelerationDecelerationOsc { get; set; }

    public decimal? AccumDistBuyPr { get; set; }

    public decimal? AccumDistPrVol { get; set; }

    public decimal? AccumulationDistribution { get; set; }

    public decimal? AccumulationSwingIndex { get; set; }

    public decimal? AdaptiveEma { get; set; }

    public decimal? AdvanceBlock { get; set; }

    public decimal? AdvanceDecline { get; set; }

    public decimal? AdvanceDeclineCumulativeAvg { get; set; }

    public decimal? Alpha2 { get; set; }

    public decimal? AlphaJensen { get; set; }

    public decimal? AnchoredVwap { get; set; }

    public decimal? AroonIndicator { get; set; }

    public decimal? AroonOscillator { get; set; }

    public decimal? Ask { get; set; }

    public decimal? As { get; set; }

    public string? Ax { get; set; }

    public decimal? AvgPrice { get; set; }

    public decimal? AvgVolYtd { get; set; }

    public decimal? AwesomeOscillator { get; set; }

    public decimal? Bbdivergence { get; set; }

    public string? BackExpectedMove { get; set; }

    public decimal? BackVol { get; set; }

    public decimal? BalanceOfMarketPower { get; set; }

    public decimal? BandpassFilter { get; set; }

    public decimal? BeltHold { get; set; }

    public decimal? Beta { get; set; }

    public decimal? Beta1 { get; set; }

    public decimal? Beta2 { get; set; }

    public decimal? Bid { get; set; }

    public decimal? Bs { get; set; }

    public string? Bx { get; set; }

    public decimal? BollingerBands { get; set; }

    public decimal? BollingerBandsCrossover { get; set; }

    public decimal? BollingerBandwidth { get; set; }

    public decimal? BollingerPercentB { get; set; }

    public decimal? BookValuePerShareCurrentLtm { get; set; }

    public decimal? BookValuePerShareGrowthCurrent { get; set; }

    public decimal? Breakaway { get; set; }

    public decimal? CamIndicator { get; set; }

    public decimal? Cci { get; set; }

    public decimal? Cciaverage { get; set; }

    public decimal? Cpmo { get; set; }

    public decimal? Csi { get; set; }

    public decimal? CallSizzleIndex { get; set; }

    public decimal? CamarillaPoints { get; set; }

    public decimal? CashFlowPerShareCurrentLtm { get; set; }

    public decimal? ChaikinMoneyFlow { get; set; }

    public decimal? ChaikinOsc { get; set; }

    public decimal? ChaikinOscillator { get; set; }

    public decimal? ChaikinVolatility { get; set; }

    public decimal? ChandeMomentumOscillator { get; set; }

    public decimal? ChgOpen { get; set; }

    public decimal? CloseLocationValue { get; set; }

    public string? CompanyAddressCity { get; set; }

    public string? CompanyAddressNation { get; set; }

    public string? CompanyAddressState { get; set; }

    public string? CompanyAddressStreet { get; set; }

    public string? CompanyAddressZip { get; set; }

    public string? CompanyName { get; set; }

    public string? CompanyPhone { get; set; }

    public string? CompanyWebsite { get; set; }

    public decimal? ConcealingBabySwallow { get; set; }

    public decimal? CondensedCandles { get; set; }

    public decimal? CongAdaptiveMovingAverage { get; set; }

    public decimal? Correlation { get; set; }

    public decimal? CorrelationCycleAngle { get; set; }

    public decimal? CorrelationCycleIndicator { get; set; }

    public decimal? CorrelationCycleMarketState { get; set; }

    public decimal? CorrelationTrendIndicator { get; set; }

    public decimal? Cost { get; set; }

    public decimal? CovReturn { get; set; }

    public decimal? CumulativeOvernightVolume { get; set; }

    public decimal? CumulativeVolumeIndex { get; set; }

    public decimal? CurrentRatioCurrentLtm { get; set; }

    public string? Cusip { get; set; }

    public decimal? CyberCyclesOscillator { get; set; }

    public decimal? CycleTrendAnalytics { get; set; }

    public decimal? Dema { get; set; }

    public decimal? Diminus { get; set; }

    public decimal? Diplus { get; set; }

    public decimal? Dma { get; set; }

    public decimal? Dmh { get; set; }

    public decimal? Dmi { get; set; }

    public decimal? DmiOscillator { get; set; }

    public decimal? DmiReversalAlerts { get; set; }

    public decimal? DmiStochasticExtreme { get; set; }

    public decimal? DailyHighLow { get; set; }

    public decimal? DailyOpen { get; set; }

    public string? DailyRelativeRange { get; set; }

    public decimal? DailySma { get; set; }

    public decimal? DarkCloudCover { get; set; }

    public decimal? DarvasBox { get; set; }

    public DateTime? DateOfIncorporation { get; set; }

    public decimal? Days { get; set; }

    public decimal? Deliberation { get; set; }

    public decimal? Delta { get; set; }

    public decimal? DemandIndex { get; set; }

    public decimal? DetrendedPriceOsc { get; set; }

    public decimal? DeviationScaledMovAvg { get; set; }

    public decimal? DeviationScaledOscillator { get; set; }

    public decimal? DisparityIndex { get; set; }

    public decimal? DisplacedEma { get; set; }

    public decimal? Displacer { get; set; }

    public decimal? Div { get; set; }

    public string? DivFreq { get; set; }

    public decimal? DivPayoutOfEarningsCurrentLtm { get; set; }

    public decimal? DivPayoutPerShareOfEpsCurrent { get; set; }

    public decimal? DivPerShareCurrent { get; set; }

    public decimal? DivPerShareTtmCurrentLtm { get; set; }

    public decimal? DivYieldCurrent { get; set; }

    public int? Doji { get; set; }

    public decimal? DollarVolume { get; set; }

    public decimal? DoubleSmoothedStochastic { get; set; }

    public decimal? DownsideGapThreeMethods { get; set; }

    public decimal? DownsideTasukiGap { get; set; }

    public decimal? DynamicMomentumIndex { get; set; }

    public decimal? EbitdaCurrent { get; set; }

    public decimal? EprLower { get; set; }

    public decimal? EprUpper { get; set; }

    public decimal? Eps { get; set; }

    public decimal? Esdbands { get; set; }

    public decimal? EarningsPerShareCurrent { get; set; }

    public decimal? EarningsPerShareTtmCurrentLtm { get; set; }

    public decimal? EaseOfMovement { get; set; }

    public decimal? EfficiencyRatio { get; set; }

    public decimal? EhlersAutocorrelation { get; set; }

    public decimal? EhlersAutocorrelationPeriodogram { get; set; }

    public decimal? EhlersDecyclerOscillator { get; set; }

    public decimal? EhlersDistantCoefficientFilter { get; set; }

    public decimal? EhlersHighpassFilter { get; set; }

    public decimal? EhlersRoofingFilter { get; set; }

    public decimal? EhlersSimpleDecycler { get; set; }

    public decimal? EhlersStochastic { get; set; }

    public decimal? EhlersSuperSmootherFilter { get; set; }

    public decimal? ElegantOscillator { get; set; }

    public decimal? ElliotOscillator { get; set; }

    public int? Engulfing { get; set; }

    public decimal? ErgodicOsc { get; set; }

    public int? Ermanometry { get; set; }

    public int? EveningDojiStar { get; set; }

    public int? EveningStar { get; set; }

    public DateTime? ExDivDate { get; set; }

    public string? ExpectedMoveDiff { get; set; }

    public decimal? ExponentialDeviationBands { get; set; }

    public decimal? Extrinsic { get; set; }

    public decimal? FirFiltersOfPriceChange { get; set; }

    public decimal? FirHamming { get; set; }

    public decimal? FirHann { get; set; }

    public decimal? FirTriangleWeighting { get; set; }

    public decimal? FmDemodulator { get; set; }

    public decimal? FmDemodulator2 { get; set; }

    public decimal? FwCciAdvanced { get; set; }

    public decimal? FwCciBasic { get; set; }

    public decimal? FwDpoMobo { get; set; }

    public decimal? FwFisherTransformer { get; set; }

    public decimal? FwMmg { get; set; }

    public decimal? FwMoboAdvanced { get; set; }

    public decimal? FwMoboBasic { get; set; }

    public decimal? FwSoap { get; set; }

    public decimal? FallingThreeMethods { get; set; }

    public decimal? FastBeta { get; set; }

    public decimal? FiftySmaPctChange { get; set; }

    public decimal? FinancialLeverageAssetsEquityCurrentLtm { get; set; }

    public decimal? FisherTransform { get; set; }

    public decimal? FiveDayChg { get; set; }

    public decimal? FixedChargeCoverageRatioCurrentLtm { get; set; }

    public decimal? ForceIndex { get; set; }

    public decimal? ForecastOscillator { get; set; }

    public decimal? FourPercentModel { get; set; }

    public decimal? FourierSeriesIndicator { get; set; }

    public decimal? FreeCashFlowPerShareCurrentLtm { get; set; }

    public decimal? FreedomOfMovement { get; set; }

    public string? FrontExpectedMove { get; set; }

    public decimal? FrontVol { get; set; }

    public decimal? Gamma { get; set; }

    public decimal? GapMomentum { get; set; }

    public decimal? GatorOscillator { get; set; }

    public decimal? GrossProfitMarginCurrentLtm { get; set; }

    public decimal? Hacolt { get; set; }

    public decimal? Hhlls { get; set; }

    public decimal? Hlvolatility { get; set; }

    public string? HtbEtb { get; set; }

    public decimal? HvPercentile { get; set; }

    public int? Hammer { get; set; }

    public int? HangingMan { get; set; }

    public int? Harami { get; set; }

    public int? HaramiCross { get; set; }

    public decimal? HeikinAshiDiff { get; set; }

    public decimal? HiLoActivator { get; set; }

    public decimal? High { get; set; }

    public decimal? HighLowGraph { get; set; }

    public int? HighPriceGappingPlay { get; set; }

    public decimal? HistoricalVolatility { get; set; }

    public int? HomingPigeon { get; set; }

    public decimal? HullMovingAvg { get; set; }

    public decimal? IftStochOsc { get; set; }

    public decimal? IvPercentile { get; set; }

    public decimal? Ichimoku { get; set; }

    public int? IdenticalThreeCrows { get; set; }

    public decimal? ImpVolatility { get; set; }

    public decimal? ImplVol { get; set; }

    public int? Impulse { get; set; }

    public int? InNeck { get; set; }

    public string? Industry { get; set; }

    public decimal? Inertia { get; set; }

    public string? InitialMargin { get; set; }

    public decimal? InterestRateEstimatedAverageCurrentLtm { get; set; }

    public int? IntradayFlagFormation { get; set; }

    public decimal? IntradayMomentumIndex { get; set; }

    public string? Intrinsic { get; set; }

    public decimal? InventoryTurnoverCurrentLtm { get; set; }

    public int? InvertedHammer { get; set; }

    public decimal? KeltnerChannels { get; set; }

    public int? Kicking { get; set; }

    public decimal? KlingerHistogram { get; set; }

    public decimal? KlingerOscillator { get; set; }

    public int? LbrPaintBars { get; set; }

    public decimal? LbrSmartAdx { get; set; }

    public decimal? LbrThreeTenOscillator { get; set; }

    public decimal? Last { get; set; }

    public DateTime? LastAnnualFilingDate { get; set; }

    public DateTime? LastInterimFilingDate { get; set; }

    public decimal? LastSize { get; set; }

    public string? Lx { get; set; }

    public decimal? LeavittConvolution { get; set; }

    public decimal? LeavittConvolutionAcceleration { get; set; }

    public decimal? LeavittConvolutionSlope { get; set; }

    public decimal? LegacyEma { get; set; }

    public decimal? LinearRegAdjEma { get; set; }

    public decimal? LinearRegCh100 { get; set; }

    public decimal? LinearRegCh50 { get; set; }

    public decimal? LinearRegChVar { get; set; }

    public decimal? LinearRegCurve { get; set; }

    public decimal? LinearRegTrendline { get; set; }

    public decimal? LinearRegrReversal { get; set; }

    public decimal? LinearRegressionSlope { get; set; }

    public decimal? LongTermDebtToCapitalCurrentLtm { get; set; }

    public int? LongHaulFilter { get; set; }

    public int? LongLeggedDoji { get; set; }

    public decimal? LookUpHighest { get; set; }

    public decimal? LookUpLowest { get; set; }

    public decimal? Low { get; set; }

    public decimal? LowPriceGappingPlay { get; set; }

    public decimal? Macd { get; set; }

    public decimal? Macdhistogram { get; set; }

    public decimal? MacdhistogramCrossover { get; set; }

    public decimal? MacdtwoLines { get; set; }

    public decimal? MacdwithPrices { get; set; }

    public decimal? Mad { get; set; }

    public decimal? Madh { get; set; }

    public decimal? MesasineWave { get; set; }

    public decimal? MfPct { get; set; }

    public decimal? MajorGannLevels { get; set; }

    public decimal? Mark { get; set; }

    public decimal? MarkChange { get; set; }

    public decimal? MarkOfUnderlyingValue { get; set; }

    public decimal? MarkChange1 { get; set; }

    public decimal? MarkerIndicator { get; set; }

    public decimal? MarketCapCommonEquityRatioCurrent { get; set; }

    public string? MarketCap { get; set; }

    public string? MarketMakerMove { get; set; }

    public decimal? MarketForecast { get; set; }

    public decimal? MarketSentiment { get; set; }

    public int? Marubozu { get; set; }

    public decimal? MassIndex { get; set; }

    public int? MatHold { get; set; }

    public int? MatchingLow { get; set; }

    public string? MaxCovReturn { get; set; }

    public decimal? McClellanOscillator { get; set; }

    public decimal? McClellanSummationIndex { get; set; }

    public decimal? MedianAverage { get; set; }

    public decimal? MedianPrice { get; set; }

    public decimal? MeetingLines { get; set; }

    public decimal? MiddleHighLowMa { get; set; }

    public decimal? MktFacilitationIdx { get; set; }

    public decimal? ModifiedTrueRange { get; set; }

    public decimal? Momentum { get; set; }

    public int? MomentumCrossover { get; set; }

    public decimal? MomentumPercent { get; set; }

    public decimal? MomentumPercentDiff { get; set; }

    public decimal? MomentumSma { get; set; }

    public decimal? MoneyFlow { get; set; }

    public decimal? MoneyFlowIndex { get; set; }

    public decimal? MoneyFlowIndexCrossover { get; set; }

    public decimal? MoneyFlowOscillator { get; set; }

    public decimal? MonkeyBars { get; set; }

    public decimal? MonthlySeasonality { get; set; }

    public decimal? MorningDojiStar { get; set; }

    public decimal? MorningStar { get; set; }

    public decimal? MovAvgAdaptive { get; set; }

    public decimal? MovAvgBandWidth { get; set; }

    public decimal? MovAvgBands { get; set; }

    public decimal? MovAvgEnvelope { get; set; }

    public decimal? MovAvgExpRibbon { get; set; }

    public decimal? MovAvgExponential { get; set; }

    public decimal? MovAvgTriangular { get; set; }

    public decimal? MovAvgTwoLines { get; set; }

    public decimal? MovAvgWeighted { get; set; }

    public decimal? MovingAvgCrossover { get; set; }

    public decimal? MultiCurrencyCorrelationOsc { get; set; }

    public decimal? MyRsiwithNet { get; set; }

    public decimal? NegativeVolumeIndex { get; set; }

    public decimal? NetChng { get; set; }

    public decimal? NetIncomeCurrent { get; set; }

    public decimal? NetProfitMarginCurrentLtm { get; set; }

    public decimal? Next3rdFriday { get; set; }

    public decimal? OnBalanceVolume { get; set; }

    public decimal? OnBalanceVolumeModified { get; set; }

    public decimal? OnNeck { get; set; }

    public decimal? OneBlackCrow { get; set; }

    public decimal? OneWhiteSoldier { get; set; }

    public decimal? OneHundredSmaPctChange { get; set; }

    public decimal? OneMoChg { get; set; }

    public decimal? OneYrChg { get; set; }

    public decimal? OnsetTrendDetector { get; set; }

    public decimal? Open { get; set; }

    public decimal? OpenInt { get; set; }

    public decimal? OpenInterest { get; set; }

    public decimal? OperatingProfitMarginCurrentLtm { get; set; }

    public decimal? OptionDelta { get; set; }

    public decimal? OptionGamma { get; set; }

    public decimal? OptionRho { get; set; }

    public decimal? OptionTheta { get; set; }

    public decimal? OptionVega { get; set; }

    public decimal? PLDay { get; set; }

    public decimal? PLOpen { get; set; }

    public decimal? PL { get; set; }

    public decimal? PLYear { get; set; }

    public decimal? Pe { get; set; }

    public decimal? Pmc { get; set; }

    public decimal? Pmo { get; set; }

    public decimal? Pps { get; set; }

    public decimal? PairCorrelation { get; set; }

    public decimal? PairRatio { get; set; }

    public decimal? ParabolicSar { get; set; }

    public decimal? ParabolicSarcrossover { get; set; }

    public decimal? PercentChg { get; set; }

    public decimal? PercentR { get; set; }

    public decimal? PersonsPivots { get; set; }

    public decimal? PiercingLine { get; set; }

    public decimal? PivotPoints { get; set; }

    public decimal? PolarizedFractalEfficiency { get; set; }

    public decimal? PolychromMtm { get; set; }

    public decimal? NetLiq { get; set; }

    public decimal? PosQty { get; set; }

    public decimal? PositiveVolumeIndex { get; set; }

    public decimal? PriceBookValueRatioCurrent { get; set; }

    public decimal? PriceCashFlowRatioCurrent { get; set; }

    public decimal? PriceEarningsRatioCurrent { get; set; }

    public decimal? PriceActionIndicator { get; set; }

    public decimal? PriceAndVolumeTrend { get; set; }

    public decimal? PriceAverageCrossover { get; set; }

    public decimal? PriceChannel { get; set; }

    public decimal? PriceOsc { get; set; }

    public decimal? PriceRatio { get; set; }

    public decimal? PriceTimeFilteringAccVolume { get; set; }

    public decimal? PriceTimeFilteringBarCount { get; set; }

    public decimal? PriceVolumeRank { get; set; }

    public decimal? PriceZoneOscillator { get; set; }

    public decimal? ProbItm { get; set; }

    public decimal? ProbOtm { get; set; }

    public decimal? ProbTouch { get; set; }

    public decimal? ProjectionBands { get; set; }

    public decimal? ProjectionOscillator { get; set; }

    public decimal? PutSizzleIndex { get; set; }

    public decimal? PCRatio { get; set; }

    public decimal? Qstick { get; set; }

    public decimal? QuickRatioCurrentLtm { get; set; }

    public decimal? Rdoc { get; set; }

    public decimal? Rsi { get; set; }

    public decimal? Rsicrossover { get; set; }

    public decimal? Rsih { get; set; }

    public decimal? RsiColorized { get; set; }

    public decimal? Rsmk { get; set; }

    public decimal? RsVaEma { get; set; }

    public decimal? Rsquared { get; set; }

    public decimal? RainbowAverage { get; set; }

    public decimal? RandomWalkIndex { get; set; }

    public decimal? RangeBands { get; set; }

    public decimal? RangeIndicator { get; set; }

    public decimal? RateOfChange { get; set; }

    public decimal? RateOfChangeCrossover { get; set; }

    public decimal? RateOfChangeWithBands { get; set; }

    public decimal? Ray { get; set; }

    public decimal? RayBearPower { get; set; }

    public decimal? RayBullPower { get; set; }

    public decimal? RecursiveMedianFilter { get; set; }

    public decimal? RecursiveMedianOscillator { get; set; }

    public decimal? Reflex { get; set; }

    public decimal? RegressionDivergence { get; set; }

    public decimal? RelativeMomentumIndex { get; set; }

    public decimal? RelativeRangeIndex { get; set; }

    public decimal? RelativeStrength { get; set; }

    public decimal? RelativeVolatilityIndex { get; set; }

    public decimal? RelativeVolumeStDev { get; set; }

    public decimal? ReturnOnAssetsRoaCurrentLtm { get; set; }

    public decimal? Roc { get; set; }

    public decimal? ReturnOnEquityRoeCurrentLtm { get; set; }

    public decimal? Ror { get; set; }

    public decimal? RevenueCurrent { get; set; }

    public decimal? ReverseEma { get; set; }

    public decimal? ReverseEngineeringMacd { get; set; }

    public decimal? ReverseEngineeringRsi { get; set; }

    public decimal? Rho { get; set; }

    public decimal? RibbonStudy { get; set; }

    public decimal? RisingThreeMethods { get; set; }

    public decimal? RocketRsi { get; set; }

    public decimal? Starcbands { get; set; }

    public decimal? Svepivots { get; set; }

    public decimal? SvestochRsi { get; set; }

    public decimal? SvezlrbpercB { get; set; }

    public decimal? SalesPerShareCurrentLtm { get; set; }

    public decimal? SchaffTrendCycle { get; set; }

    public string? Sector { get; set; }

    public string? SectorRotationModel { get; set; }

    public decimal? SemiCupFormation { get; set; }

    public decimal? SentimentZoneOscillator { get; set; }

    public decimal? SeparatingLines { get; set; }

    public decimal? SequenceCounter { get; set; }

    public decimal? SeriesCount { get; set; }

    public decimal? Shares { get; set; }

    public decimal? ShootingStar { get; set; }

    public decimal? ShortSaleBorrowingRate { get; set; }

    public decimal? SideBySideWhiteLines { get; set; }

    public decimal? SimpleMovingAvg { get; set; }

    public decimal? SimpleTrendChannelFilter { get; set; }

    public decimal? SixMoChg { get; set; }

    public string? Size { get; set; }

    public decimal? SizzleIndex { get; set; }

    public decimal? SlowRsi { get; set; }

    public decimal? SlowVsi { get; set; }

    public decimal? _24h168hSocialActivityRatio { get; set; }

    public decimal? _24h56dSocialActivityRatio { get; set; }

    public decimal? _1h168hSocialActivityRatio { get; set; }

    public decimal? _168h56dSocialActivityRatio { get; set; }

    public decimal? _168hMavgMentionsCount { get; set; }

    public decimal? _1dCountMentionsCount { get; set; }

    public decimal? _1hCountMentionsCount { get; set; }

    public decimal? SoftAndHardLimiterComparison { get; set; }

    public decimal? Spearman { get; set; }

    public decimal? SpectrumBars { get; set; }

    public decimal? Spreads { get; set; }

    public decimal? StandardDevChannel { get; set; }

    public decimal? StandardDeviation { get; set; }

    public decimal? StandardError { get; set; }

    public decimal? StandardErrorBands { get; set; }

    public decimal? StandardErrorChannel { get; set; }

    public decimal? StickSandwich { get; set; }

    public decimal? Stiffness { get; set; }

    public decimal? StochRsi { get; set; }

    public decimal? StochasticCrossover { get; set; }

    public decimal? StochasticFast { get; set; }

    public decimal? StochasticFull { get; set; }

    public decimal? StochasticFullDiff { get; set; }

    public decimal? StochasticMacd { get; set; }

    public decimal? StochasticMomentumIndex { get; set; }

    public decimal? StochasticSlow { get; set; }

    public decimal? StressIndicator { get; set; }

    public string? SubIndustry { get; set; }

    public decimal? SuperPassbandFilter { get; set; }

    public decimal? SwamiAccDist { get; set; }

    public decimal? SwamiConvolution { get; set; }

    public decimal? SwamiIntradayFisher { get; set; }

    public decimal? SwamiIntradayImpulse { get; set; }

    public decimal? SwamiIntradayVolume { get; set; }

    public decimal? SwamiLaguerreTrend { get; set; }

    public decimal? SwamiMarketMode { get; set; }

    public decimal? SwamiPredict { get; set; }

    public decimal? SwamiRelativePerformance { get; set; }

    public decimal? SwamiSwingWave { get; set; }

    public decimal? SwamiVolatility { get; set; }

    public decimal? SwamiVolume { get; set; }

    public decimal? SwingIndex { get; set; }

    public decimal? SymbolRelation { get; set; }

    public decimal? TacAdx { get; set; }

    public decimal? TacDiminus { get; set; }

    public decimal? TacDiplus { get; set; }

    public decimal? Tema { get; set; }

    public decimal? Tmv { get; set; }

    public decimal? Tpoprofile { get; set; }

    public decimal? Trix { get; set; }

    public decimal? TtmLrc { get; set; }

    public decimal? TtmScalperAlert { get; set; }

    public decimal? TtmSqueeze { get; set; }

    public decimal? TtmTrend { get; set; }

    public decimal? TtmWave { get; set; }

    public decimal? TaxRateCurrentLtm { get; set; }

    public decimal? TechnicalStockRating { get; set; }

    public decimal? TheoPrice { get; set; }

    public decimal? TheoreticalOptionPrice { get; set; }

    public decimal? Theta { get; set; }

    public decimal? ThreeBlackCrows { get; set; }

    public decimal? ThreeInsideDown { get; set; }

    public decimal? ThreeInsideUp { get; set; }

    public decimal? ThreeLineStrike { get; set; }

    public decimal? ThreeOutsideDown { get; set; }

    public decimal? ThreeOutsideUp { get; set; }

    public decimal? ThreeStarsInTheSouth { get; set; }

    public decimal? ThreeWhiteSoldiers { get; set; }

    public decimal? Thrusting { get; set; }

    public decimal? TickSize { get; set; }

    public decimal? TickValue { get; set; }

    public decimal? TimeSeriesForecast { get; set; }

    public decimal? TotalAssetTurnoverCurrentLtm { get; set; }

    public decimal? TotalCost { get; set; }

    public decimal? TradeVolumeIndex { get; set; }

    public decimal? TrendNoiseBalance { get; set; }

    public decimal? TrendPeriods { get; set; }

    public decimal? TrendPersistenceRate { get; set; }

    public decimal? TrendQuality { get; set; }

    public decimal? Trendflex { get; set; }

    public decimal? TriStar { get; set; }

    public decimal? TrueRangeAdjEma { get; set; }

    public decimal? TrueRangeIndicator { get; set; }

    public decimal? TrueRangeSpecifiedVolume { get; set; }

    public decimal? TrueStrengthIndex { get; set; }

    public decimal? TwentyDayChg { get; set; }

    public decimal? TwentySmaPctChange { get; set; }

    public decimal? TwoCrows { get; set; }

    public decimal? TwoHundredSmaPctChange { get; set; }

    public decimal? TypicalPrice { get; set; }

    public decimal? UlcerIndex { get; set; }

    public decimal? UltimateOscillator { get; set; }

    public decimal? UnderlyingLast { get; set; }

    public decimal? UndersampledDoubleMovAvg { get; set; }

    public decimal? UniqueThreeRiverBottom { get; set; }

    public decimal? UniversalOscillator { get; set; }

    public decimal? UpsideGapThreeMethods { get; set; }

    public decimal? UpsideGapTwoCrows { get; set; }

    public decimal? UpsideTasukiGap { get; set; }

    public decimal? Vpnindicator { get; set; }

    public decimal? Vwap { get; set; }

    public decimal? VariableMa { get; set; }

    public decimal? Vega { get; set; }

    public decimal? VerticalHorizontalFilter { get; set; }

    public decimal? VolDiff { get; set; }

    public decimal? VolIndex { get; set; }

    public decimal? VolSizzle { get; set; }

    public decimal? VolatilityStdDev { get; set; }

    public decimal? VolatilitySwitch { get; set; }

    public decimal? Volume { get; set; }

    public decimal? VolumeAccumulation { get; set; }

    public decimal? VolumeAvg { get; set; }

    public decimal? VolumeFlowIndicator { get; set; }

    public decimal? VolumeOsc { get; set; }

    public decimal? VolumeProfile { get; set; }

    public decimal? VolumeRateOfChange { get; set; }

    public decimal? VolumeWeightedMacd { get; set; }

    public decimal? VolumeZoneOscillator { get; set; }

    public decimal? VortexIndicator { get; set; }

    public decimal? VossPredictiveFilter { get; set; }

    public decimal? WarningSymbols { get; set; }

    public decimal? WeaknessInAstrongTrend { get; set; }

    public decimal? WeeklyAndDailyMacd { get; set; }

    public decimal? WeeklyAndDailyPpo { get; set; }

    public decimal? WeightedBackVol { get; set; }

    public decimal? WeightedClose { get; set; }

    public decimal? WildersSmoothing { get; set; }

    public decimal? WilliamsAd { get; set; }

    public decimal? WilliamsAlligator { get; set; }

    public decimal? WilliamsFractal { get; set; }

    public decimal? WilliamsPercentR { get; set; }

    public decimal? WoodiesPivots { get; set; }

    public decimal? YtdChg { get; set; }

    public decimal? YearlyRelativeRange { get; set; }

    public decimal? Close { get; set; }

    public decimal? Yield { get; set; }

    public decimal? ZigZagHighLow { get; set; }

    public decimal? ZigZagPercent { get; set; }

    public decimal? ZigZagSign { get; set; }

    public decimal? ZigZagStepPattern { get; set; }

    public decimal? ZigZagTrendPercent { get; set; }

    public decimal? ZigZagTrendSign { get; set; }

    public decimal? Pct1MoChg { get; set; }

    public decimal? Pct1YrChg { get; set; }

    public decimal? Pct20DayChg { get; set; }

    public decimal? Pct5DayChg { get; set; }

    public decimal? Pct6MoChg { get; set; }

    public decimal? PctChgOpen { get; set; }

    public decimal? PctChgFrom52wkHi { get; set; }

    public decimal? PctChgFrom52wkLo { get; set; }

    public decimal? PctYtdChg { get; set; }
}
