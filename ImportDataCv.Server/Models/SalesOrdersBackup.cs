using System;
using System.Collections.Generic;

namespace ImportDataCv.Server.Models;

public partial class SalesOrdersBackup
{
    public string OrderId { get; set; } = null!;

    public string? OrderNumber { get; set; }

    public string? OrderDate { get; set; }

    public string? DeliveryDate { get; set; }

    public string? Status { get; set; }

    public string? StatusDescription { get; set; }

    public string? OrderQuantity { get; set; }

    public string? RemainingQuantity { get; set; }

    public string? Discount { get; set; }

    public string? UnitPrice { get; set; }

    public string? OrderAmount { get; set; }

    public string? PromoFlag { get; set; }

    public string? DriverName { get; set; }

    public string? VehicleCode { get; set; }

    public string? Receiver { get; set; }

    public string? Description { get; set; }

    public string? DeliveryCode { get; set; }

    public string? InvoiceNum { get; set; }

    public string? ConversionDate { get; set; }

    public string? ConversionRate { get; set; }

    public string? InvoiceStatus { get; set; }

    public string? BlanketNumber { get; set; }

    public string? ShipFromOrgId { get; set; }

    public string? ShipToOrgId { get; set; }

    public string? InvoiceToOrgId { get; set; }

    public string? InventoryItemId { get; set; }

    public string? TransportMethodId { get; set; }

    public string? TransactionTypeId { get; set; }

    public string? UserId { get; set; }

    public string? PriceListId { get; set; }

    public string? CustomerId { get; set; }

    public string? SourceDocumentLineId { get; set; }

    public DateTime? LastUpdateDate { get; set; }

    public string? LastUpdatedBy { get; set; }

    public string? CreationDate { get; set; }

    public string? CreatedBy { get; set; }

    public string? LastUpdateLogin { get; set; }

    public string? OrderedItem { get; set; }

    public string? CurrencyCode { get; set; }

    public string? UomCode { get; set; }

    public string? CheckpointId { get; set; }

    public string? OrderType { get; set; }

    public string? BlanketId { get; set; }

    public string? CheckFlag { get; set; }

    public string? ParentDeliveryCode { get; set; }

    public string? PromotionConfirm { get; set; }

    public string? SoFlag { get; set; }

    public string? CancelDeliveryCode { get; set; }

    public string? FreightAmount { get; set; }

    public string? ReceiveMethod { get; set; }

    public string? PackType { get; set; }

    public string? ReceiverId { get; set; }

    public string? BagType { get; set; }

    public string? NonWeightDeliveryId { get; set; }

    public string? OrderAmountOld { get; set; }

    public string? OrderQuantityOld { get; set; }

    public string? DiscountOld { get; set; }

    public string? TnnmSo { get; set; }

    public string? Msgh { get; set; }

    public string? IpFlag { get; set; }

    public string? VehicleWeightId { get; set; }

    public string? InterorgHeaderId { get; set; }

    public string? BsdId { get; set; }

    public string? DocNum { get; set; }

    public string? BookQuantity { get; set; }

    public string? InvoiceFlag { get; set; }

    public string? QuantityAvailable { get; set; }

    public string? DiscountAvailable { get; set; }

    public string? DocSeries { get; set; }

    public string? DocTemplate { get; set; }

    public string? LotNumber { get; set; }

    public string? PrintStatus { get; set; }

    public string? LocationCode { get; set; }

    public string? DriverInfo { get; set; }

    public string? ExCustomerId { get; set; }

    public string? ExUnitPrice { get; set; }

    public string? ShippointId { get; set; }

    public string? TaxAmount { get; set; }

    public string? TaxRate { get; set; }

    public string? DataSource { get; set; }

    public string? AreaId { get; set; }

    public string? MoocCode { get; set; }

    public string? BccStatus { get; set; }

    public string? OrderShift { get; set; }

    public string? OrderLog { get; set; }

    public string? OrderAdjustType { get; set; }

    public string? SyncFlag { get; set; }

    public string? BookDate { get; set; }

    public string? PrintDate { get; set; }

    public string? ProductionLine { get; set; }

    public string? BranchId { get; set; }

    public string? BagMachine { get; set; }
}
