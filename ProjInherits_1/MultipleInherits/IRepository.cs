using System.Collections.Generic;

namespace ProjInherits_1.MultipleInherits
{
    // Strategy
    public interface ICreate
    {
        int Create();
    }

    public interface IUpdate
    {
        int Update();
    }

    public interface IDelete
    {
        bool Delete();
    }

    public interface IGetAll
    {
        List<string> GetAll();
    }

    public interface IGetById
    {
        bool GetById(int id);
    }
}
