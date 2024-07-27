using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlinikaVeterinare.BO.Interfaces
{
    // Generic interface
    public interface IBaseCrud<T>
    { 
        // Create
        int Add(T model);

        // Update
        int Modify(T model);

        // Delete - nese celesi eshte ID ose autoincrement
        int Remove(int id);

        // Nese celesi primar eshte prej 2 apo me shume kolonave
        int Remove(T model);

        // Read - nese celesi eshte ID ose autoincrement
        T Get(int id);

        // Read - te mirret sipas modelit nese celesi eshte prej 2 apo me shume kolonave
        T Get(T model);

        // Per me i kthy te dhenat e gjith tabeles
        List<T> GetAll();

    }
}
