using Triton.Api.Contracts;

namespace Triton.Api.Business
{
    public interface IPurchaseOrderManager
    {
        Task<PurchaseOrder?> CreatePurchaseOrder();
    }
}
