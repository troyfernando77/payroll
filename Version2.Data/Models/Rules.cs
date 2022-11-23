 

namespace Version2.Data.Models
{
    public class Rule : Entity
    {
        public string RuleName { get; set; }
        public string Category { get; set; }
        public int? Priority { get; set; }
        public int? RuleTarget { get; set; }
        public string Status { get; set; }
        public int ItemNo { get; set; }
    }
    public class CreateorEditRulesDto : Entity
    {
        public string RuleName { get; set; }
        public string Category { get; set; }
        public int? Priority { get; set; }
        public int? RuleTarget { get; set; }
        public string Status { get; set; }
        public int ItemNo { get; set; }
    }
    public class RulesDto : Entity
    {
        public string RuleName { get; set; }
        public string Category { get; set; }
        public int? Priority { get; set; }
        public int? RuleTarget { get; set; }
        public string Status { get; set; }
        public int ItemNo { get; set; }

    }
}
