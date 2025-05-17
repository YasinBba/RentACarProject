using RentACar.DLLModel;
using RentACar.DLLModel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACar.DLLModel.Interafces
{
    public interface IRules
    {
        string AddRule(Rules rule);
        Rules GetRule(int id);
        string UpdateRule(Rules rule);
        List<Rules> GetAllRules();
        void DeleteRule(int id);
        bool ControlSameRule(string ruleName, string ruleDescription, int id);
        
    }
}
