using System.Collections.Generic;

namespace CodeStack.Data.Models.Base {
    public interface IBase<T> {
        T Default();
        List<T> Get();
        T Get(int key);
        void Post();
        void Put();
        void Delete();

    }
}