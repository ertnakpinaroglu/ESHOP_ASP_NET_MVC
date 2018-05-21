using EShop.BusinessLayer.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EShop.EntitiesLayer.Entities;
using EShop.DataAccessLayer.UnitofWorkPattern;
using EShop.DataAccessLayer.DataAccess;

namespace EShop.BusinessLayer.Concreate
{
    public class CommentManager : ICommentServices
    {
        private IUnitOfWork unitOfWork;
        public CommentManager()
        {
            unitOfWork = new UnitOfWork(new E_Shop_Context());
        }
        public void AddComment(Comment comment)
        {
            if (comment != null)
            {
                unitOfWork.CommentRepository.AddEntity(comment);
                unitOfWork.Complete();
            }
        }
    }
}
