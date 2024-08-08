using DAL;
using DAL.FolderName;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class USER_BL : ICRUD<UserDTO>
    {
        public int AddNew(UserDTO item)
        {
            return new USER_DAL().AddNew(item);
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
