using System.Collections.Generic;

namespace ProjInherits_1.MultipleInherits
{

    public class Usuario : ICreate, IUpdate, IDelete, IGetAll, IGetById
    {
        public int Create()
        {
            throw new System.NotImplementedException();
        }

        public bool Delete()
        {
            throw new System.NotImplementedException();
        }

        public List<string> GetAll()
        {
            throw new System.NotImplementedException();
        }

        public bool GetById(int id)
        {
            throw new System.NotImplementedException();
        }

        public int Update()
        {
            throw new System.NotImplementedException();
        }
    }
}
