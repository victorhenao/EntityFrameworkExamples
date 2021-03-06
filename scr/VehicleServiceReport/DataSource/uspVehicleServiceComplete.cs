//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace VehicleServiceReport.DataSource
{
    using System;
    
    public partial class uspVehicleServiceComplete
    {
        public int ServiceOrderId { get; set; }
        public System.DateTime RequestedDate { get; set; }
        public Nullable<System.DateTime> StartDate { get; set; }
        public Nullable<System.DateTime> EndDate { get; set; }
        public int VehicleFk { get; set; }
        public int ServiceOrderStatusFk { get; set; }
        public Nullable<int> InvoiceFk { get; set; }
        public int AutomotiveTechnicianLeadFk { get; set; }
        public int InvoiceId { get; set; }
        public string InvoiceNumber { get; set; }
        public int Taxes { get; set; }
        public int Value { get; set; }
        public System.DateTime InvoicingDate { get; set; }
        public int AutomotiveTechnicianLeadId { get; set; }
        public string Name { get; set; }
        public int ServiceOrderHistoryId { get; set; }
        public System.DateTime Date { get; set; }
        public Nullable<int> InitialStatusFK { get; set; }
        public int FinalStatusFk { get; set; }
        public int ServiceOrderFk { get; set; }
        public int VehicleId { get; set; }
        public string PlateNumber { get; set; }
        public Nullable<System.DateTime> LastServiceDate { get; set; }
        public int VehicleModelFk { get; set; }
        public int CustomerFk { get; set; }
        public int VehicleModelId { get; set; }
        public string Model { get; set; }
        public int VehicleBrandFk { get; set; }
        public int VehicleBrandId { get; set; }
        public string Brand { get; set; }
        public int CustomerId { get; set; }
        public string CustomerName { get; set; }
        public string Address { get; set; }
        public string PhoneNumer { get; set; }
        public int ServiceOrderCategoryId { get; set; }
        public string Comments { get; set; }
        public int CategoryFk { get; set; }
        public int ServiceOrderCategoryServieOrderFk { get; set; }
        public int ServiceOrderCategoryStatusFk { get; set; }
        public Nullable<int> AutomotiveTechnicianFk { get; set; }
        public int CategoryId { get; set; }
        public string Category { get; set; }
        public int AutomotiveTechnicianId { get; set; }
        public string TechnicianName { get; set; }
        public int ServiceOrderCategoryHistoryId { get; set; }
        public System.DateTime ServiceOrderCategoryHistoryDate { get; set; }
        public Nullable<int> ServiceOrderCategoryHistoryInitialStatusFk { get; set; }
        public int ServiceOrderCategoryHistoryFinalStatusFk { get; set; }
        public int ServiceOrderCategoryFk { get; set; }
        public int OrderCategoryDetailId { get; set; }
        public string OrderCategoryDetailComments { get; set; }
        public string Findings { get; set; }
        public System.DateTime OrderCategoryDetailStartDate { get; set; }
        public System.DateTime OrderCategoryDetailEndDate { get; set; }
        public int OrderCategoryDetailStatusFk { get; set; }
        public int OrderCategoryDetailServiceOrderCategoryFk { get; set; }
        public int OrderCategoryDetailHitoryId { get; set; }
        public System.DateTime OrderCategoryDetailHistoryDate { get; set; }
        public Nullable<int> OrderCategoryDetailHistoryInitialStatusFk { get; set; }
        public int OrderCategoryDetailHistoryFinalStatusFk { get; set; }
        public int OrderCategoryDetailFk { get; set; }
        public int PartManteinanceId { get; set; }
        public string SerialNumber { get; set; }
        public string PartManteinanceComments { get; set; }
        public int PartManteinanceOrderCatgoryDetailFk { get; set; }
        public int ParfFk { get; set; }
        public int PartReplacementId { get; set; }
        public string PartReplacementSerialNumber { get; set; }
        public string PartReplacementComments { get; set; }
        public int PartReplacementOrderCategoryDetalFk { get; set; }
        public int PartFk { get; set; }
        public int PartmanteinancePartId { get; set; }
        public string PartmanteinancePartName { get; set; }
        public int PartReplacementPartId { get; set; }
        public string PartReplacementPartName { get; set; }
        public string ManufacturerNameManteinance { get; set; }
        public string ManufacturerNameReplacement { get; set; }
    }
}
