using RentACar.DLLModel.Interafces;
using RentACar.DLLModel.Model;
using System;
using System.Collections.Generic;
using System.Linq;


namespace RentACar.BLL
{
    public class RuleManagment : IRules
    {
        public readonly object IRules;
        YasinRentACarEntities db = new YasinRentACarEntities();
        public string AddRule(Rules rule)
        {
            try
            {
                bool saveResult = ControlSameRule(rule.RuleName, rule.RuleDescription, rule.Id);
                if (saveResult)
                {
                    return "Aynı Kural Adı ve Açıklaması mevcut";
                }
                db.Rules.Add(rule);
                int result = db.SaveChanges();
                if (result > 0)
                {
                    return "Success";
                }
                else
                {
                    return "Failed";
                }


            }
            catch (Exception ex)
            {
                return "Error: " + ex.Message;
            }
        }
        public bool ControlSameRule(string ruleName, string ruleDescription, int id)
        {
            if (db.Rules.Any(c => c.RuleName == ruleName && c.RuleDescription == ruleDescription && c.Id != id))
            {
                return true; // Rule already exists
            }
            else
            {
                return false; // Rule does not exist
            }
        }

        public void DeleteRule(int id)
        {
            Rules rule = db.Rules.Find(id);
            if (rule != null)
            {
                db.Rules.Remove(rule);
                db.SaveChanges();
            }
        }
        public List<Rules> GetAllRules()
        {
            return db.Rules.ToList();
        }
        public Rules GetRule(int id)
        {
            return db.Rules.Find(id);
        }

        public string UpdateRule(Rules rule)
        {
            try
            {
                var existingRule = db.Rules.Find(rule.Id);
                if (existingRule != null)
                {
                    existingRule.RuleName = rule.RuleName;
                    existingRule.RuleDuration = rule.RuleDuration;
                    existingRule.RuleDescription = rule.RuleDescription;
                    existingRule.RulePrice = rule.RulePrice;
                    existingRule.UpdateDate = DateTime.Now;
                    existingRule.UpdatorId = rule.UpdatorId;
                    existingRule.Description = rule.Description;
                    existingRule.RentalCarId = rule.RentalCarId;
                    existingRule.IsActive = rule.IsActive;
                    existingRule.CreateDate = rule.CreateDate;
                    existingRule.CreatorId = rule.CreatorId;
                    existingRule.Id = rule.Id;

                    int result = db.SaveChanges();

                    if (result > 0)
                    {
                        return "Update successful";
                    }
                    else
                    {
                        return "Update failed";
                    }
                }
                else
                {
                    return "Rule not found";
                }
            }
            catch (Exception ex)
            {
                return "Error: " + ex.Message;
            }
        }
    }
}
