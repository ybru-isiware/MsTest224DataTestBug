using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MsTest224DataTestBugLib
{
    public class UserService
    {
        public User ParseUserDatas(string datas)
        {
            var splittedDatas = datas.Split(";");

            return new User()
            {
                FirstName = splittedDatas[0],
                LastName = splittedDatas[1]
            };
        }
    }
}
