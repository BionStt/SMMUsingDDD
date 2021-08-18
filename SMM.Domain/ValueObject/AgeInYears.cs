using SMM.Domain.Ddd;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMM.Domain
{
    public class AgeInYears : ValueObject<AgeInYears>
    {
        private readonly int age;
        public AgeInYears(int age)
        {
            this.age = age;
        }

        public static AgeInYears Between(DateTime start, DateTime end)
        {
            return new AgeInYears(end.Year - start.Year);
        }
        protected override IEnumerable<object> GetAttributesToIncludeInEqualityCheck()
        {
            yield return age;
        }
        //public static AgeInYears Years(int age)
        //{
        //    return new AgeInYears(age);
        //}

    }

    public static class AgeInYearsExtensions
    {
        public static AgeInYears Years(this int age) => new AgeInYears(age);
    }
}
