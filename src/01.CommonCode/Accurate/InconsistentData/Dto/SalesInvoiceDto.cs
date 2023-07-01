#nullable enable annotations

using System.Text.Json.Serialization;

namespace Exercise.CommonCode.Accurate.InconsistentData.Dto
{
    public class SalesInvoiceDto
    {
        public bool? s { get; set; }
        public D? d { get; set; }
    }

    public class D
    {
        [JsonInclude]
        public string? taxDateView { get; set; }
        public string? printUserName { get; private set; }
        public bool? reverseInvoice { get; private set; }
        public float? numericField10 { get; private set; }
        public object? reverseInvoiceStatus { get; private set; }
        public bool? receiveItem { get; private set; }
        public string? lastReturnDate { get; private set; }
        public int? currencyId { get; private set; }
        public bool? efakturProceed { get; private set; }
        public string? transDateView { get; private set; }
        public int? branchId { get; private set; }
        public int? tax1Id { get; private set; }
        public int? lastPaymentId { get; private set; }
        public bool? billOfMaterial { get; private set; }
        public object? taxNumber { get; private set; }
        public string? retailWpName { get; private set; }
        public float? tax1Amount { get; private set; }
        public bool? salesOrder { get; private set; }
        public int? commentCount { get; private set; }
        public bool? hasNPWP { get; private set; }
        public object? orderDownPayment { get; private set; }
        public float? taxableAmount2 { get; private set; }
        public float? taxableAmount1 { get; private set; }
        public string? lastCashDiscPercent { get; private set; }
        public float? taxableAmount4 { get; private set; }
        public object? poNumber { get; private set; }
        public string? charField10 { get; private set; }
        public bool? processStages { get; private set; }
        public int? journalId { get; private set; }
        public float? availableDownPayment { get; private set; }
        public float? taxReturn { get; private set; }
        public object? exchangeInvoiceId { get; private set; }
        public bool? customerClaim { get; private set; }
        public bool? journal { get; private set; }
        public bool? deliveryPacking { get; private set; }
        public int? customerId { get; private set; }
        public object? deliveryPackingId { get; private set; }
        public Currency? currency { get; private set; }
        public bool? vendorPrice { get; private set; }
        public int? paymentTermId { get; private set; }
        public bool? outstanding { get; private set; }
        public object? fobId { get; private set; }
        public bool? deliveryOrder { get; private set; }
        public string? efakturPdfFilePath { get; private set; }
        public float? taxReceipt { get; private set; }
        public bool? taxReported { get; private set; }
        public string? deliveryPackingNumber { get; private set; }
        public float? taxable1Total { get; private set; }
        public object[]? detailDownPayment { get; private set; }
        public string? dueDate { get; private set; }
        public bool? inclusiveTax { get; private set; }
        public float? taxableDiscount4 { get; private set; }
        public float? taxableDiscount2 { get; private set; }
        public float? taxableDiscount1 { get; private set; }
        public string? toAddress { get; private set; }
        public bool? rollOver { get; private set; }
        public string? retailIdCard { get; private set; }
        public float? taxOwing { get; private set; }
        public bool? itemAdjustment { get; private set; }
        public Taxreceipthistory[]? taxReceiptHistory { get; private set; }
        public bool? periodEnd { get; private set; }
        public bool? workOrder { get; private set; }
        public object? masterSalesmanId { get; private set; }
        public object? shipment { get; private set; }
        public string? invoiceTimeView { get; private set; }
        public object? sptMasaId { get; private set; }
        public float? primeReturn { get; private set; }
        public bool? salesQuotation { get; private set; }
        public bool? fixedAssetEdited { get; private set; }
        public object? fob { get; private set; }
        public float? taxDownPayment { get; private set; }
        public float? tax1AmountBase { get; private set; }
        public bool? canSelfPaidPph { get; private set; }
        public object? notesIdTax { get; private set; }
        public object? description { get; private set; }
        public bool? invoiceDp { get; private set; }
        public string? invoicePrintedTime { get; private set; }
        public float? rate { get; private set; }
        public object? efakturEmailTime { get; private set; }
        public string? lastPaymentDate { get; private set; }
        public string? transDate { get; private set; }
        public float? inputDownPayment { get; private set; }
        public float? cashDiscount { get; private set; }
        public float? primeReceipt { get; private set; }
        public float? primeDownPayment { get; private set; }
        public bool? salesReceipt { get; private set; }
        public string? approvalStatus { get; private set; }
        public object? tax2Id { get; private set; }
        public bool? materialSlip { get; private set; }
        public bool? sellingPriceAdjustment { get; private set; }
        public object? downPaymentAccountId { get; private set; }
        public float? taxDownPayment2 { get; private set; }
        public float? suggestedDiscount { get; private set; }
        public float? taxDownPayment1 { get; private set; }
        public float? numericField9 { get; private set; }
        public float? numericField8 { get; private set; }
        public float? numericField7 { get; private set; }
        public int? createdBy { get; private set; }
        public object? shipmentId { get; private set; }
        public float? numericField6 { get; private set; }
        public float? numericField5 { get; private set; }
        public float? numericField4 { get; private set; }
        public bool? purchaseOrder { get; private set; }
        public float? numericField3 { get; private set; }
        public float? salesAmountBase { get; private set; }
        public float? numericField2 { get; private set; }
        public float? numericField1 { get; private set; }
        public object? userPrinted { get; private set; }
        public int? age { get; private set; }
        public string? charField8 { get; private set; }
        public string? charField9 { get; private set; }
        public string? invoiceTime { get; private set; }
        public float? tax4Amount { get; private set; }
        public string? charField6 { get; private set; }
        public float? tax1Rate { get; private set; }
        public string? charField7 { get; private set; }
        public string? charField4 { get; private set; }
        public string? charField5 { get; private set; }
        public int? optLock { get; private set; }
        public float? percentTaxable { get; private set; }
        public object? reversePercentShipped { get; private set; }
        public int? arAccountId { get; private set; }
        public object[]? returnHistory { get; private set; }
        public string? number { get; private set; }
        public string? printedTime { get; private set; }
        public float? taxable2Total { get; private set; }
        public string? charField2 { get; private set; }
        public string? charField3 { get; private set; }
        public string? dueDateView { get; private set; }
        public string? charField1 { get; private set; }
        public int? id { get; private set; }
        public string? lastPaymentDateView { get; private set; }
        public string? taxType { get; private set; }
        public bool? hasStatusHistory { get; private set; }
        public object? dateField2 { get; private set; }
        public object? dateField1 { get; private set; }
        public bool? taxable { get; private set; }
        public bool? customerHasDownPayment { get; private set; }
        public bool? salesInvoice { get; private set; }
        public bool? purchaseInvoice { get; private set; }
        public string? shipDate { get; private set; }
        public bool? hasExchangeInvoice { get; private set; }
        public float? uniqueAmount { get; private set; }
        public object[]? detailExpense { get; private set; }
        public Detailitem[]? detailItem { get; private set; }
        public bool? employeePayment { get; private set; }
        public bool? expenseAccrual { get; private set; }
        public bool? salesReturn { get; private set; }
        public string? status { get; private set; }
        public object? lastTaxPaymentDate { get; private set; }
        public bool? bankTransfer { get; private set; }
        public object[]? deliveryOrderHistory { get; private set; }
        public bool? jobOrder { get; private set; }
        public string? statusOutstanding { get; private set; }
        public float? salesAmount { get; private set; }
        public float? downPaymentUsed { get; private set; }
        public string? statusName { get; private set; }
        public float? primeOwing { get; private set; }
        public float? tax2AmountBase { get; private set; }
        public float? tax4Rate { get; private set; }
        public object? tax4Id { get; private set; }
        public object? efakturFileName { get; private set; }
        public string? taxDate { get; private set; }
        public object? approvalTypeNumberId { get; private set; }
        public bool? canDelivery { get; private set; }
        public bool? purchaseReturn { get; private set; }
        public float? totalExpense { get; private set; }
        public string? documentCode { get; private set; }
        public bool? stockOpnameResult { get; private set; }
        public object? exchangeInvoice { get; private set; }
        public float? subTotal { get; private set; }
        public float? lastCashDiscount { get; private set; }
        public bool? manufactureOrder { get; private set; }
        public object? exchangeInvoiceDueDate { get; private set; }
        public float? tax2Rate { get; private set; }
        public bool? openingBalance { get; private set; }
        public float? fiscalRate { get; private set; }
        public object? orderDownPaymentId { get; private set; }
        public bool? paymentWithUniqueAmount { get; private set; }
        public bool? assetTransfer { get; private set; }
        public object? recurringDetailId { get; private set; }
        public float? tax4AmountBase { get; private set; }
        public float? totalAmountWithUniqueAmount { get; private set; }
        public bool? stockOpnameOrder { get; private set; }
        public object? exchangeInvoiceNumber { get; private set; }
        public float? totalAmount { get; private set; }
        public int? hourTime { get; private set; }
        public string? shipDateView { get; private set; }
        public object? manualApprovalNumber { get; private set; }
        public bool? purchaseRequisition { get; private set; }
        public Paymentterm? paymentTerm { get; private set; }
        public bool? noneInvoiceReturn { get; private set; }
        public float? dppAmount { get; private set; }
        public bool? finishedGoodSlip { get; private set; }
        public float? tax2Amount { get; private set; }
        public bool? purchasePayment { get; private set; }
        public bool? snRequired { get; private set; }
        public bool? otherDeposit { get; private set; }
        public bool? otherPayment { get; private set; }
        public Receipthistory[]? receiptHistory { get; private set; }
        public Tax1? tax1 { get; private set; }
        public bool? costDistribution { get; private set; }
        public object? tax2 { get; private set; }
        public bool? itemTransfer { get; private set; }
        public bool? vendorClaim { get; private set; }
        public float? tax3Amount { get; private set; }
        public object? tax4 { get; private set; }
        public string? cashDiscPercent { get; private set; }
        public object? efakturEmailUserId { get; private set; }
        public bool? hasDeliveryPacking { get; private set; }
        public string? branchName { get; private set; }
        public bool? materialAdjustment { get; private set; }
        public float? totalDownPayment { get; private set; }
        public bool? fixedAsset { get; private set; }
        public int? attachmentCount { get; private set; }
        public bool? standardProductCost { get; private set; }
        public Araccount? arAccount { get; private set; }
        public Customer? customer { get; private set; }
        public string? reverseInvoiceStatusName { get; private set; }
        public Detailtax[]? detailTax { get; private set; }
    }

    public class Currency
    {
        public int? defaultArAccountId { get; private set; }
        public string? symbol { get; private set; }
        public string? code { get; private set; }
        public int? defaultSalesDiscAccountId { get; private set; }
        public int? optLock { get; private set; }
        public string? currencyConverterType { get; private set; }
        public int? defaultAdvSalesAccountId { get; private set; }
        public int? defaultAdvPurchaseAccountId { get; private set; }
        public int? defaultRealizeGlAccountId { get; private set; }
        public string? name { get; private set; }
        public string? codeSymbol { get; private set; }
        public int? id { get; private set; }
        public int? defaultApAccountId { get; private set; }
        public int? defaultUnrealizeGlAccountId { get; private set; }
    }

    public class Paymentterm
    {
        public bool? cashOnDelivery { get; private set; }
        public int? optLock { get; private set; }
        public int? discDays { get; private set; }
        public string? name { get; private set; }
        public bool? defaultTerm { get; private set; }
        public object? memo { get; private set; }
        public float? discPC { get; private set; }
        public int? id { get; private set; }
        public int? netDays { get; private set; }
        public bool? manualTerm { get; private set; }
    }

    public class Tax1
    {
        public object? pphPs4Type { get; private set; }
        public int? purchaseTaxGlAccountId { get; private set; }
        public float? rate { get; private set; }
        public object? pph23Type { get; private set; }
        public int? optLock { get; private set; }
        public int? salesTaxGlAccountId { get; private set; }
        public string? description { get; private set; }
        public object? pph15Type { get; private set; }
        public int? id { get; private set; }
        public string? taxType { get; private set; }
        public string? taxInfo { get; private set; }
    }

    public class Araccount
    {
        public string? no { get; private set; }
        public bool? sub { get; private set; }
        public Parent? parent { get; private set; }
        public int? lvl { get; private set; }
        public string? accountType { get; private set; }
        public int? optLock { get; private set; }
        public object? memo { get; private set; }
        public string? accountTypeName { get; private set; }
        public string? nameWithIndent { get; private set; }
        public bool? suspended { get; private set; }
        public object? autoNumberTransactionId { get; private set; }
        public string? nameWithIndentStrip { get; private set; }
        public bool? fiscal { get; private set; }
        public string? noWithIndent { get; private set; }
        public string? name { get; private set; }
        public int? id { get; private set; }
        public int? currencyId { get; private set; }
    }

    public class Parent
    {
        public string? no { get; private set; }
        public bool? sub { get; private set; }
        public Parent1? parent { get; private set; }
        public int? lvl { get; private set; }
        public string? accountType { get; private set; }
        public int? optLock { get; private set; }
        public object? memo { get; private set; }
        public string? accountTypeName { get; private set; }
        public string? nameWithIndent { get; private set; }
        public bool? suspended { get; private set; }
        public object? autoNumberTransactionId { get; private set; }
        public string? nameWithIndentStrip { get; private set; }
        public bool? fiscal { get; private set; }
        public string? noWithIndent { get; private set; }
        public string? name { get; private set; }
        public int? id { get; private set; }
        public int? currencyId { get; private set; }
    }

    public class Parent1
    {
        public object? no { get; private set; }
        public bool? sub { get; private set; }
        public object? parent { get; private set; }
        public int? lvl { get; private set; }
        public object? accountType { get; private set; }
        public int? optLock { get; private set; }
        public object? memo { get; private set; }
        public string? accountTypeName { get; private set; }
        public string? nameWithIndent { get; private set; }
        public bool? suspended { get; private set; }
        public object? autoNumberTransactionId { get; private set; }
        public string? nameWithIndentStrip { get; private set; }
        public bool? fiscal { get; private set; }
        public string? noWithIndent { get; private set; }
        public string? name { get; private set; }
        public int? id { get; private set; }
        public object? currencyId { get; private set; }
    }

    public class Customer
    {
        public string? documentCode { get; private set; }
        public bool? consignmentStore { get; private set; }
        public object? charField8 { get; private set; }
        public float? customerLimitAmountValue { get; private set; }
        public object? charField9 { get; private set; }
        public object? charField6 { get; private set; }
        public object? charField7 { get; private set; }
        public object? numericField10 { get; private set; }
        public object? idCard { get; private set; }
        public object? charField4 { get; private set; }
        public object? charField5 { get; private set; }
        public int? optLock { get; private set; }
        public Lastbank? lastBank { get; private set; }
        public bool? customerLimitAge { get; private set; }
        public bool? defaultIncTax { get; private set; }
        public object? charField2 { get; private set; }
        public object? charField3 { get; private set; }
        public object? charField1 { get; private set; }
        public int? id { get; private set; }
        public object? salesman3Id { get; private set; }
        public int? currencyId { get; private set; }
        public object? salesman5Id { get; private set; }
        public object? dateField2 { get; private set; }
        public object? branchId { get; private set; }
        public bool? shipSameAsBill { get; private set; }
        public object? dateField1 { get; private set; }
        public int? defaultTermId { get; private set; }
        public object? pkpNo { get; private set; }
        public object? npwpNo { get; private set; }
        public bool? suspended { get; private set; }
        public object? warehouseId { get; private set; }
        public string? name { get; private set; }
        public object[]? shipAddressList { get; private set; }
        public object? salesman { get; private set; }
        public object? defaultInvoiceDesc { get; private set; }
        public object? charField10 { get; private set; }
        public object? notesIdTax { get; private set; }
        public int? shipAddressId { get; private set; }
        public string? wpName { get; private set; }
        public string? customerTaxType { get; private set; }
        public object? salesman4Id { get; private set; }
        public bool? taxSameAsBill { get; private set; }
        public object? customerLimitAgeValue { get; private set; }
        public int? taxAddressId { get; private set; }
        public object? salesman2Id { get; private set; }
        public object? defaultSalesmanId { get; private set; }
        public int? priceCategoryId { get; private set; }
        public int? billAddressId { get; private set; }
        public Shipaddress? shipAddress { get; private set; }
        public object? numericField9 { get; private set; }
        public object? defaultSalesDisc { get; private set; }
        public object? numericField8 { get; private set; }
        public object? numericField7 { get; private set; }
        public object? numericField6 { get; private set; }
        public object? numericField5 { get; private set; }
        public object? numericField4 { get; private set; }
        public object? efakturSendEmail { get; private set; }
        public object? numericField3 { get; private set; }
        public object? numericField2 { get; private set; }
        public object? numericField1 { get; private set; }
        public bool? customerLimitAmount { get; private set; }
        public string? customerNo { get; private set; }
        public int? discountCategoryId { get; private set; }
        public int? categoryId { get; private set; }
    }

    public class Lastbank
    {
        public string? no { get; private set; }
        public bool? sub { get; private set; }
        public Parent2? parent { get; private set; }
        public int? lvl { get; private set; }
        public string? accountType { get; private set; }
        public int? optLock { get; private set; }
        public object? memo { get; private set; }
        public string? accountTypeName { get; private set; }
        public string? nameWithIndent { get; private set; }
        public bool? suspended { get; private set; }
        public int? autoNumberTransactionId { get; private set; }
        public string? nameWithIndentStrip { get; private set; }
        public bool? fiscal { get; private set; }
        public string? noWithIndent { get; private set; }
        public string? name { get; private set; }
        public Currency1? currency { get; private set; }
        public int? id { get; private set; }
        public int? currencyId { get; private set; }
    }

    public class Parent2
    {
        public string? no { get; private set; }
        public bool? sub { get; private set; }
        public Parent3? parent { get; private set; }
        public int? lvl { get; private set; }
        public string? accountType { get; private set; }
        public int? optLock { get; private set; }
        public object? memo { get; private set; }
        public string? accountTypeName { get; private set; }
        public string? nameWithIndent { get; private set; }
        public bool? suspended { get; private set; }
        public int? autoNumberTransactionId { get; private set; }
        public string? nameWithIndentStrip { get; private set; }
        public bool? fiscal { get; private set; }
        public string? noWithIndent { get; private set; }
        public string? name { get; private set; }
        public int? id { get; private set; }
        public int? currencyId { get; private set; }
    }

    public class Parent3
    {
        public object? no { get; private set; }
        public bool? sub { get; private set; }
        public object? parent { get; private set; }
        public int? lvl { get; private set; }
        public object? accountType { get; private set; }
        public int? optLock { get; private set; }
        public object? memo { get; private set; }
        public string? accountTypeName { get; private set; }
        public string? nameWithIndent { get; private set; }
        public bool? suspended { get; private set; }
        public object? autoNumberTransactionId { get; private set; }
        public string? nameWithIndentStrip { get; private set; }
        public bool? fiscal { get; private set; }
        public string? noWithIndent { get; private set; }
        public string? name { get; private set; }
        public int? id { get; private set; }
        public object? currencyId { get; private set; }
    }

    public class Currency1
    {
        public int? defaultArAccountId { get; private set; }
        public string? symbol { get; private set; }
        public string? code { get; private set; }
        public int? defaultSalesDiscAccountId { get; private set; }
        public int? optLock { get; private set; }
        public string? currencyConverterType { get; private set; }
        public int? defaultAdvSalesAccountId { get; private set; }
        public int? defaultAdvPurchaseAccountId { get; private set; }
        public int? defaultRealizeGlAccountId { get; private set; }
        public string? name { get; private set; }
        public string? codeSymbol { get; private set; }
        public int? id { get; private set; }
        public int? defaultApAccountId { get; private set; }
        public int? defaultUnrealizeGlAccountId { get; private set; }
    }

    public class Shipaddress
    {
        public object? branchId { get; private set; }
        public string? zipCode { get; private set; }
        public string? country { get; private set; }
        public string? notes { get; private set; }
        public string? address { get; private set; }
        public string? city { get; private set; }
        public object? latitude { get; private set; }
        public int? optLock { get; private set; }
        public object? vendorId { get; private set; }
        public object? employeeId { get; private set; }
        public bool? suspended { get; private set; }
        public bool? taxLocation { get; private set; }
        public bool? deleted { get; private set; }
        public string? province { get; private set; }
        public object? warehouseId { get; private set; }
        public string? street { get; private set; }
        public int? customerId { get; private set; }
        public string? name { get; private set; }
        public string? concatFullAddress { get; private set; }
        public int? id { get; private set; }
        public object? projectId { get; private set; }
        public bool? headQuarter { get; private set; }
        public object? longitude { get; private set; }
    }

    public class Taxreceipthistory
    {
        public string? approvalStatus { get; private set; }
        public string? historyDate { get; private set; }
        public string? historyNumber { get; private set; }
        public float? historyAmount { get; private set; }
        public int? id { get; private set; }
    }

    public class Detailitem
    {
        public object? deliveryOrderDetailId { get; private set; }
        public string? lastItemDiscPercent { get; private set; }
        public object? charField8 { get; private set; }
        public float? returnQuantity { get; private set; }
        public object? charField9 { get; private set; }
        public string? processQuantityDesc { get; private set; }
        public object? charField6 { get; private set; }
        public object? charField7 { get; private set; }
        public float? numericField10 { get; private set; }
        public object? charField4 { get; private set; }
        public object? departmentId { get; private set; }
        public object? charField5 { get; private set; }
        public int? optLock { get; private set; }
        public Itemunit? itemUnit { get; private set; }
        public object[]? detailSerialNumber { get; private set; }
        public string? salesOrderPoNumber { get; private set; }
        public object? charField2 { get; private set; }
        public object? charField3 { get; private set; }
        public float? reverseInvoiceUnitCost { get; private set; }
        public int? salesOrderDetailId { get; private set; }
        public object? charField1 { get; private set; }
        public int? id { get; private set; }
        public object? salesman3Id { get; private set; }
        public object? dataClassification6Id { get; private set; }
        public object? salesQuotationDetailId { get; private set; }
        public decimal? unitPrice { get; private set; }
        public bool? useTax1 { get; private set; }
        public object? dateField2 { get; private set; }
        public object? dataClassification1 { get; private set; }
        public string? salesmanName { get; private set; }
        public int? branchId { get; private set; }
        public bool? useTax3 { get; private set; }
        public object? dataClassification3 { get; private set; }
        public Item? item { get; private set; }
        public bool? useTax2 { get; private set; }
        public object? dataClassification1Id { get; private set; }
        public object? dateField1 { get; private set; }
        public object? dataClassification2 { get; private set; }
        public object? dataClassification5 { get; private set; }
        public object? dataClassification4 { get; private set; }
        public object? dataClassification7 { get; private set; }
        public object? dataClassification6 { get; private set; }
        public object? dataClassification9 { get; private set; }
        public object? dataClassification8 { get; private set; }
        public float? tax1Amount { get; private set; }
        public object? detailNotes { get; private set; }
        public Warehouse? warehouse { get; private set; }
        public Salesorder? salesOrder { get; private set; }
        public int? itemId { get; private set; }
        public int? warehouseId { get; private set; }
        public object? charField15 { get; private set; }
        public object? charField13 { get; private set; }
        public object? charField14 { get; private set; }
        public object? charField11 { get; private set; }
        public object? charField12 { get; private set; }
        public bool? useTax4 { get; private set; }
        public object? charField10 { get; private set; }
        public object? dataClassification10 { get; private set; }
        public string? detailName { get; private set; }
        public decimal? lastItemCashDiscount { get; private set; }
        public decimal? totalPrice { get; private set; }
        public int? salesInvoiceId { get; private set; }
        public object? groupSeq { get; private set; }
        public float? salesAmount { get; private set; }
        public object? dataClassification7Id { get; private set; }
        public int? seq { get; private set; }
        public object? dataClassification2Id { get; private set; }
        public object? salesman2Id { get; private set; }
        public Salesorderdetail? salesOrderDetail { get; private set; }
        public int? salesOrderId { get; private set; }
        public object? project { get; private set; }
        public float? deliveredQuantity { get; private set; }
        public float? quantityDefault { get; private set; }
        public string? itemDiscPercent { get; private set; }
        public object? dataClassification8Id { get; private set; }
        public object? salesQuotationId { get; private set; }
        public object? salesman5Id { get; private set; }
        public object? deliveryOrderId { get; private set; }
        public object? dataClassification3Id { get; private set; }
        public object? salesman1Id { get; private set; }
        public object? tax3Id { get; private set; }
        public float? controlQuantity { get; private set; }
        public float? grossAmount { get; private set; }
        public object? projectId { get; private set; }
        public float? dppAmount { get; private set; }
        public float? tax2Amount { get; private set; }
        public object? dataClassification10Id { get; private set; }
        public float? itemCashDiscount { get; private set; }
        public object? dataClassification9Id { get; private set; }
        public object[]? salesmanList { get; private set; }
        public object? department { get; private set; }
        public object? salesman4Id { get; private set; }
        public object? tax3 { get; private set; }
        public string? detailTaxName { get; private set; }
        public object? dataClassification5Id { get; private set; }
        public object? dataClassification4Id { get; private set; }
        public float? quantity { get; private set; }
        public string? totalCaptionSerialNumber { get; private set; }
        public object[]? detailItemImage { get; private set; }
        public float? numericField9 { get; private set; }
        public float? numericField8 { get; private set; }
        public float? numericField7 { get; private set; }
        public float? numericField6 { get; private set; }
        public float? numericField5 { get; private set; }
        public string? deliveryOrderPoNumber { get; private set; }
        public float? numericField4 { get; private set; }
        public int? itemUnitId { get; private set; }
        public float? numericField3 { get; private set; }
        public float? salesAmountBase { get; private set; }
        public float? numericField2 { get; private set; }
        public int? itemHistoryId { get; private set; }
        public float? numericField1 { get; private set; }
        public float? unitRatio { get; private set; }
    }

    public class Itemunit
    {
        public int? optLock { get; private set; }
        public string? name { get; private set; }
        public int? id { get; private set; }
    }

    public class Item
    {
        public int? unit2Id { get; private set; }
        public object? charField8 { get; private set; }
        public object? charField9 { get; private set; }
        public object? charField6 { get; private set; }
        public object? charField7 { get; private set; }
        public object? numericField10 { get; private set; }
        public float? unit4Price { get; private set; }
        public object? charField4 { get; private set; }
        public object? charField5 { get; private set; }
        public int? optLock { get; private set; }
        public float? percentTaxable { get; private set; }
        public float? ratioVendorUnit { get; private set; }
        public float? unit3Price { get; private set; }
        public int? salesDiscountGlAccountId { get; private set; }
        public bool? itemProduced { get; private set; }
        public object? charField2 { get; private set; }
        public object? charField3 { get; private set; }
        public object? charField1 { get; private set; }
        public int? id { get; private set; }
        public float? unitPrice { get; private set; }
        public object? dateField2 { get; private set; }
        public object? branchId { get; private set; }
        public int? tax1Id { get; private set; }
        public object? dateField1 { get; private set; }
        public float? onSales { get; private set; }
        public float? unit5Price { get; private set; }
        public float? unit2Price { get; private set; }
        public bool? suspended { get; private set; }
        public int? goodTransitGlAccountId { get; private set; }
        public int? cogsGlAccountId { get; private set; }
        public object? referenceSubstitutionId { get; private set; }
        public object? itemSubstitutionId { get; private set; }
        public string? shortName { get; private set; }
        public object? charField10 { get; private set; }
        public int? unBilledGlAccountId { get; private set; }
        public float? dimWidth { get; private set; }
        public object? unit3Id { get; private set; }
        public int? salesRetGlAccountId { get; private set; }
        public float? dimDepth { get; private set; }
        public float? minimumQuantityReorder { get; private set; }
        public object? lockTime { get; private set; }
        public float? vendorPrice { get; private set; }
        public float? minimumQuantity { get; private set; }
        public object? tax4Id { get; private set; }
        public float? dimHeight { get; private set; }
        public object? unit4Id { get; private set; }
        public object? notes { get; private set; }
        public int? purchaseRetGlAccountId { get; private set; }
        public Unit1? unit1 { get; private set; }
        public object? variantParentId { get; private set; }
        public Unit2? unit2 { get; private set; }
        public object? unit3 { get; private set; }
        public Vendorunit? vendorUnit { get; private set; }
        public object? preferedVendorId { get; private set; }
        public float? ratio2 { get; private set; }
        public object? unit4 { get; private set; }
        public object? unit5 { get; private set; }
        public float? ratio4 { get; private set; }
        public float? ratio3 { get; private set; }
        public float? ratio5 { get; private set; }
        public object? tax3Id { get; private set; }
        public int? inventoryGlAccountId { get; private set; }
        public bool? controlQuantity { get; private set; }
        public object? weight { get; private set; }
        public object? upcNo { get; private set; }
        public object? variantLabel { get; private set; }
        public bool? substituted { get; private set; }
        public float? onOrder { get; private set; }
        public int? salesGlAccountId { get; private set; }
        public string? name { get; private set; }
        public float? deliveryLeadTime { get; private set; }
        public bool? manageExpired { get; private set; }
        public string? no { get; private set; }
        public string? itemType { get; private set; }
        public object? defaultDiscount { get; private set; }
        public int? unit1Id { get; private set; }
        public object? unit5Id { get; private set; }
        public int? itemCategoryId { get; private set; }
        public Tax11? tax1 { get; private set; }
        public object? tax2 { get; private set; }
        public bool? manageSN { get; private set; }
        public bool? materialProduced { get; private set; }
        public object? variantSeq { get; private set; }
        public object? tax3 { get; private set; }
        public object? tax4 { get; private set; }
        public object? serialNumberType { get; private set; }
        public object? tax2Id { get; private set; }
        public float? cost { get; private set; }
        public bool? printDetailGroup { get; private set; }
        public bool? calculateGroupPrice { get; private set; }
        public object? numericField9 { get; private set; }
        public float? defStandardCost { get; private set; }
        public object? numericField8 { get; private set; }
        public object? numericField7 { get; private set; }
        public object? numericField6 { get; private set; }
        public object? numericField5 { get; private set; }
        public object? numericField4 { get; private set; }
        public object? numericField3 { get; private set; }
        public object? numericField2 { get; private set; }
        public object? numericField1 { get; private set; }
        public int? vendorUnitId { get; private set; }
        public float? unit1Price { get; private set; }
    }

    public class Unit1
    {
        public int? optLock { get; private set; }
        public string? name { get; private set; }
        public int? id { get; private set; }
    }

    public class Unit2
    {
        public int? optLock { get; private set; }
        public string? name { get; private set; }
        public int? id { get; private set; }
    }

    public class Vendorunit
    {
        public int? optLock { get; private set; }
        public string? name { get; private set; }
        public int? id { get; private set; }
    }

    public class Tax11
    {
        public object? pphPs4Type { get; private set; }
        public int? purchaseTaxGlAccountId { get; private set; }
        public float? rate { get; private set; }
        public object? pph23Type { get; private set; }
        public int? optLock { get; private set; }
        public int? salesTaxGlAccountId { get; private set; }
        public string? description { get; private set; }
        public object? pph15Type { get; private set; }
        public int? id { get; private set; }
        public string? taxType { get; private set; }
        public string? taxInfo { get; private set; }
    }

    public class Warehouse
    {
        public bool? scrapWarehouse { get; private set; }
        public bool? defaultWarehouse { get; private set; }
        public int? locationId { get; private set; }
        public int? optLock { get; private set; }
        public string? name { get; private set; }
        public object? description { get; private set; }
        public object? pic { get; private set; }
        public int? id { get; private set; }
        public bool? suspended { get; private set; }
    }

    public class Salesorder
    {
        public string? number { get; private set; }
        public int? id { get; private set; }
    }

    public class Salesorderdetail
    {
        public int? id { get; private set; }
    }

    public class Receipthistory
    {
        public string? approvalStatus { get; private set; }
        public string? historyDate { get; private set; }
        public string? historyNumber { get; private set; }
        public float? historyAmount { get; private set; }
        public int? id { get; private set; }
        public bool? historyIsPPhPayment { get; private set; }
    }

    public class Detailtax
    {
        public float? taxableAmount { get; private set; }
        public int? transId { get; private set; }
        public int? optLock { get; private set; }
        public Tax? tax { get; private set; }
        public string? _status { get; private set; }
        public bool? hasPaid { get; private set; }
        public float? taxRate { get; private set; }
        public int? taxId { get; private set; }
        public string? taxDescription { get; private set; }
        public int? id { get; private set; }
        public float? taxAmount { get; private set; }
        public int? currencyId { get; private set; }
        public string? taxType { get; private set; }
    }

    public class Tax
    {
        public object? pphPs4Type { get; private set; }
        public int? purchaseTaxGlAccountId { get; private set; }
        public float? rate { get; private set; }
        public object? pph23Type { get; private set; }
        public int? optLock { get; private set; }
        public int? salesTaxGlAccountId { get; private set; }
        public string? description { get; private set; }
        public object? pph15Type { get; private set; }
        public int? id { get; private set; }
        public string? taxType { get; private set; }
        public string? taxInfo { get; private set; }
    }
}