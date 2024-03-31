using Microsoft.Extensions.Logging;
using Triton.Api.Contracts;

namespace Triton.Api.Business
{
    public class PurchaseOrderManager(ILogger<PurchaseOrderManager> logger) : IPurchaseOrderManager
    {
        public async Task<PurchaseOrder?> CreatePurchaseOrder()
        {
            try
            {
                throw new NotImplementedException();
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "An error occured when creating purchase order!");
                return null;
            }
        }
    }
}
