using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challange_4
{
    public class Member
    {
        public string Name { get; set; }
        public int MemberID { get; set; }
        public double MoneyInBank { get; set; }

        public Member(string name, int memberId, double moneyInBank)
        {
            Name = name;
            MemberID = memberId;
            MoneyInBank = moneyInBank;
        }
    }
}
