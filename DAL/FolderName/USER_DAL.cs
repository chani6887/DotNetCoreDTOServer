using DAL.FolderName;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AutoMapper;
using System.Threading.Tasks;
using context = DAL.FolderName.ChaniLebUserPermissionsDBGoodContext;
namespace DAL
{
    public class USER_DAL : ICRUD<UserDTO>
    {



        public int AddNew(UserDTO item)
        {
            try
            {
                using context ctx = new context();

                Mapper.Initialize(
                    cnf =>
                        cnf.CreateMap<UserDTO, User>().ReverseMap()
                    );
                User u = Mapper.Map<User>(item);

                ctx.Users.Add(u);
                ctx.SaveChanges();
                return item.UserId;
            }

            
            catch
            {
                throw new NotImplementedException();
            }
        }

        public int Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<UserDTO> GetAll()
        {
            throw new NotImplementedException();
        }

        public UserDTO GetItem(int id)
        {
            throw new NotImplementedException();
        }

        public List<UserDTO> GetItems()
        {
            throw new NotImplementedException();
        }

        public int Update(UserDTO item)
        {
            throw new NotImplementedException();
        }
    }
}
