using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACar.DLLModel.Interafces
{
    public interface IRules
    {
        string AddRule(IRules rule);
        IRules GetRule(int id);
        void UpdateRule(IRules rule);
        List<IRules> GetAllRules();
        void DeleteRule(int id);
        bool ControlSameRule(string ruleName, string ruleDescription, int id);
    }
}
