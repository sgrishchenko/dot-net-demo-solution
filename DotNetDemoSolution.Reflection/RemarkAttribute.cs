using System;

namespace DotNetDemoSolution.Reflection
{
    [AttributeUsage(AttributeTargets.All)]
    public class RemarkAttribute : Attribute
    {
        string remark;
        public string Supplement;
        public RemarkAttribute(string comment)
        {
            remark = comment;
            Supplement = "Missing";
        }
        public string Remark
        {
            get
            {
                return remark;
            }
        }
    }
}
