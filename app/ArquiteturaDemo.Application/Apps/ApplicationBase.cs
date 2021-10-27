using ArquiteturaDemo.Domain.Interfaces;
using Microsoft.Practices.ServiceLocation;

namespace ArquiteturaDemo.Application
{
    public class ApplicationBase
    {
        private IUnitOfWork _unitOfWork;

        public void BeginTrasanction()
        {
            _unitOfWork = ServiceLocator.Current.GetInstance<IUnitOfWork>();

            _unitOfWork.BeginTransaction();
        }

        public void Commit()
        {
            _unitOfWork.Commit();
        }
    }
}
