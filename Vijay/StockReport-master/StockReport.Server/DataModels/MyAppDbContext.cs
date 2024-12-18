using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace StockReport.Server.Models;

public partial class MyAppDbContext : DbContext
{
    public MyAppDbContext()
    {
    }

    public MyAppDbContext(DbContextOptions<MyAppDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<StocksUsa> StocksUsas { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=localhost;Database=StockReporting;Trusted_Connection=True;TrustServerCertificate=True;Encrypt=False;");
        

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<StocksUsa>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__StocksUS__3214EC27366AC792");

            entity.ToTable("StocksUSARowBased");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.AbandonedBaby).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.AccDist).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.AccelerationBands).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.AccelerationDecelerationOsc).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.AccumDistBuyPr).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.AccumDistPrVol).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.AccumulationDistribution).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.AccumulationSwingIndex).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.AdaptiveEma)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("AdaptiveEMA");
            entity.Property(e => e.AdvanceBlock).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.AdvanceDecline).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.AdvanceDeclineCumulativeAvg).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.Adx)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("ADX");
            entity.Property(e => e.AdxbreakoutsFilter)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("ADXBreakoutsFilter");
            entity.Property(e => e.Adxcrossover)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("ADXCrossover");
            entity.Property(e => e.Adxr)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("ADXR");
            entity.Property(e => e.Alpha2).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.AlphaJensen).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.AmDetector)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("AM_Detector");
            entity.Property(e => e.AnchoredVwap)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("AnchoredVWAP");
            entity.Property(e => e.Aptr)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("APTR");
            entity.Property(e => e.AroonIndicator).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.AroonOscillator).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.Arsi)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("ARSI");
            entity.Property(e => e.As)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("AS");
            entity.Property(e => e.Ask).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.Atr)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("ATR");
            entity.Property(e => e.AtrhighSmabreakoutsFilter)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("ATRHighSMABreakoutsFilter");
            entity.Property(e => e.AtrtrailingStop)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("ATRTrailingStop");
            entity.Property(e => e.AvgPrice)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("Avg Price");
            entity.Property(e => e.AvgVolYtd)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("Avg_Vol_YTD");
            entity.Property(e => e.AwesomeOscillator).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.Ax)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("AX");
            entity.Property(e => e.BackExpectedMove)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Back Expected Move");
            entity.Property(e => e.BackVol)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("Back Vol");
            entity.Property(e => e.BalanceOfMarketPower).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.BandpassFilter).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.Bbdivergence)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("BBDivergence");
            entity.Property(e => e.BeltHold).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.Beta).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.Beta1).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.Beta2).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.Bid).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.BollingerBands).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.BollingerBandsCrossover).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.BollingerBandwidth).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.BollingerPercentB).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.BookValuePerShareCurrentLtm)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("Book Value Per Share - Current (LTM)");
            entity.Property(e => e.BookValuePerShareGrowthCurrent)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("Book Value Per Share Growth - Current");
            entity.Property(e => e.Breakaway).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.Bs)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("BS");
            entity.Property(e => e.Bx)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("BX");
            entity.Property(e => e.CallSizzleIndex)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("Call Sizzle Index");
            entity.Property(e => e.CamIndicator)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("CAM_Indicator");
            entity.Property(e => e.CamarillaPoints).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.CashFlowPerShareCurrentLtm)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("Cash Flow Per Share - Current (LTM)");
            entity.Property(e => e.Cci)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("CCI");
            entity.Property(e => e.Cciaverage)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("CCIAverage");
            entity.Property(e => e.ChaikinMoneyFlow).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.ChaikinOsc).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.ChaikinOscillator).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.ChaikinVolatility).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.ChandeMomentumOscillator).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.Change)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("%Change");
            entity.Property(e => e.ChgOpen)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("Chg_Open");
            entity.Property(e => e.Close).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.CloseLocationValue).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.CompanyAddressCity)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Company Address - City");
            entity.Property(e => e.CompanyAddressNation)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Company Address - Nation");
            entity.Property(e => e.CompanyAddressState)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Company Address - State");
            entity.Property(e => e.CompanyAddressStreet)
                .IsUnicode(false)
                .HasColumnName("Company Address - Street");
            entity.Property(e => e.CompanyAddressZip)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Company Address - Zip");
            entity.Property(e => e.CompanyName)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("Company Name");
            entity.Property(e => e.CompanyPhone)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Company Phone");
            entity.Property(e => e.CompanyWebsite)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("Company Website");
            entity.Property(e => e.ConcealingBabySwallow).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.CondensedCandles).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.CongAdaptiveMovingAverage).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.Correlation).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.CorrelationCycleAngle).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.CorrelationCycleIndicator).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.CorrelationCycleMarketState).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.CorrelationTrendIndicator).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.Cost).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.CovReturn)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("Cov Return");
            entity.Property(e => e.Cpmo)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("CPMO");
            entity.Property(e => e.Csi)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("CSI");
            entity.Property(e => e.CumulativeOvernightVolume).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.CumulativeVolumeIndex).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.CurrentRatioCurrentLtm)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("Current Ratio - Current (LTM)");
            entity.Property(e => e.Cusip)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CyberCyclesOscillator).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.CycleTrendAnalytics).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.DailyHighLow).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.DailyOpen).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.DailyRelativeRange)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DailySma)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("DailySMA");
            entity.Property(e => e.DarkCloudCover).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.DarvasBox).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.Date)
                .HasColumnType("datetime")
                .HasColumnName("DATE");
            entity.Property(e => e.DateOfIncorporation)
                .HasColumnType("datetime")
                .HasColumnName("Date of Incorporation");
            entity.Property(e => e.Dayofweek)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DAYOFWEEK");
            entity.Property(e => e.Days).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.Deliberation).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.Delta).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.Dema)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("DEMA");
            entity.Property(e => e.DemandIndex).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.Description)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DetrendedPriceOsc).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.DeviationScaledMovAvg).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.DeviationScaledOscillator).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.Diminus)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("DIMinus");
            entity.Property(e => e.Diplus)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("DIPlus");
            entity.Property(e => e.DisparityIndex).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.DisplacedEma)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("DisplacedEMA");
            entity.Property(e => e.Displacer).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.Div).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.DivFreq)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Div.Freq");
            entity.Property(e => e.DivPayoutOfEarningsCurrentLtm)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("Div. Payout (% of Earnings) - Current (LTM)");
            entity.Property(e => e.DivPayoutPerShareOfEpsCurrent)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("Div. Payout Per Share (% of EPS) - Current");
            entity.Property(e => e.DivPerShareCurrent)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("Div. Per Share - Current");
            entity.Property(e => e.DivPerShareTtmCurrentLtm)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("Div. Per Share - TTM - Current (LTM)");
            entity.Property(e => e.DivYieldCurrent)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("Div. Yield - Current");
            entity.Property(e => e.Dma)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("DMA");
            entity.Property(e => e.Dmh)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("DMH");
            entity.Property(e => e.Dmi)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("DMI");
            entity.Property(e => e.DmiOscillator)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("DMI_Oscillator");
            entity.Property(e => e.DmiReversalAlerts)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("DMI_ReversalAlerts");
            entity.Property(e => e.DmiStochasticExtreme)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("DMI_StochasticExtreme");
            entity.Property(e => e.DollarVolume)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("Dollar_Volume");
            entity.Property(e => e.DoubleSmoothedStochastic).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.DownsideGapThreeMethods).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.DownsideTasukiGap).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.DynamicMomentumIndex).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.EarningsPerShareCurrent)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("Earnings Per Share - Current");
            entity.Property(e => e.EarningsPerShareTtmCurrentLtm)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("Earnings Per Share - TTM - Current (LTM)");
            entity.Property(e => e.EaseOfMovement).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.EbitdaCurrent)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("EBITDA - Current");
            entity.Property(e => e.EfficiencyRatio).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.EhlersAutocorrelation).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.EhlersAutocorrelationPeriodogram).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.EhlersDecyclerOscillator).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.EhlersDistantCoefficientFilter).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.EhlersHighpassFilter).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.EhlersRoofingFilter).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.EhlersSimpleDecycler).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.EhlersStochastic).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.EhlersSuperSmootherFilter).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.ElegantOscillator).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.ElliotOscillator).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.EprLower)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("EPR Lower");
            entity.Property(e => e.EprUpper)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("EPR Upper");
            entity.Property(e => e.Eps)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("EPS");
            entity.Property(e => e.ErgodicOsc).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.Esdbands)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("ESDBands");
            entity.Property(e => e.Ex)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("EX");
            entity.Property(e => e.ExDivDate)
                .HasColumnType("datetime")
                .HasColumnName("Ex Div.Date");
            entity.Property(e => e.ExpectedMoveDiff)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Expected Move Diff");
            entity.Property(e => e.ExponentialDeviationBands).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.Extrinsic).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.FallingThreeMethods).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.FastBeta).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.FiftySmaPctChange)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("Fifty_SMA_pct_Change");
            entity.Property(e => e.FinancialLeverageAssetsEquityCurrentLtm)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("Financial Leverage (Assets/Equity) - Current (LTM)");
            entity.Property(e => e.FirFiltersOfPriceChange)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("FIR_FiltersOfPriceChange");
            entity.Property(e => e.FirHamming)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("FIR_Hamming");
            entity.Property(e => e.FirHann)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("FIR_Hann");
            entity.Property(e => e.FirTriangleWeighting)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("FIR_TriangleWeighting");
            entity.Property(e => e.FisherTransform).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.FiveDayChg)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("Five_Day_Chg");
            entity.Property(e => e.FixedChargeCoverageRatioCurrentLtm)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("Fixed Charge Coverage Ratio - Current (LTM)");
            entity.Property(e => e.FmDemodulator)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("FM_Demodulator");
            entity.Property(e => e.FmDemodulator2)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("FM_Demodulator2");
            entity.Property(e => e.ForceIndex).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.ForecastOscillator).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.FourPercentModel).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.FourierSeriesIndicator).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.FreeCashFlowPerShareCurrentLtm)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("Free Cash Flow Per Share - Current (LTM)");
            entity.Property(e => e.FreedomOfMovement).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.FrontExpectedMove)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Front Expected Move");
            entity.Property(e => e.FrontVol)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("Front Vol");
            entity.Property(e => e.FwCciAdvanced)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("FW_CCI_Advanced");
            entity.Property(e => e.FwCciBasic)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("FW_CCI_Basic");
            entity.Property(e => e.FwDpoMobo)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("FW_DPO_MOBO");
            entity.Property(e => e.FwFisherTransformer)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("FW_FisherTransformer");
            entity.Property(e => e.FwMmg)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("FW_MMG");
            entity.Property(e => e.FwMoboAdvanced)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("FW_MOBO_Advanced");
            entity.Property(e => e.FwMoboBasic)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("FW_MOBO_Basic");
            entity.Property(e => e.FwSoap)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("FW_SOAP");
            entity.Property(e => e.Gamma).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.GapMomentum).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.GatorOscillator).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.GrossProfitMarginCurrentLtm)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("Gross Profit Margin - Current (LTM)");
            entity.Property(e => e.Hacolt)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("HACOLT");
            entity.Property(e => e.HeikinAshiDiff).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.Hhlls)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("HHLLS");
            entity.Property(e => e.HiLoActivator).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.High).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.HighLowGraph)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("High/Low Graph");
            entity.Property(e => e.HistoricalVolatility).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.Hlvolatility)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("HLVolatility");
            entity.Property(e => e.HtbEtb)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("HTB/ETB");
            entity.Property(e => e.HullMovingAvg).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.HvPercentile)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("HV_Percentile");
            entity.Property(e => e.Ichimoku).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.IftStochOsc)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("IFT_StochOsc");
            entity.Property(e => e.ImpVolatility).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.ImplVol)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("Impl Vol");
            entity.Property(e => e.InTheMoney)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("% In The Money");
            entity.Property(e => e.Industry)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.Inertia).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.InitialMargin)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Initial Margin");
            entity.Property(e => e.InterestRateEstimatedAverageCurrentLtm)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("Interest Rate - Estimated Average - Current (LTM)");
            entity.Property(e => e.IntradayMomentumIndex).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.Intrinsic)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.InventoryTurnoverCurrentLtm)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("Inventory Turnover - Current (LTM)");
            entity.Property(e => e.IvPercentile)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("IV_Percentile");
            entity.Property(e => e.KeltnerChannels).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.KlingerHistogram).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.KlingerOscillator).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.Last).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.LastAnnualFilingDate)
                .HasColumnType("datetime")
                .HasColumnName("Last Annual Filing Date");
            entity.Property(e => e.LastInterimFilingDate)
                .HasColumnType("datetime")
                .HasColumnName("Last Interim Filing Date");
            entity.Property(e => e.LastSize)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("Last Size");
            entity.Property(e => e.LbrPaintBars).HasColumnName("LBR_PaintBars");
            entity.Property(e => e.LbrSmartAdx)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("LBR_SmartADX");
            entity.Property(e => e.LbrThreeTenOscillator)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("LBR_ThreeTenOscillator");
            entity.Property(e => e.LeavittConvolution).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.LeavittConvolutionAcceleration).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.LeavittConvolutionSlope).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.LegacyEma)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("LegacyEMA");
            entity.Property(e => e.LinearRegAdjEma)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("LinearRegAdjEMA");
            entity.Property(e => e.LinearRegCh100).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.LinearRegCh50).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.LinearRegChVar).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.LinearRegCurve).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.LinearRegTrendline).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.LinearRegrReversal).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.LinearRegressionSlope).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.LongTermDebtToCapitalCurrentLtm)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("Long-term Debt to Capital - Current (LTM)");
            entity.Property(e => e.LookUpHighest).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.LookUpLowest).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.Low).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.LowPriceGappingPlay).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.Lx)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("LX");
            entity.Property(e => e.Macd)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("MACD");
            entity.Property(e => e.Macdhistogram)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("MACDHistogram");
            entity.Property(e => e.MacdhistogramCrossover)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("MACDHistogramCrossover");
            entity.Property(e => e.MacdtwoLines)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("MACDTwoLines");
            entity.Property(e => e.MacdwithPrices)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("MACDWithPrices");
            entity.Property(e => e.Mad)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("MAD");
            entity.Property(e => e.Madh)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("MADH");
            entity.Property(e => e.MajorGannLevels).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.Mark).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.MarkChange)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("Mark %Change");
            entity.Property(e => e.MarkChange1)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("Mark Change");
            entity.Property(e => e.MarkOfUnderlyingValue)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("Mark % of underlying value");
            entity.Property(e => e.MarkerIndicator).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.MarketCap)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Market Cap");
            entity.Property(e => e.MarketCapCommonEquityRatioCurrent)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("Market Cap / Common Equity Ratio - Current");
            entity.Property(e => e.MarketCapnNew)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Market CapnNEW");
            entity.Property(e => e.MarketForecast).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.MarketMakerMove)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Market Maker Move");
            entity.Property(e => e.MarketSentiment).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.MassIndex).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.MaxCovReturn)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Max Cov Return");
            entity.Property(e => e.McClellanOscillator).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.McClellanSummationIndex).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.MedianAverage).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.MedianPrice).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.MeetingLines).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.MesasineWave)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("MESASineWave");
            entity.Property(e => e.MfPct)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("MF_pct");
            entity.Property(e => e.MiddleHighLowMa)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("MiddleHighLowMA");
            entity.Property(e => e.MktFacilitationIdx).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.ModifiedTrueRange).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.Momentum).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.MomentumPercent).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.MomentumPercentDiff).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.MomentumSma)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("MomentumSMA");
            entity.Property(e => e.MoneyFlow).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.MoneyFlowIndex).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.MoneyFlowIndexCrossover).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.MoneyFlowOscillator).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.MonkeyBars).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.MonthlySeasonality).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.MorningDojiStar).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.MorningStar).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.MovAvgAdaptive).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.MovAvgBandWidth).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.MovAvgBands).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.MovAvgEnvelope).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.MovAvgExpRibbon).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.MovAvgExponential).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.MovAvgTriangular).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.MovAvgTwoLines).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.MovAvgWeighted).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.MovingAvgCrossover).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.MultiCurrencyCorrelationOsc).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.MyRsiwithNet)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("MyRSIWithNET");
            entity.Property(e => e.NegativeVolumeIndex).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.NetChng)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("Net Chng");
            entity.Property(e => e.NetIncomeCurrent)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("Net Income - Current");
            entity.Property(e => e.NetLiq)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("Net Liq");
            entity.Property(e => e.NetProfitMarginCurrentLtm)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("Net Profit Margin - Current (LTM)");
            entity.Property(e => e.Next3rdFriday).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.OnBalanceVolume).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.OnBalanceVolumeModified).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.OnNeck).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.OneBlackCrow).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.OneHundredSmaPctChange)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("One_Hundred_SMA_pct_Change");
            entity.Property(e => e.OneMoChg)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("One_Mo_Chg");
            entity.Property(e => e.OneWhiteSoldier).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.OneYrChg)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("One_Yr_Chg");
            entity.Property(e => e.OnsetTrendDetector).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.Open).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.OpenInt)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("Open.Int");
            entity.Property(e => e.OpenInterest).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.OperatingProfitMarginCurrentLtm)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("Operating Profit Margin - Current (LTM)");
            entity.Property(e => e.OptionDelta).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.OptionGamma).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.OptionRho).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.OptionTheta).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.OptionVega).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.OutOfTheMoney)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("% Out Of The Money");
            entity.Property(e => e.PCRatio)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("P/C Ratio");
            entity.Property(e => e.PL)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("P/L %");
            entity.Property(e => e.PLDay)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("P/L Day");
            entity.Property(e => e.PLOpen)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("P/L Open");
            entity.Property(e => e.PLYear)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("P/L Year");
            entity.Property(e => e.PairCorrelation).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.PairRatio).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.ParabolicSar)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("ParabolicSAR");
            entity.Property(e => e.ParabolicSarcrossover)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("ParabolicSARCrossover");
            entity.Property(e => e.Pct1MoChg)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("pct_1_Mo_Chg");
            entity.Property(e => e.Pct1YrChg)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("pct_1_Yr_Chg");
            entity.Property(e => e.Pct20DayChg)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("pct_20_Day_Chg");
            entity.Property(e => e.Pct5DayChg)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("pct_5_Day_Chg");
            entity.Property(e => e.Pct6MoChg)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("pct_6_Mo_Chg");
            entity.Property(e => e.PctChgFrom52wkHi)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("pct_Chg_from_52Wk_Hi");
            entity.Property(e => e.PctChgFrom52wkLo)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("pct_Chg_from_52Wk_Lo");
            entity.Property(e => e.PctChgOpen)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("pct_Chg_Open");
            entity.Property(e => e.PctYtdChg)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("pct_YTD_Chg");
            entity.Property(e => e.Pe)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("PE");
            entity.Property(e => e.PercentChg).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.PercentR).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.PersonsPivots).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.PiercingLine).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.PivotPoints).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.Pmc)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("PMC");
            entity.Property(e => e.Pmo)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("PMO");
            entity.Property(e => e.PolarizedFractalEfficiency).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.PolychromMtm).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.PosQty)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("Pos Qty");
            entity.Property(e => e.PositiveVolumeIndex).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.Pps)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("PPS");
            entity.Property(e => e.PriceActionIndicator).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.PriceAndVolumeTrend).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.PriceAverageCrossover).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.PriceBookValueRatioCurrent)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("Price / Book Value Ratio - Current");
            entity.Property(e => e.PriceCashFlowRatioCurrent)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("Price / Cash Flow Ratio - Current");
            entity.Property(e => e.PriceChannel).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.PriceEarningsRatioCurrent)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("Price / Earnings Ratio - Current");
            entity.Property(e => e.PriceOsc).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.PriceRatio).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.PriceTimeFilteringAccVolume).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.PriceTimeFilteringBarCount).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.PriceVolumeRank).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.PriceZoneOscillator).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.ProbItm)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("Prob.ITM");
            entity.Property(e => e.ProbOtm)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("Prob.OTM");
            entity.Property(e => e.ProbTouch)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("Prob.Touch");
            entity.Property(e => e.ProjectionBands).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.ProjectionOscillator).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.PutSizzleIndex)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("Put Sizzle Index");
            entity.Property(e => e.Qstick)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("QStick");
            entity.Property(e => e.QuickRatioCurrentLtm)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("Quick Ratio - Current (LTM)");
            entity.Property(e => e.RainbowAverage).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.RandomWalkIndex).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.RangeBands).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.RangeIndicator).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.RateOfChange).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.RateOfChangeCrossover).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.RateOfChangeWithBands).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.Ray).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.RayBearPower).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.RayBullPower).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.Rdoc)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("RDOC");
            entity.Property(e => e.RecursiveMedianFilter).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.RecursiveMedianOscillator).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.Reflex).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.RegressionDivergence).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.RelativeMomentumIndex).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.RelativeRangeIndex).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.RelativeStrength).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.RelativeVolatilityIndex).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.RelativeVolumeStDev).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.ReturnOnAssetsRoaCurrentLtm)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("Return on Assets (ROA) - Current (LTM)");
            entity.Property(e => e.ReturnOnEquityRoeCurrentLtm)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("Return on Equity (ROE) - Current (LTM)");
            entity.Property(e => e.RevenueCurrent)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("Revenue - Current");
            entity.Property(e => e.ReverseEma)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("ReverseEMA");
            entity.Property(e => e.ReverseEngineeringMacd)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("ReverseEngineeringMACD");
            entity.Property(e => e.ReverseEngineeringRsi)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("ReverseEngineeringRSI");
            entity.Property(e => e.Rho).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.RibbonStudy).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.RisingThreeMethods).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.Roc)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("ROC");
            entity.Property(e => e.RocketRsi)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("RocketRSI");
            entity.Property(e => e.Ror)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("ROR");
            entity.Property(e => e.RsVaEma)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("RS_VA_EMA");
            entity.Property(e => e.Rsi)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("RSI");
            entity.Property(e => e.RsiColorized)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("RSI_Colorized");
            entity.Property(e => e.Rsicrossover)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("RSICrossover");
            entity.Property(e => e.Rsih)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("RSIH");
            entity.Property(e => e.Rsmk)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("RSMK");
            entity.Property(e => e.Rsquared)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("RSquared");
            entity.Property(e => e.SalesPerShareCurrentLtm)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("Sales Per Share - Current (LTM)");
            entity.Property(e => e.SchaffTrendCycle).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.Sector)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.SectorRotationModel)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.SemiCupFormation).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.SentimentZoneOscillator).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.SeparatingLines).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.SequenceCounter).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.SeriesCount).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.Shares).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.ShootingStar).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.ShortSaleBorrowingRate)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("Short Sale Borrowing Rate(%)");
            entity.Property(e => e.SideBySideWhiteLines).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.SimpleMovingAvg).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.SimpleTrendChannelFilter).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.SixMoChg)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("Six_Mo_Chg");
            entity.Property(e => e.Size)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.SizzleIndex)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("Sizzle Index");
            entity.Property(e => e.SlowRsi)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("SlowRSI");
            entity.Property(e => e.SlowVsi)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("SlowVSI");
            entity.Property(e => e.SoftAndHardLimiterComparison).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.Spearman).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.SpectrumBars).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.Spreads).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.StandardDevChannel).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.StandardDeviation).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.StandardError).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.StandardErrorBands).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.StandardErrorChannel).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.Starcbands)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("STARCBands");
            entity.Property(e => e.StickSandwich).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.Stiffness).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.StochRsi)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("StochRSI");
            entity.Property(e => e.StochasticCrossover).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.StochasticFast).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.StochasticFull).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.StochasticFullDiff).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.StochasticMacd)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("StochasticMACD");
            entity.Property(e => e.StochasticMomentumIndex).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.StochasticSlow).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.StressIndicator).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.SubIndustry)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Sub-Industry");
            entity.Property(e => e.SuperPassbandFilter).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.Svepivots)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("SVEPivots");
            entity.Property(e => e.SvestochRsi)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("SVEStochRSI");
            entity.Property(e => e.SvezlrbpercB)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("SVEZLRBPercB");
            entity.Property(e => e.SwamiAccDist).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.SwamiConvolution).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.SwamiIntradayFisher).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.SwamiIntradayImpulse).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.SwamiIntradayVolume).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.SwamiLaguerreTrend).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.SwamiMarketMode).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.SwamiPredict).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.SwamiRelativePerformance).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.SwamiSwingWave).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.SwamiVolatility).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.SwamiVolume).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.SwingIndex).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.Symbol)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.SymbolRelation).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.TacAdx)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("TAC_ADX");
            entity.Property(e => e.TacDiminus)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("TAC_DIMinus");
            entity.Property(e => e.TacDiplus)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("TAC_DIPlus");
            entity.Property(e => e.TaxRateCurrentLtm)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("Tax Rate - Current (LTM)");
            entity.Property(e => e.TechnicalStockRating).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.Tema)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("TEMA");
            entity.Property(e => e.TheoPrice)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("Theo Price");
            entity.Property(e => e.TheoreticalOptionPrice).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.Theta).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.ThreeBlackCrows).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.ThreeInsideDown).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.ThreeInsideUp).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.ThreeLineStrike).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.ThreeOutsideDown).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.ThreeOutsideUp).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.ThreeStarsInTheSouth).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.ThreeWhiteSoldiers).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.Thrusting).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.TickSize)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("Tick Size");
            entity.Property(e => e.TickValue)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("Tick Value");
            entity.Property(e => e.TimeSeriesForecast).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.Tmv)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("TMV");
            entity.Property(e => e.TotalAssetTurnoverCurrentLtm)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("Total Asset Turnover - Current (LTM)");
            entity.Property(e => e.TotalCost)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("Total Cost");
            entity.Property(e => e.Tpoprofile)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("TPOProfile");
            entity.Property(e => e.TradeVolumeIndex).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.TrendNoiseBalance).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.TrendPeriods).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.TrendPersistenceRate).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.TrendQuality).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.Trendflex).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.TriStar).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.Trix)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("TRIX");
            entity.Property(e => e.TrueRangeAdjEma)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("TrueRangeAdjEMA");
            entity.Property(e => e.TrueRangeIndicator).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.TrueRangeSpecifiedVolume).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.TrueStrengthIndex).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.TtmLrc)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("TTM_LRC");
            entity.Property(e => e.TtmScalperAlert)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("TTM_ScalperAlert");
            entity.Property(e => e.TtmSqueeze)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("TTM_Squeeze");
            entity.Property(e => e.TtmTrend)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("TTM_Trend");
            entity.Property(e => e.TtmWave)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("TTM_Wave");
            entity.Property(e => e.TwentyDayChg)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("Twenty_Day_Chg");
            entity.Property(e => e.TwentySmaPctChange)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("Twenty_SMA_pct_Change");
            entity.Property(e => e.TwoCrows).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.TwoHundredSmaPctChange)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("Two_Hundred_SMA_pct_Change");
            entity.Property(e => e.TypicalPrice).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.UlcerIndex).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.UltimateOscillator).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.UnderlyingLast)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("Underlying_Last");
            entity.Property(e => e.UndersampledDoubleMovAvg).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.UniqueThreeRiverBottom).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.UniversalOscillator).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.UpsideGapThreeMethods).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.UpsideGapTwoCrows).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.UpsideTasukiGap).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.VariableMa)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("VariableMA");
            entity.Property(e => e.Vega).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.VerticalHorizontalFilter).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.VolDiff)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("Vol Diff");
            entity.Property(e => e.VolIndex)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("Vol Index");
            entity.Property(e => e.VolSizzle).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.VolatilityStdDev).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.VolatilitySwitch).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.Volume).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.VolumeAccumulation).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.VolumeAvg).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.VolumeFlowIndicator).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.VolumeOsc).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.VolumeProfile).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.VolumeRateOfChange).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.VolumeWeightedMacd)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("VolumeWeightedMACD");
            entity.Property(e => e.VolumeZoneOscillator).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.VortexIndicator).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.VossPredictiveFilter).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.Vpnindicator)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("VPNIndicator");
            entity.Property(e => e.Vwap)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("VWAP");
            entity.Property(e => e.WarningSymbols).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.WeaknessInAstrongTrend)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("WeaknessInAStrongTrend");
            entity.Property(e => e.WeeklyAndDailyMacd)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("WeeklyAndDailyMACD");
            entity.Property(e => e.WeeklyAndDailyPpo)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("WeeklyAndDailyPPO");
            entity.Property(e => e.WeightedBackVol)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("Weighted Back Vol");
            entity.Property(e => e.WeightedClose).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.WildersSmoothing).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.WilliamsAd)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("WilliamsAD");
            entity.Property(e => e.WilliamsAlligator).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.WilliamsFractal).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.WilliamsPercentR).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.WoodiesPivots).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.YearlyRelativeRange).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.Yield).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.YtdChg)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("YTD_Chg");
            entity.Property(e => e.ZigZagHighLow).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.ZigZagPercent).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.ZigZagSign).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.ZigZagStepPattern).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.ZigZagTrendPercent).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.ZigZagTrendSign).HasColumnType("decimal(18, 4)");
            entity.Property(e => e._168h56dSocialActivityRatio)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("168h/56d Social Activity Ratio");
            entity.Property(e => e._168hMavgMentionsCount)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("168h_mavg Mentions Count");
            entity.Property(e => e._1dCountMentionsCount)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("1d_count Mentions Count");
            entity.Property(e => e._1h168hSocialActivityRatio)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("1h/168h Social Activity Ratio");
            entity.Property(e => e._1hCountMentionsCount)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("1h_count Mentions Count");
            entity.Property(e => e._24h168hSocialActivityRatio)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("24h/168h Social Activity Ratio");
            entity.Property(e => e._24h56dSocialActivityRatio)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("24h/56d Social Activity Ratio");
            entity.Property(e => e._52high)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("52High");
            entity.Property(e => e._52low)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("52Low");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
