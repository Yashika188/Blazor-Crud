using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace CrudAssignment.Data
{
    public class OperationService
    {
        #region Property
        private readonly AppDBContext _appDBContext;
        #endregion

        #region Constructor
        public OperationService(AppDBContext appDBContext)
        {
            _appDBContext = appDBContext;
        }
        #endregion

        #region Get List of Operations
        public async Task<List<Operation>> GetAllOperationsAsync()
        {
            return await _appDBContext.Operations.ToListAsync();
        }
        #endregion

        #region Insert Operation
        public async Task<bool> InsertOperationAsync(Operation insertOp)
        {
            await _appDBContext.Operations.AddAsync(insertOp);
            await _appDBContext.SaveChangesAsync();
            return true;
        }
        #endregion

        #region Get Operation by Id
        public async Task<Operation> GetOperationAsync(int Id)
        {
            Operation op = await _appDBContext.Operations.FirstOrDefaultAsync(c => c.OperationID.Equals(Id));
            return op;
        }
        #endregion

        #region Update Operation
        public async Task<bool> UpdateOperationAsync(Operation updateOp)
        {
            _appDBContext.Operations.Update(updateOp);
            await _appDBContext.SaveChangesAsync();
            return true;
        }
        #endregion

        #region DeleteOperation
        public async Task<bool> DeleteOperationAsync(Operation delOp)
        {
            _appDBContext.Remove(delOp);
            await _appDBContext.SaveChangesAsync();
            return true;
        }
        #endregion
    }
}