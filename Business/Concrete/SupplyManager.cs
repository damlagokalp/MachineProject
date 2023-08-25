using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class SupplyManager : ISupplyService
    {
        ISupplyDal _supplyDal;
        public SupplyManager(ISupplyDal supplyDal)
        {
            _supplyDal = supplyDal;
            
        }
        public IDataResult<List<Supply>> GetAll()
        {
            var result= new SuccessDataResult<List<Supply>>(_supplyDal.GetAll());
            return result;
        }

        public IResult SupplyTheMachine(Supply supply)
        {
            var supplyInfo=_supplyDal.Get(s=>s.Id==supply.Id && s.ReturnDate==default);
            if(supplyInfo==null)
            {
               _supplyDal.Add(supply);
                return new SuccessResult(supply.Id + " : Makine tedarik edildi ");

            }
            else
            {
                return new  ErrorResult(supply.Id + " : Makine tedarik edilemedi");
            }
        }
    }
}
