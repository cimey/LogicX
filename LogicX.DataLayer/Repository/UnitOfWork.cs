using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace LogicX.DataLayer.Repository
{
    public class UnitOfWork : IUnitOfWork
    {

        private TransactionScope _transactionScope;
        private bool _isDisposed;
        private LogicXContext _dbContext;

        /// context should be set with ioc container
        public UnitOfWork()
        {
            _dbContext = new LogicXContext();    
        }

        public void Begin()
        {
            try
            {
                _transactionScope = new TransactionScope(
                    TransactionScopeOption.Required,
                    new TransactionOptions { IsolationLevel = IsolationLevel.ReadUncommitted });
            }
            catch
            {
                Dispose();
                throw;
            }
        }
        /// <summary>
        /// Saves changes to the DbContext.
        /// </summary>
        public void Save()
        {
            _dbContext.SaveChanges();
        }
        /// <summary>
        /// Calls Save() first then completes the TransactionScope.
        /// </summary>
        public void End()
        {
            try
            {
                this.Save();
                if (_transactionScope != null)
                    _transactionScope.Complete();
            }
            finally
            {
                Dispose();
            }
        }
        /// <summary>
        /// Disposes the TransactionScope if it has been started and then disposes itself.
        /// </summary>
        public void Cancel()
        {
            Dispose();
        }

        public void Dispose()
        {
            if (_isDisposed)
                return;

            _isDisposed = true;

            if (_transactionScope != null)
            {
                _transactionScope.Dispose();
                _transactionScope = null;
            }
            GC.SuppressFinalize(this);
        }
    }
}
